using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using datos;
using entidades.usuarios;
using entidades;

namespace analisis.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class condicionController : ControllerBase
    {
        private readonly dbcontextSis _context;

        public condicionController(dbcontextSis context)
        {
            _context = context;
        }

        // GET: api/condicion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<condicion>>> Getingreso()
        {
            return await _context.condiciones.ToListAsync();
        }

        // GET: api/condicion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<condicion>> Getingreso(int id)
        {
            var condicion = await _context.condiciones.FindAsync(id);

            if (condicion == null)
            {
                return NotFound();
            }

            return condicion;
        }

        // PUT: api/condicion/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Putcondicion(int id, condicion condicion)
        {
            if (id != condicion.idCondicion)
            {
                return BadRequest();
            }

            _context.Entry(condicion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!condicionExists(id))
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
        public async Task<ActionResult<condicion>> Postarticulo(condicion condicion)
        {
            _context.condiciones.Add(condicion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = condicion.idCondicion }, condicion);
        }

        // DELETE: api/condicion/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<condicion>> Deletecondicion(int id)
        {
            var condicion = await _context.condiciones.FindAsync(id);
            if (condicion == null)
            {
                return NotFound();
            }

            _context.condiciones.Remove(condicion);
            await _context.SaveChangesAsync();

            return condicion;
        }

        private bool condicionExists(int id)
        {
            return _context.condiciones.Any(e => e.idCondicion == id);
        }
    }
}