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
    public class ThanksCardResponsesController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public ThanksCardResponsesController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/ThanksCardResponses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ThanksCardResponse>>> GetThanksCardResponses()
        {
            return await _context.ThanksCardResponses.ToListAsync();
        }

        // GET: api/ThanksCardResponses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ThanksCardResponse>> GetThanksCardResponse(long id)
        {
            var thanksCardResponse = await _context.ThanksCardResponses.FindAsync(id);

            if (thanksCardResponse == null)
            {
                return NotFound();
            }

            return thanksCardResponse;
        }

        // PUT: api/ThanksCardResponses/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutThanksCardResponse(long id, ThanksCardResponse thanksCardResponse)
        {
            if (id != thanksCardResponse.Id)
            {
                return BadRequest();
            }

            _context.Entry(thanksCardResponse).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ThanksCardResponseExists(id))
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

        // POST: api/ThanksCardResponses
        [HttpPost]
        public async Task<ActionResult<ThanksCardResponse>> PostThanksCardResponse(ThanksCardResponse thanksCardResponse)
        {
            _context.ThanksCardResponses.Add(thanksCardResponse);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetThanksCardResponse", new { id = thanksCardResponse.Id }, thanksCardResponse);
        }

        // DELETE: api/ThanksCardResponses/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ThanksCardResponse>> DeleteThanksCardResponse(long id)
        {
            var thanksCardResponse = await _context.ThanksCardResponses.FindAsync(id);
            if (thanksCardResponse == null)
            {
                return NotFound();
            }

            _context.ThanksCardResponses.Remove(thanksCardResponse);
            await _context.SaveChangesAsync();

            return thanksCardResponse;
        }

        private bool ThanksCardResponseExists(long id)
        {
            return _context.ThanksCardResponses.Any(e => e.Id == id);
        }
    }
}
