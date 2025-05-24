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
using Projet_prog_4.Models.SiteWebDTO;

namespace Projet_prog_4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiteWebsController(Projet_prog_4Context context, IMapper mapper, ILogger<SiteWebsController> logger) : ControllerBase
    {
        private readonly Projet_prog_4Context _context = context;
        private readonly IMapper _mapper = mapper;
        private readonly ILogger<SiteWebsController> _logger = logger;


        // GET: api/SiteWebs
        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetSiteWebDTO>>> GetSiteWeb()
        {
            var siteWeb = await _context.SiteWeb.ToListAsync();
            var SiteWebDTO = _mapper.Map<List<GetSiteWebDTO>>(siteWeb);
            return Ok(SiteWebDTO);
        }

        // GET: api/SiteWebs/5
        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<ActionResult<DetailsSiteWebDTO>> GetSiteWeb(int id)
        {
            var siteWeb = await _context.SiteWeb.FirstOrDefaultAsync(s => s.Id == id);

            if (siteWeb == null)
            {
                return NotFound();
            }

            return _mapper.Map<DetailsSiteWebDTO>(siteWeb);
        }

        // PUT: api/SiteWebs/5
        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSiteWeb(int id, PutSiteWebDTO siteWebDTO)
        {
            if (id != siteWebDTO.Id)
                return BadRequest();

            var siteWeb = await _context.SiteWeb.FindAsync(id);
            if (siteWeb == null)
                return NotFound();

            _mapper.Map(siteWebDTO, siteWeb); 

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SiteWebExists(id))
                    return NotFound();
                throw;
            }

            return NoContent();
        }

        // POST: api/SiteWebs
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<ActionResult<DetailsSiteWebDTO>> PostSiteWeb(PostSiteWebDTO siteWebDTO)
        {
            var nouveauSiteWeb = _mapper.Map<SiteWeb>(siteWebDTO);

            _context.SiteWeb.Add(nouveauSiteWeb);
            await _context.SaveChangesAsync();

            var detailsDto = _mapper.Map<DetailsSiteWebDTO>(nouveauSiteWeb);

            return CreatedAtAction(nameof(GetSiteWeb), new { id = nouveauSiteWeb.Id }, detailsDto);
        }

        // DELETE: api/SiteWebs/5
        [Authorize(Roles = "Admin")]
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
