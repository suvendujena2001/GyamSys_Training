using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookAPI.Models;
using Microsoft.AspNetCore.Authorization;

namespace BookAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class StatsController : ControllerBase
    {
        private readonly BooksDbContext _context;

        public StatsController(BooksDbContext context)
        {
            _context = context;
        }

        // GET: api/Stats
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Stat>>> GetStats()
        {

            return await _context.Stats.ToListAsync();
        }

        // GET: api/Stats/5
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Stat>>>  GetStatByBookId(string id)
        {
            var stat = await _context.Stats.Where(s => s.ISBN == id).ToListAsync();


            if (stat == null)
            {
                return NotFound();
            }

            return stat;
        }


        [HttpGet("GetStatCommentsBYUserId/{id}")]
        public async Task<ActionResult<List<Stat>>> GetStatCommentsBYUserId(int id)
        {
            var stat = await _context.Stats.Where(s => s.UserId == id).ToListAsync();


            if (stat == null)
            {
                return NotFound();
            }

            return stat;
        }

        // PUT: api/Stats/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStat(int id, Stat stat)
        {
            if (id != stat.StatsId)
            {
                return BadRequest();
            }

            _context.Entry(stat).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StatExists(id))
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

        // POST: api/Stats
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Stat>> PostStat(Stat stat)
        {
            _context.Stats.Add(stat);
            await _context.SaveChangesAsync();

            return Ok("Added success");
        }

        // DELETE: api/Stats/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStat(int id)
        {
            var stat = await _context.Stats.FindAsync(id);
            if (stat == null)
            {
                return NotFound();
            }

            _context.Stats.Remove(stat);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StatExists(int id)
        {
            return _context.Stats.Any(e => e.StatsId == id);
        }
    }
}
