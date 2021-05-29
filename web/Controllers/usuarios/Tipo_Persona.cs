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
    public class Tipo_PersonaController : ControllerBase
    {
        private readonly dbcontextSis _context;

        public Tipo_PersonaController(dbcontextSis context)
        {
            _context = context;
        }

        // GET: api/Tipo_Persona
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tipo_Persona>>> GetTipo_Persona()
        {
            return await _context.tipopersonas.ToListAsync();
        }

        // GET: api/Tipo_Persona/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tipo_Persona>> GetTipo_Persona(int id)
        {
            var Tipo_Persona = await _context.tipopersonas.FindAsync(id);

            if (Tipo_Persona == null)
            {
                return NotFound();
            }

            return Tipo_Persona;
        }

        // PUT: api/Tipo_Persona/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipo_Persona(int id, Tipo_Persona Tipo_Persona)
        {
            if (id != Tipo_Persona.idpersona)
            {
                return BadRequest();
            }

            _context.Entry(Tipo_Persona).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Tipo_PersonaExists(id))
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
        public async Task<ActionResult<Tipo_Persona>> Postarticulo(Tipo_Persona Tipo_Persona)
        {
            _context.tipopersonas.Add(Tipo_Persona);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = Tipo_Persona.idpersona }, Tipo_Persona);
        }

        // DELETE: api/Tipo_Persona/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tipo_Persona>> DeleteTipo_Persona(int id)
        {
            var Tipo_Persona = await _context.tipopersonas.FindAsync(id);
            if (Tipo_Persona == null)
            {
                return NotFound();
            }

            _context.tipopersonas.Remove(Tipo_Persona);
            await _context.SaveChangesAsync();

            return Tipo_Persona;
        }

        private bool Tipo_PersonaExists(int id)
        {
            return _context.tipopersonas.Any(e => e.idTipo_Persona == id);
        }
    }
}