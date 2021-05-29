using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using datos;
using entidades.almacen;
using entidades;

namespace analisis.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class detalleIngresoController : ControllerBase
    {
        private readonly dbcontextSis _context;

        public detalleIngresoController(dbcontextSis context)
        {
            _context = context;
        }

        // GET: api/detalleIngreso
        [HttpGet]
        public async Task<ActionResult<IEnumerable<detalleIngreso>>> GetdetalleIngreso()
        {
            return await _context.detalleIngreso.ToListAsync();
        }

        // GET: api/detalleIngreso/5
        [HttpGet("{id}")]
        public async Task<ActionResult<detalleIngreso>> GetdetalleIngreso(int id)
        {
            var detalleIngreso = await _context.detalleIngreso.FindAsync(id);

            if (detalleIngreso == null)
            {
                return NotFound();
            }

            return detalleIngreso;
        }

        // PUT: api/detalleIngreso/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutdetalleIngreso(int id, detalleIngreso detalleIngreso)
        {
            if (id != detalleIngreso.iddetalle_ingreso)
            {
                return BadRequest();
            }

            _context.Entry(detalleIngreso).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!detalleIngresoExists(id))
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

        // POST: api/
        [HttpPost]
        public async Task<ActionResult<detalleIngreso>> PostdetalleIngreso(detalleIngreso detalleIngreso)
        {
            _context.detalleIngreso.Add(detalleIngreso);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetdetalleIngreso", new { id = detalleIngreso.iddetalle_ingreso }, detalleIngreso);
        }

        // DELETE: api/detalleIngreso/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<detalleIngreso>> DeletedetalleIngreso(int id)
        {
            var detalleIngreso = await _context.detalleIngreso.FindAsync(id);
            if (detalleIngreso == null)
            {
                return NotFound();
            }

            _context.detalleIngreso.Remove(detalleIngreso);
            await _context.SaveChangesAsync();

            return detalleIngreso;
        }

        private bool detalleIngresoExists(int id)
        {
            return _context.detalleIngreso.Any(e => e.iddetalle_ingreso == id);
        }
    }
}