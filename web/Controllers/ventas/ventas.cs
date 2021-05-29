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
    public class ventaController : ControllerBase
    {
        private readonly dbcontextSis _context;

        public ventaController(dbcontextSis context)
        {
            _context = context;
        }

        // GET: api/venta
        [HttpGet]
        public async Task<ActionResult<IEnumerable<venta>>> Getventa()
        {
            return await _context.venta.ToListAsync();
        }

        // GET: api/venta/5
        [HttpGet("{id}")]
        public async Task<ActionResult<venta>> Getventa(int id)
        {
            var venta = await _context.venta.FindAsync(id);

            if (venta == null)
            {
                return NotFound();
            }

            return venta;
        }

        // PUT: api/venta/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Putventa(int id, venta venta)
        {
            if (id != venta.idVenta)
            {
                return BadRequest();
            }

            _context.Entry(venta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ventaExists(id))
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
        public async Task<ActionResult<venta>> Postarticulo(venta venta)
        {
            _context.venta.Add(venta);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = venta.idVenta }, venta);
        }

        // DELETE: api/venta/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<venta>> Deleteventa(int id)
        {
            var venta = await _context.venta.FindAsync(id);
            if (venta == null)
            {
                return NotFound();
            }

            _context.venta.Remove(venta);
            await _context.SaveChangesAsync();

            return venta;
        }

        private bool ventaExists(int id)
        {
            return _context.venta.Any(e => e.idVenta == id);
        }
    }
}