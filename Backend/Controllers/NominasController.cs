using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Backend.Data;
using Backend.Models;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NominasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public NominasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Nominas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Nomina>>> GetNomina()
        {
            return await _context.Nomina.ToListAsync();
        }

        // GET: api/Nominas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Nomina>> GetNomina(int id)
        {
            var nomina = await _context.Nomina.FindAsync(id);

            if (nomina == null)
            {
                return NotFound();
            }

            return nomina;
        }

        // PUT: api/Nominas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNomina(int id, Nomina nomina)
        {
            if (id != nomina.Id)
            {
                return BadRequest();
            }

            _context.Entry(nomina).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NominaExists(id))
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

        // POST: api/Nominas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Nomina>> PostNomina(Nomina nomina)
        {
            _context.Nomina.Add(nomina);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNomina", new { id = nomina.Id }, nomina);
        }

        // DELETE: api/Nominas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNomina(int id)
        {
            var nomina = await _context.Nomina.FindAsync(id);
            if (nomina == null)
            {
                return NotFound();
            }

            _context.Nomina.Remove(nomina);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool NominaExists(int id)
        {
            return _context.Nomina.Any(e => e.Id == id);
        }
    }
}
