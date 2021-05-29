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
    public class estadosController : ControllerBase
    {
        private readonly dbcontextSis _context;

        public estadosController(dbcontextSis context)
        {
            _context = context;
        }

        // GET: api/estados
        [HttpGet]
        public async Task<ActionResult<IEnumerable<estados>>> Getestados()
        {
            return await _context.estados.ToListAsync();
        }

        // GET: api/estados/5
        [HttpGet("{id}")]
        public async Task<ActionResult<estados>> Getestados(int id)
        {
            var estados = await _context.estados.FindAsync(id);

            if (estados == null)
            {
                return NotFound();
            }

            return estados;
        }

        // PUT: api/estados/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Putestados(int id, estados estados)
        {
            if (id != estados.idestado)
            {
                return BadRequest();
            }

            _context.Entry(estados).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!estadosExists(id))
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
        public async Task<ActionResult<estados>> Postarticulo(estados estados)
        {
            _context.estados.Add(estados);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = estados.idestado }, estados);
        }

        // DELETE: api/estados/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<estados>> Deleteestados(int id)
        {
            var estados = await _context.estados.FindAsync(id);
            if (estados == null)
            {
                return NotFound();
            }

            _context.estados.Remove(estados);
            await _context.SaveChangesAsync();

            return estados;
        }

        private bool estadosExists(int id)
        {
            return _context.estados.Any(e => e.idestado == id);
        }
    }
}