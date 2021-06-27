using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hotel_IPT.Models;
using Hotel_IPT_App.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace Hotel_IPT_App.Controllers
{
    [Authorize]
    public class UtilizadoresController : Controller
    {
        private readonly ApplicationDbContext _context;

        /// <summary>
        /// objeto que sabe interagir com os dados do utilizador q se autentica
        /// </summary>
        private readonly UserManager<ApplicationUser> _userManager;

        public UtilizadoresController(ApplicationDbContext context, 
            UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Utilizadores
        public async Task<IActionResult> Index()
        {
            return View(await _context.Utilizadores.ToListAsync());
        }

        // GET: Utilizadores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var utilizadores = await _context.Utilizadores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (utilizadores == null)
            {
                return NotFound();
            }

            return View(utilizadores);
        }

        //// GET: Utilizadores/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Utilizadores/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,Nome,DataNasc,Email,Contacto,NIF,UserName")] Utilizadores utilizadores)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(utilizadores);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(utilizadores);
        //}

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> ListaUtilizadoresPorAutorizar()
        {

            // quais os Utilizadores ainda não autorizados a aceder ao Sistema?
            // lista com os utilizadores bloqueados
            var listaDeUtilizadores = _userManager.Users.Where(u => u.LockoutEnd > DateTime.Now);
            // lista com os dados dos Utilizadores
            var listaUsers = _context.Utilizadores
                                         .Where(c => listaDeUtilizadores.Select(u => u.Id)
                                                                       .Contains(c.UserName));

            // Enviar os dados para a View
            return View(await listaUsers.ToListAsync());
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> ListaUtilizadoresPorAutorizar(string[] utilizadores)
        {

            // será que algum utilizador foi selecionado?
            if (utilizadores.Count() != 0)
            {
                // há users selecionados
                // para cada um, vamos desbloqueá-los
                foreach (string u in utilizadores)
                {
                    try
                    {
                        // procurar o 'utilizador' na tabela dos Users
                        var user = await _userManager.FindByIdAsync(u);
                        // desbloquear o utilizador
                        await _userManager.SetLockoutEndDateAsync(user, DateTime.Now.AddDays(-1));
                        // como não se pediu ao User para validar o seu email
                        // é preciso aqui validar esse email
                        string codigo = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                        await _userManager.ConfirmEmailAsync(user, codigo);

                        // eventualmente, poderá ser enviado um email para o utilizador a avisar que 
                        // a sua conta foi desbloqueada
                    }
                    catch (Exception)
                    {
                        // deveria haver aqui uma mensagem de erro para o utilizador,
                        // se assim o entender
                    }
                }
            }
            return RedirectToAction("Index");
        }

        // GET: Utilizadores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var utilizadores = await _context.Utilizadores.FindAsync(id);
            if (utilizadores == null)
            {
                return NotFound();
            }
            return View(utilizadores);
        }

        // POST: Utilizadores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,DataNasc,Email,Contacto,NIF,UserName")] Utilizadores utilizadores)
        {
            if (id != utilizadores.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(utilizadores);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UtilizadoresExists(utilizadores.Id))
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
            return View(utilizadores);
        }

        // GET: Utilizadores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var utilizadores = await _context.Utilizadores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (utilizadores == null)
            {
                return NotFound();
            }

            return View(utilizadores);
        }

        // POST: Utilizadores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var utilizadores = await _context.Utilizadores.FindAsync(id);
            _context.Utilizadores.Remove(utilizadores);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UtilizadoresExists(int id)
        {
            return _context.Utilizadores.Any(e => e.Id == id);
        }
    }
}
