namespace Projet_prog_4.Data
{
    public class Panier
    {
        public int Id { get; set; }
        public int Total { get; set; }
        public List<SiteWeb>? SiteWeb { get; set; }
    }
}
