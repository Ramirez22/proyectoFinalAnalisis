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
    public class ingresoController : ControllerBase
    {
        private readonly dbcontextSis _context;

        public ingresoController(dbcontextSis context)
        {
            _context = context;
        }

        // GET: api/ingreso
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ingreso>>> Getingreso()
        {
            return await _context.ingreso.ToListAsync();
        }

        // GET: api/ingreso/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ingreso>> Getingreso(int id)
        {
            var ingreso = await _context.ingreso.FindAsync(id);

            if (ingreso == null)
            {
                return NotFound();
            }

            return ingreso;
        }

        // PUT: api/ingreso/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Putingreso(int id, ingreso ingreso)
        {
            if (id != ingreso.idingreso)
            {
                return BadRequest();
            }

            _context.Entry(ingreso).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ingresoExists(id))
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
        public async Task<ActionResult<ingreso>> Postarticulo(ingreso ingreso)
        {
            _context.ingreso.Add(ingreso);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = ingreso.idingreso }, ingreso);
        }

        // DELETE: api/ingreso/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ingreso>> Deleteingreso(int id)
        {
            var ingreso = await _context.ingreso.FindAsync(id);
            if (ingreso == null)
            {
                return NotFound();
            }

            _context.ingreso.Remove(ingreso);
            await _context.SaveChangesAsync();

            return ingreso;
        }

        private bool ingresoExists(int id)
        {
            return _context.ingreso.Any(e => e.idingreso == id);
        }
    }
}