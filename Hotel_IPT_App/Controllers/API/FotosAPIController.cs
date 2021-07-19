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
    /// Controller API que interage com os dados das Fotografias
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class FotosAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public FotosAPIController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/FotosAPI
        /// <summary>
        /// 'Endpoint' a apresentar os dados da Fotografias,
        ///  para integrar com a app REACT
        ///  Naturalmente, este 'endpoint' poderá ser acedido por outra aplicação qualquer...
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FotosAPIViewModel>>> GetFotos()
        {
            return await _context.Fotos
                                 .Include(f => f.Quarto)
                                 .Select(f => new FotosAPIViewModel
                                 {
                                     IdFoto = f.IdFoto,
                                     NomeFoto = f.Fotografia,
                                     DataFoto = f.Data.ToShortDateString(),
                                     NomeQuarto = f.Quarto.Descricao
                                 })
                                 .ToListAsync();
        }

        // GET: api/FotosAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Fotos>> GetFotos(int id)
        {
            var fotos = await _context.Fotos.FindAsync(id);

            if (fotos == null)
            {
                return NotFound();
            }

            return fotos;
        }

        // PUT: api/FotosAPI/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFotos(int id, Fotos fotos)
        {
            if (id != fotos.IdFoto)
            {
                return BadRequest();
            }

            _context.Entry(fotos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FotosExists(id))
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
        /// <summary>
        /// Endpoint para receber os dados do Formulário de adição de novas fotografias
        /// </summary>
        /// <param name="foto">dados da nova fotografia</param>
        /// <param name="UploadFoto">ficheiro com a imagem da fotografia</param>
        /// <returns></returns>
        // POST: api/FotosAPI
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Fotos>> PostFotos([FromForm]Fotos foto, IFormFile UploadFoto)
        {
            /* - o anotador [FromForm] instrui a ASP .NET Core a aceitar os dados vindos do formulário do React
         *   e associá-los ao objeto interno 'foto'
         * 
         * - o atributo UploadFoto terá um tratamento 100% igual ao que foi feito no controller das Fotos
         */

            // *********************************************************************
            // esta instrução é apenas usada para não se criar uma exceção no código
            foto.Fotografia = "";
            // deverá ser apagada quando se concretizar o trabalho real
            // *********************************************************************
            _context.Fotos.Add(foto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFotos", new { id = foto.IdFoto }, foto);
        }

        // DELETE: api/FotosAPI/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFotos(int id)
        {
            var fotos = await _context.Fotos.FindAsync(id);
            if (fotos == null)
            {
                return NotFound();
            }

            _context.Fotos.Remove(fotos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FotosExists(int id)
        {
            return _context.Fotos.Any(e => e.IdFoto == id);
        }
    }
}
