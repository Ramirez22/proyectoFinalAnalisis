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
    public class articuloController : ControllerBase
    {
        private readonly dbcontextSis _context;

        public articuloController(dbcontextSis context)
        {
            _context = context;
        }

        // GET: api/articulo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<articulo>>> Getarticulo()
        {
            return await _context.articulos.ToListAsync();
        }

        // GET: api/articulo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<articulo>> Getarticulo(int id)
        {
            var articulo = await _context.articulos.FindAsync(id);

            if (articulo == null)
            {
                return NotFound();
            }

            return articulo;
        }

        // PUT: api/articulo/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Putarticulo(int id, articulo articulo)
        {
            if (id != articulo.idarticulo)
            {
                return BadRequest();
            }

            _context.Entry(articulo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!articuloExists(id))
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
        public async Task<ActionResult<articulo>> Postarticulo(articulo articulo)
        {
            _context.articulos.Add(articulo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getarticulo", new { id = articulo.idarticulo }, articulo);
        }

        // DELETE: api/articulo/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<articulo>> Deletearticulo(int id)
        {
            var articulo = await _context.articulos.FindAsync(id);
            if (articulo == null)
            {
                return NotFound();
            }

            _context.articulos.Remove(articulo);
            await _context.SaveChangesAsync();

            return articulo;
        }

        private bool articuloExists(int id)
        {
            return _context.articulos.Any(e => e.idarticulo == id);
        }
    }
}