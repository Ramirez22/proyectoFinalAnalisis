using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using datos;
using entidades.ventas;
using entidades;

namespace analisis.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleVentaController : ControllerBase
    {
        private readonly dbcontextSis _context;

        public DetalleVentaController(dbcontextSis context)
        {
            _context = context;
        }

        // GET: api/DetalleVenta
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DetalleVenta>>> GetDetalleVenta()
        {
            return await _context.Detaventa.ToListAsync();
        }

        // GET: api/DetalleVenta/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DetalleVenta>> GetDetalleVenta(int id)
        {
            var DetalleVenta = await _context.Detaventa.FindAsync(id);

            if (DetalleVenta == null)
            {
                return NotFound();
            }

            return DetalleVenta;
        }

        // PUT: api/DetalleVenta/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDetalleVenta(int id, DetalleVenta DetalleVenta)
        {
            if (id != DetalleVenta.idDetalleVenta)
            {
                return BadRequest();
            }

            _context.Entry(DetalleVenta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DetalleVentaExists(id))
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
        public async Task<ActionResult<DetalleVenta>> Postarticulo(DetalleVenta DetalleVenta)
        {
            _context.Detaventa.Add(DetalleVenta);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = DetalleVenta.idDetalleVenta }, DetalleVenta);
        }

        // DELETE: api/DetalleVenta/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DetalleVenta>> DeleteDetalleVenta(int id)
        {
            var DetalleVenta = await _context.Detaventa.FindAsync(id);
            if (DetalleVenta == null)
            {
                return NotFound();
            }

            _context.Detaventa.Remove(DetalleVenta);
            await _context.SaveChangesAsync();

            return DetalleVenta;
        }

        private bool DetalleVentaExists(int id)
        {
            return _context.Detaventa.Any(e => e.idDetalleVenta == id);
        }
    }
}