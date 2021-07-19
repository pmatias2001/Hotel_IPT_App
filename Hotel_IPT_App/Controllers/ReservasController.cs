using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hotel_IPT_App.Models;
using Hotel_IPT_App.Data;
using Microsoft.AspNetCore.Authorization;

namespace Hotel_IPT_App.Controllers
{
    //[Authorize]
    public class ReservasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReservasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Reservas
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Reservas.Include(r => r.Cliente).Include(l => l.ListaQuartos);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Reservas/Details/5
        [AllowAnonymous]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservas = await _context.Reservas
                .Include(r => r.Cliente).Include(l => l.ListaQuartos)
                .FirstOrDefaultAsync(m => m.IdReserva == id);
            if (reservas == null)
            {
                return NotFound();
            }
            //lista de todos os quartos existentes
            ViewBag.ListaDeQuartos = _context.Quartos.OrderBy(c => c.Descricao).ToList();
            return View(reservas);
        }

        // GET: Reservas/Create
        public IActionResult Create()
        {
            ViewData["UserFK"] = new SelectList(_context.Set<Utilizadores>(), "IdUser", "IdUser");
            // obtém a lista de todos os quartos guardados na BD, por ordem alfabética
            ViewBag.ListaDeQuartos = _context.Quartos.OrderBy(c => c.Descricao).ToList();
            return View();
        }

        // POST: Reservas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdReserva,DataInicial,DataFim,NPessoas,UserFK")] Reservas reservas, int[] QuartoEscolhido)
        {
            // avalia se o array de quartos escolhidos está vazio ou não
            if (QuartoEscolhido.Length == 0)
            {
                //É gerada uma mensagem de erro
                ModelState.AddModelError("", "É necessário selecionar pelo menos um quarto.");
                // gerar a lista Quartos que podem ser associadas às Reservas
                ViewBag.ListaDeQuartos = _context.Quartos.OrderBy(c => c.Descricao).ToList();
                // devolver controlo à View
                return View(reservas);
            }
            // avalia se a lotação total dos quartos escolhidos é maior que o número de pessoas
            //if (QuartoEscolhido.Length == 0)
            //{
            //    //É gerada uma mensagem de erro
            //    ModelState.AddModelError("", "Lotação insuficiente para o número de pessoas.");
            //    // devolver controlo à View
            //    return View(quartos);
            //}

            // criar uma lista com os objetos escolhidos dos Quartos
            List<Quartos> listaQuartosEscolhidos = new List<Quartos>();
            // Para cada objeto escolhido..
            foreach (int item in QuartoEscolhido)
            {
                //procurar a categoria
                Quartos Quarto = _context.Quartos.Find(item);
                // adicionar a Categoria à lista
                listaQuartosEscolhidos.Add(Quarto);
            }

            // adicionar a lista ao objeto de "Lesson"
            reservas.ListaQuartos = listaQuartosEscolhidos;

            if (ModelState.IsValid)
            {
                _context.Add(reservas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserFK"] = new SelectList(_context.Set<Utilizadores>(), "IdUser", "IdUser", reservas.UserFK);
            return View(reservas);
        }

        // GET: Reservas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservas = await _context.Reservas
                                         .Include(l => l.ListaQuartos)
                                         .FirstOrDefaultAsync(m => m.IdReserva == id);
            if (reservas == null)
            {
                return NotFound();
            }
            ViewData["UserFK"] = new SelectList(_context.Set<Utilizadores>(), "IdUser", "IdUser", reservas.UserFK);
            ViewBag.ListaDeQuartos = _context.Quartos.OrderBy(c => c.Descricao).ToList();
            return View(reservas);
        }

        // POST: Reservas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdReserva,DataInicial,DataFim,NPessoas,UserFK")] Reservas novaReserva, int[] QuartoEscolhido)
        {
            if (id != novaReserva.IdReserva)
            {
                return NotFound();
            }

            // dados anteriormente guardados da Reserva
            var reservas = await _context.Reservas
                                       .Where(l => l.IdReserva == id)
                                       .Include(l => l.ListaQuartos)
                                       .FirstOrDefaultAsync();

            // obter a lista dos IDs dos Quartos associadas à reserva, antes da edição
            var oldListaQuartos = reservas.ListaQuartos
                                           .Select(c => c.IdQuarto)
                                           .ToList();

            // avaliar se o utilizador alterou algum Quarto associado à Reserva
            // adicionadas -> lista de categorias adicionadas
            // retiradas   -> lista de categorias retiradas
            var adicionadas = QuartoEscolhido.Except(oldListaQuartos);
            var retiradas = oldListaQuartos.Except(QuartoEscolhido.ToList());

            // se algum Quarto foi adicionado ou retirado
            // é necessário alterar a lista de quartos 
            // associada à Reserva
            if (adicionadas.Any() || retiradas.Any())
            {

                if (retiradas.Any())
                {
                    // retirar o Quarto 
                    foreach (int oldQuarto in retiradas)
                    {
                        var quartoToRemove = reservas.ListaQuartos.FirstOrDefault(c => c.IdQuarto == oldQuarto);
                        reservas.ListaQuartos.Remove(quartoToRemove);
                    }
                }
                if (adicionadas.Any())
                {
                    // adicionar o Quarto 
                    foreach (int newQuarto in adicionadas)
                    {
                        var quartoToAdd = await _context.Quartos.FirstOrDefaultAsync(c => c.IdQuarto == newQuarto);
                        reservas.ListaQuartos.Add(quartoToAdd);
                    }
                }
            }

            if (ModelState.IsValid)
            {
                try
                {
                    /* a EF só permite a manipulação de um único objeto de um mesmo tipo
                    *  por esse motivo, como estamos a usar o objeto 'lesson'
                    *  temos de o atualizar com os dados que vêm da View
                    */
                    reservas.DataInicial = novaReserva.DataInicial;
                    reservas.DataFim = novaReserva.DataFim;
                    reservas.NPessoas = novaReserva.NPessoas;
                    reservas.UserFK = novaReserva.UserFK;

                    //adição do objeto 'reservas' para atualização
                    _context.Update(reservas);
                    //commit da atualização
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservasExists(reservas.IdReserva))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserFK"] = new SelectList(_context.Set<Utilizadores>(), "IdUser", "IdUser", reservas.UserFK);
            return View(reservas);
        }

        // GET: Reservas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservas = await _context.Reservas
                .Include(r => r.Cliente).Include(l => l.ListaQuartos)
                .FirstOrDefaultAsync(m => m.IdReserva == id);
            if (reservas == null)
            {
                return NotFound();
            }

            ViewBag.ListaDeQuartos = _context.Quartos.OrderBy(c => c.Descricao).ToList();

            return View(reservas);
        }

        // POST: Reservas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reservas = await _context.Reservas.FindAsync(id);
            _context.Reservas.Remove(reservas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReservasExists(int id)
        {
            return _context.Reservas.Any(e => e.IdReserva == id);
        }
    }
}
