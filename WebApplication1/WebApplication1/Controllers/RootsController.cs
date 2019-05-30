using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RootsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public RootsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/Roots
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Root>>> GetRoots()
        {
            return await _context.Roots.ToListAsync();
        }

        // GET: api/Roots/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Root>> GetRoot(int id)
        {
            var root = await _context.Roots.FindAsync(id);

            if (root == null)
            {
                return NotFound();
            }

            return root;
        }

        // PUT: api/Roots/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoot(int id, Root root)
        {
            if (id != root.Id)
            {
                return BadRequest();
            }

            _context.Entry(root).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RootExists(id))
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

        // POST: api/Roots
        [HttpPost]
        public async Task<ActionResult<Root>> PostRoot(Root root)
        {
            _context.Roots.Add(root);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRoot", new { id = root.Id }, root);
        }

        // DELETE: api/Roots/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Root>> DeleteRoot(int id)
        {
            var root = await _context.Roots.FindAsync(id);
            if (root == null)
            {
                return NotFound();
            }

            _context.Roots.Remove(root);
            await _context.SaveChangesAsync();

            return root;
        }

        private bool RootExists(int id)
        {
            return _context.Roots.Any(e => e.Id == id);
        }
    }
}
