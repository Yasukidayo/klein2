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
    public class ResponsemessagesController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public ResponsemessagesController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/Responsemessages
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Responsemessage>>> GetResponsemessages()
        {
            return await _context.Responsemessages.ToListAsync();
        }

        // GET: api/Responsemessages/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Responsemessage>> GetResponsemessage(long id)
        {
            var responsemessage = await _context.Responsemessages.FindAsync(id);

            if (responsemessage == null)
            {
                return NotFound();
            }

            return responsemessage;
        }

        // PUT: api/Responsemessages/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutResponsemessage(long id, Responsemessage responsemessage)
        {
            if (id != responsemessage.Id)
            {
                return BadRequest();
            }

            _context.Entry(responsemessage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ResponsemessageExists(id))
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

        // POST: api/Responsemessages
        [HttpPost]
        public async Task<ActionResult<Responsemessage>> PostResponsemessage(Responsemessage responsemessage)
        {
            _context.Responsemessages.Add(responsemessage);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetResponsemessage", new { id = responsemessage.Id }, responsemessage);
        }

        // DELETE: api/Responsemessages/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Responsemessage>> DeleteResponsemessage(long id)
        {
            var responsemessage = await _context.Responsemessages.FindAsync(id);
            if (responsemessage == null)
            {
                return NotFound();
            }

            _context.Responsemessages.Remove(responsemessage);
            await _context.SaveChangesAsync();

            return responsemessage;
        }

        private bool ResponsemessageExists(long id)
        {
            return _context.Responsemessages.Any(e => e.Id == id);
        }
    }
}
