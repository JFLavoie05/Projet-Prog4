using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projet_prog_4.Data;

namespace Projet_prog_4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiteWebsController : ControllerBase
    {
        private readonly Projet_prog_4Context _context;

        public SiteWebsController(Projet_prog_4Context context)
        {
            _context = context;
        }

        // GET: api/SiteWebs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SiteWeb>>> GetSiteWeb()
        {
            return await _context.SiteWeb.ToListAsync();
        }

        // GET: api/SiteWebs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SiteWeb>> GetSiteWeb(int id)
        {
            var siteWeb = await _context.SiteWeb.FindAsync(id);

            if (siteWeb == null)
            {
                return NotFound();
            }

            return siteWeb;
        }

        // PUT: api/SiteWebs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSiteWeb(int id, SiteWeb siteWeb)
        {
            if (id != siteWeb.Id)
            {
                return BadRequest();
            }

            _context.Entry(siteWeb).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SiteWebExists(id))
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

        // POST: api/SiteWebs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SiteWeb>> PostSiteWeb(SiteWeb siteWeb)
        {
            _context.SiteWeb.Add(siteWeb);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSiteWeb", new { id = siteWeb.Id }, siteWeb);
        }

        // DELETE: api/SiteWebs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSiteWeb(int id)
        {
            var siteWeb = await _context.SiteWeb.FindAsync(id);
            if (siteWeb == null)
            {
                return NotFound();
            }

            _context.SiteWeb.Remove(siteWeb);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SiteWebExists(int id)
        {
            return _context.SiteWeb.Any(e => e.Id == id);
        }
    }
}
