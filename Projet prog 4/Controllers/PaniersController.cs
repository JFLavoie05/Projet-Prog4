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
    public class PaniersController : ControllerBase
    {
        private readonly Projet_prog_4Context _context;

        public PaniersController(Projet_prog_4Context context)
        {
            _context = context;
        }

        // GET: api/Paniers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Panier>>> GetPanier()
        {
            return await _context.Panier.ToListAsync();
        }

        // GET: api/Paniers/5
        [HttpGet("nb-articles/{id}")]
        public async Task<ActionResult<int>> GetNbArticlePanier(int id)
        {
            var panier = await _context.Panier.Include(p => p.SiteWeb).Where(p => p.Id == id).FirstOrDefaultAsync();
            if (panier == null)
            {
                return NotFound();
            }
            int nbArticle = panier.SiteWeb.Count();
            return nbArticle;
        }

        //GET: api/Paniers/5
        [HttpGet("{userid}")]
        public async Task<ActionResult<Panier>> GetPanier(string userId)
        {
            var panier = await _context.Panier.Include(p => p.SiteWeb).FirstOrDefaultAsync(p => p.UserId == userId);


            if (panier == null)
            {
                return NotFound();
            }

            return panier;
        }

        // PUT: api/Paniers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPanier(int id, Panier panier)
        {
            if (id != panier.Id)
            {
                return BadRequest();
            }

            _context.Entry(panier).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PanierExists(id))
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

        // POST: api/Paniers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Panier>> PostPanier(Panier panier)
        {
            _context.Panier.Add(panier);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPanier", new { id = panier.Id }, panier);
        }

        // POST: api/Paniers/{userId}/ajouter
        [HttpPost("{userId}/ajouter")]
        public async Task<IActionResult> AjouterAuPanier(string userId, [FromBody] int siteWebId)
        {
            var panier = await _context.Panier
                .Include(p => p.SiteWeb)
                .FirstOrDefaultAsync(p => p.UserId == userId);

            var site = await _context.SiteWeb.FindAsync(siteWebId);

            if (panier == null || site == null)
                return NotFound();

            if (panier.SiteWeb.Any(s => s.Id == site.Id)) 
                return BadRequest("Ce siteWeb est déjà dans votre panier");

            panier.SiteWeb.Add(site);
            panier.Total += site.Prix ?? 0;
            site.NbRestant = site.NbRestant - 1;

            await _context.SaveChangesAsync();

            return Ok(panier);
        }

        // DELETE: api/Paniers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePanier(int id)
        {
            var panier = await _context.Panier.FindAsync(id);
            if (panier == null)
            {
                return NotFound();
            }

            _context.Panier.Remove(panier);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PanierExists(int id)
        {
            return _context.Panier.Any(e => e.Id == id);
        }
    }
}
