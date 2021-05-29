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
    public class rolController : ControllerBase
    {
        private readonly dbcontextSis _context;

        public rolController(dbcontextSis context)
        {
            _context = context;
        }

        // GET: api/rol
        [HttpGet]
        public async Task<ActionResult<IEnumerable<rol>>> Getrol()
        {
            return await _context.r0les.ToListAsync();
        }

        // GET: api/rol/5
        [HttpGet("{id}")]
        public async Task<ActionResult<rol>> Getrol(int id)
        {
            var rol = await _context.r0les.FindAsync(id);

            if (rol == null)
            {
                return NotFound();
            }

            return rol;
        }

        // PUT: api/rol/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Putrol(int id, rol rol)
        {
            if (id != rol.idrol)
            {
                return BadRequest();
            }

            _context.Entry(rol).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!rolExists(id))
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
        public async Task<ActionResult<rol>> Postarticulo(rol rol)
        {
            _context.r0les.Add(rol);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = rol.idrol }, rol);
        }

        // DELETE: api/rol/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<rol>> Deleterol(int id)
        {
            var rol = await _context.r0les.FindAsync(id);
            if (rol == null)
            {
                return NotFound();
            }

            _context.r0les.Remove(rol);
            await _context.SaveChangesAsync();

            return rol;
        }

        private bool rolExists(int id)
        {
            return _context.r0les.Any(e => e.idrol == id);
        }
    }
}