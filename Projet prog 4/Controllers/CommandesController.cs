using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projet_prog_4.Data;
using Projet_prog_4.Models.CommandeDTO;

namespace Projet_prog_4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandesController(Projet_prog_4Context context, IMapper mapper) : ControllerBase
    {
        private readonly Projet_prog_4Context _context = context;
        private readonly IMapper _mapper = mapper;

        

       

        // GET: api/Commandes
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetCommandeDTO>>> GetCommande()
        {
            var commandes = await _context.Commande
                .Include(c => c.SiteWeb)
                .ToListAsync();

            return Ok(_mapper.Map<List<GetCommandeDTO>>(commandes));
        }

        // GET: api/Commandes/5
        [Authorize(Roles = "Admin")]
        [HttpGet("{id}")]
        public async Task<ActionResult<GetCommandeDTO>> GetCommande(int id)
        {
            var commande = await _context.Commande
                .Include(c => c.SiteWeb)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (commande == null)
                return NotFound();

            return _mapper.Map<GetCommandeDTO>(commande);
        }

        // PUT: api/Commandes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCommande(int id, PutCommandeDTO dto)
        {
            if (id != dto.Id)
                return BadRequest();

            var commande = await _context.Commande
                .Include(c => c.SiteWeb)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (commande == null)
                return NotFound();

            _mapper.Map(dto, commande);

            // Mettre à jour les relations avec SiteWeb
            if (dto.SiteWebIds != null)
            {
                commande.SiteWeb = await _context.SiteWeb
                    .Where(s => dto.SiteWebIds.Contains(s.Id))
                    .ToListAsync();
            }

            await _context.SaveChangesAsync();
            return NoContent();
        }



        // POST: api/Commandes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<ActionResult<GetCommandeDTO>> PostCommande(PostCommandeDTO dto)
        {
            var commande = _mapper.Map<Commande>(dto);

            // Charger les objets SiteWeb à partir des IDs
            if (dto.SiteWebIds != null)
            {
                commande.SiteWeb = await _context.SiteWeb
                    .Where(s => dto.SiteWebIds.Contains(s.Id))
                    .ToListAsync();
            }

            _context.Commande.Add(commande);
            await _context.SaveChangesAsync();

            var getDto = _mapper.Map<GetCommandeDTO>(commande);
            return CreatedAtAction(nameof(GetCommande), new { id = commande.Id }, getDto);
        }

        // DELETE: api/Commandes/5
        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCommande(int id)
        {

            var commande = await _context.Commande.FindAsync(id);
            
            if (commande == null)
            {
                return NotFound();
            }

            _context.Commande.Remove(commande);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CommandeExists(int id)
        {
            return _context.Commande.Any(e => e.Id == id);
        }
    }
}
