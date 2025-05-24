using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projet_prog_4.Data;
using Projet_prog_4.Models.PanierDTO;
using static Azure.Core.HttpHeader;

namespace Projet_prog_4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaniersController(Projet_prog_4Context context, IMapper mapper, ILogger<PaniersController> logger) : ControllerBase
    {
        private readonly Projet_prog_4Context _context = context;
        private readonly IMapper _mapper = mapper;
        private readonly ILogger<PaniersController> _logger = logger;


        // GET: api/Paniers
        [Authorize]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DetailsPanierDTO>>> GetPaniers()
        {
            var paniers = await _context.Panier.Include(p => p.SiteWeb).ToListAsync();
            return Ok(_mapper.Map<List<DetailsPanierDTO>>(paniers));
        }

        // GET: api/Paniers/5
        [Authorize]
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
        [Authorize(Roles = "Utilisateur")]
        [HttpGet("{userId}")]
        public async Task<ActionResult<DetailsPanierDTO>> GetPanier(string userId)
        {
            var IdUserConnecte = User.FindFirst("uid")?.Value;
            if (IdUserConnecte != userId)
                return Forbid();

            var panier = await _context.Panier
                .Include(p => p.SiteWeb)
                .FirstOrDefaultAsync(p => p.UserId == userId);

            if (panier == null)
                return NotFound();

            return _mapper.Map<DetailsPanierDTO>(panier);
        }

        // PUT: api/Paniers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize(Roles = "Utilisateur")]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPanier(int id, PutPanierDTO dto)
        {

            if (id != dto.Id)
                return BadRequest();

            var panier = await _context.Panier
                .Include(p => p.SiteWeb)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (panier == null)
                return NotFound();

            var currentUserId = User.FindFirst("uid")?.Value;
            _logger.LogWarning("===== AUTH LOGS =====");
            _logger.LogWarning("[JWT] sub: {Sub}", currentUserId);
            if (panier.UserId != currentUserId)
                return Forbid(); 

            _mapper.Map(dto, panier);

            if (dto.SiteWebIds != null)
            {
                panier.SiteWeb = await _context.SiteWeb
                    .Where(s => dto.SiteWebIds.Contains(s.Id))
                    .ToListAsync();
            }

            await _context.SaveChangesAsync();
            return NoContent();
        }

        // POST: api/Paniers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize(Roles = "Utilisateur")]
        [HttpPost]
        public async Task<ActionResult<DetailsPanierDTO>> PostPanier(PostPanierDTO dto)
        {
            var panier = _mapper.Map<Panier>(dto);

           
            panier.SiteWeb = await _context.SiteWeb
                .Where(s => dto.SiteWebIds.Contains(s.Id))
                .ToListAsync();

            _context.Panier.Add(panier);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPanier), new { userId = panier.UserId }, _mapper.Map<DetailsPanierDTO>(panier));
        }

        // POST: api/Paniers/{userId}/ajouter
        [Authorize(Roles = "Utilisateur")]
        [HttpPost("{userId}/ajouter")]
        public async Task<IActionResult> AjouterAuPanier(string userId, [FromBody] int siteWebId)
        {
            var currentUserId = User.FindFirst("uid")?.Value;
            
            _logger.LogWarning("===== AUTH LOGS =====");
            _logger.LogWarning("[JWT] sub: {Sub}", currentUserId);
            _logger.LogWarning("[ROUTE] userId: {RouteUserId}", userId);
            
            if (userId != currentUserId)
                return Forbid(); 

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

            return Ok(_mapper.Map<DetailsPanierDTO>(panier));
        }

        // DELETE: api/Paniers/5
        [Authorize(Roles = "Utilisateur")]
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
