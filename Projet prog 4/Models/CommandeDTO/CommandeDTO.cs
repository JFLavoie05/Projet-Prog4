using Projet_prog_4.Models.SiteWebDTO;

namespace Projet_prog_4.Models.CommandeDTO
{
    public class GetCommandeDTO
    {
        public int Id { get; set; }
        public int Total { get; set; }
        public List<GetSiteWebDTO>? SiteWeb { get; set; }
        public string? UserId { get; set; }
    }

    public class PostCommandeDTO
    {
        public int Total { get; set; }
        public List<int> SiteWebIds { get; set; } = new();
        public string? UserId { get; set; }
    }

    public class PutCommandeDTO
    {
        public int Id { get; set; }
        public int Total { get; set; }
        public List<int> SiteWebIds { get; set; } = new();
        public string? UserId { get; set; }
    }
}
