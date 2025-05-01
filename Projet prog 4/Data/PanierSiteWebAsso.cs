using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Projet_prog_4.Data
{
     [PrimaryKey(nameof(PanierId), nameof(SiteWebId))]
    public class PanierSiteWebAsso
    {
        public int PanierId { get; set; }
        public int SiteWebId { get; set; }
        public Panier panier { get; set; } = null!; 
        public int nbAchat { get; set; }
    }
}
