namespace Projet_prog_4.Data
{
    public class Commande
    {
        public int Id { get; set; }
        public int Total { get; set; }
        public List<SiteWeb>? SiteWeb { get; set; }
        public string? UserId { get; set; }
    }
}
