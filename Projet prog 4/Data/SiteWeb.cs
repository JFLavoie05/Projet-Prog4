namespace Projet_prog_4.Data
{
    public class SiteWeb
    {
        public int Id { get; set; }
        public string? Image { get; set; }
        public required string Nom { get; set; }
        public string? Lien { get; set; }
        public string? Prix { get; set; }
        public string? Description { get; set; }
        public int NbRestant { get; set; }
    }
}
