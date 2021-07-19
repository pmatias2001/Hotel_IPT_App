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
    [Authorize]
    public class QuartosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public QuartosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Quartos
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Quartos.ToListAsync());
        }

        // GET: Quartos/Details/5
        [AllowAnonymous]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quartos = await _context.Quartos.Include(m => m.ListaFotos)
                .FirstOrDefaultAsync(m => m.IdQuarto == id);
            if (quartos == null)
            {
                return NotFound();
            }

            return View(quartos);
        }

        // GET: Quartos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Quartos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdQuarto,Piso,Descricao,Lotacao,Preco")] Quartos quartos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(quartos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(quartos);
        }

        // GET: Quartos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quartos = await _context.Quartos.FindAsync(id);
            if (quartos == null)
            {
                return NotFound();
            }
            return View(quartos);
        }

        // POST: Quartos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdQuarto,Piso,Descricao,Lotacao,Preco")] Quartos quartos)
        {
            if (id != quartos.IdQuarto)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(quartos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuartosExists(quartos.IdQuarto))
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
            return View(quartos);
        }

        // GET: Quartos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quartos = await _context.Quartos.Include(m => m.ListaFotos)
                .FirstOrDefaultAsync(m => m.IdQuarto == id);
            if (quartos == null)
            {
                return NotFound();
            }

            return View(quartos);
        }

        // POST: Quartos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var quartos = await _context.Quartos.FindAsync(id);
            _context.Quartos.Remove(quartos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuartosExists(int id)
        {
            return _context.Quartos.Any(e => e.IdQuarto == id);
        }
    }
}
