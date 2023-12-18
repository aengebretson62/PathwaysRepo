using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicApi.Models;

namespace MusicApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicItemsController : ControllerBase
    {
        private readonly MusicContext _context;

        public MusicItemsController(MusicContext context)
        {
            _context = context;
        }

        // GET: api/MusicItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MusicItem>>> GetMusicItems()
        {
          if (_context.MusicItems == null)
          {
              return NotFound();
          }
            return await _context.MusicItems.ToListAsync();
        }

        // GET: api/MusicItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MusicItem>> GetMusicItem(long id)
        {
          if (_context.MusicItems == null)
          {
              return NotFound();
          }
            var musicItem = await _context.MusicItems.FindAsync(id);

            if (musicItem == null)
            {
                return NotFound();
            }

            return musicItem;
        }

        // PUT: api/MusicItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMusicItem(long id, MusicItem musicItem)
        {
            if (id != musicItem.id)
            {
                return BadRequest();
            }

            _context.Entry(musicItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MusicItemExists(id))
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

        // POST: api/MusicItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MusicItem>> PostMusicItem(MusicItem musicItem)
        {
          if (_context.MusicItems == null)
          {
              return Problem("Entity set 'MusicContext.MusicItems'  is null.");
          }
            _context.MusicItems.Add(musicItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetMusicItem), new { id = musicItem.id }, musicItem);
        }

        // DELETE: api/MusicItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMusicItem(long id)
        {
            if (_context.MusicItems == null)
            {
                return NotFound();
            }
            var musicItem = await _context.MusicItems.FindAsync(id);
            if (musicItem == null)
            {
                return NotFound();
            }

            _context.MusicItems.Remove(musicItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MusicItemExists(long id)
        {
            return (_context.MusicItems?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
