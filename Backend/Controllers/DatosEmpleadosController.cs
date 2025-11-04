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
    public class DatosEmpleadosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DatosEmpleadosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/DatosEmpleados
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DatosEmpleado>>> GetDatosEmpleado()
        {
            return await _context.DatosEmpleado.ToListAsync();
        }

        // GET: api/DatosEmpleados/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DatosEmpleado>> GetDatosEmpleado(int id)
        {
            var datosEmpleado = await _context.DatosEmpleado.FindAsync(id);

            if (datosEmpleado == null)
            {
                return NotFound();
            }

            return datosEmpleado;
        }

        // PUT: api/DatosEmpleados/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDatosEmpleado(int id, DatosEmpleado datosEmpleado)
        {
            if (id != datosEmpleado.Id)
            {
                return BadRequest();
            }

            _context.Entry(datosEmpleado).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DatosEmpleadoExists(id))
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

        // POST: api/DatosEmpleados
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DatosEmpleado>> PostDatosEmpleado(DatosEmpleado datosEmpleado)
        {
            _context.DatosEmpleado.Add(datosEmpleado);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDatosEmpleado", new { id = datosEmpleado.Id }, datosEmpleado);
        }

        // DELETE: api/DatosEmpleados/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDatosEmpleado(int id)
        {
            var datosEmpleado = await _context.DatosEmpleado.FindAsync(id);
            if (datosEmpleado == null)
            {
                return NotFound();
            }

            _context.DatosEmpleado.Remove(datosEmpleado);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DatosEmpleadoExists(int id)
        {
            return _context.DatosEmpleado.Any(e => e.Id == id);
        }
    }
}
