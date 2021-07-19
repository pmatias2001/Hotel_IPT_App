using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hotel_IPT_App.Data;
using Hotel_IPT_App.Models;

namespace Hotel_IPT_App.Controllers.API
{
    /// <summary>
    /// API controller para interagir com os dados dos quartos
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class QuartosAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public QuartosAPIController(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// lista os quartos existentes na BD
        /// </summary>
        /// <returns></returns>
        // GET: api/QuartosAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<QuartosAPIViewModel>>> GetQuartos()
        {


            var listaQuartos = await _context.Quartos
                                          .Select(c => new QuartosAPIViewModel
                                          {
                                              IdQuarto = c.IdQuarto,
                                              NomeQuarto = c.Descricao
                                          })
                                          .OrderBy(c => c.NomeQuarto)
                                          .ToListAsync();

            return listaQuartos;
        }

        // GET: api/QuartosAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Quartos>> GetQuartos(int id)
        {
            var quartos = await _context.Quartos.FindAsync(id);

            if (quartos == null)
            {
                return NotFound();
            }

            return quartos;
        }

        // PUT: api/QuartosAPI/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutQuartos(int id, Quartos quartos)
        {
            if (id != quartos.IdQuarto)
            {
                return BadRequest();
            }

            _context.Entry(quartos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuartosExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/QuartosAPI
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Quartos>> PostQuartos(Quartos quartos)
        {
            _context.Quartos.Add(quartos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetQuartos", new { id = quartos.IdQuarto }, quartos);
        }

        // DELETE: api/QuartosAPI/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuartos(int id)
        {
            var quartos = await _context.Quartos.FindAsync(id);
            if (quartos == null)
            {
                return NotFound();
            }

            _context.Quartos.Remove(quartos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool QuartosExists(int id)
        {
            return _context.Quartos.Any(e => e.IdQuarto == id);
        }
    }
}
