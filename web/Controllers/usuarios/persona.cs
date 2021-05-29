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
    public class personaController : ControllerBase
    {
        private readonly dbcontextSis _context;

        public personaController(dbcontextSis context)
        {
            _context = context;
        }

        // GET: api/persona
        [HttpGet]
        public async Task<ActionResult<IEnumerable<persona>>> Getpersona()
        {
            return await _context.personas.ToListAsync();
        }

        // GET: api/persona/5
        [HttpGet("{id}")]
        public async Task<ActionResult<persona>> Getpersona(int id)
        {
            var persona = await _context.personas.FindAsync(id);

            if (persona == null)
            {
                return NotFound();
            }

            return persona;
        }

        // PUT: api/persona/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Putpersona(int id, persona persona)
        {
            if (id != persona.idpersona)
            {
                return BadRequest();
            }

            _context.Entry(persona).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!personaExists(id))
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
        public async Task<ActionResult<persona>> Postarticulo(persona persona)
        {
            _context.personas.Add(persona);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = persona.idpersona }, persona);
        }

        // DELETE: api/persona/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<persona>> Deletepersona(int id)
        {
            var persona = await _context.personas.FindAsync(id);
            if (persona == null)
            {
                return NotFound();
            }

            _context.personas.Remove(persona);
            await _context.SaveChangesAsync();

            return persona;
        }

        private bool personaExists(int id)
        {
            return _context.personas.Any(e => e.idpersona == id);
        }
    }
}