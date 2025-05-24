using Projet_prog_4.Models.SiteWebDTO;

namespace Projet_prog_4.Models.PanierDTO
{
    public class DetailsPanierDTO
    {
        public int Id { get; set; }
        public int Total { get; set; }
        public List<GetSiteWebDTO> SiteWeb { get; set; } = new();
        public string? UserId { get; set; }
    }

    public class PostPanierDTO
    {
        public int Total { get; set; }
        public List<int> SiteWebIds { get; set; } = new();
        public string? UserId { get; set; }
    }

    public class PutPanierDTO
    {
        public int Id { get; set; }
        public int? Total { get; set; } 
        public List<int>? SiteWebIds { get; set; }
        public string? UserId { get; set; }
    }
}
