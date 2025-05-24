using Projet_prog_4.Data;
using System.ComponentModel.DataAnnotations;

namespace Projet_prog_4.Models.SiteWebDTO
{
    public class DetailsSiteWebDTO
    {
        public int Id { get; set; }
        public string? Image { get; set; }
        public required string Nom { get; set; }
        public string? Lien { get; set; }
        public int? Prix { get; set; }
        public string? Description { get; set; }
        public int NbRestant { get; set; }

    }

    public class GetSiteWebDTO
    {
        public int Id { get; set; }
        public string? Image { get; set; }
        public required string Nom { get; set; }
        public string? Lien { get; set; }
        public int? Prix { get; set; }
        public string? Description { get; set; }
        public int NbRestant { get; set; }
    }

    public class PostSiteWebDTO
    {
        public string? Image { get; set; }
        public required string Nom { get; set; }
        public string? Lien { get; set; }
        public int? Prix { get; set; }
        public string? Description { get; set; }
        public int NbRestant { get; set; }
    }

    public class PutSiteWebDTO
    {
        public int Id { get; set; }
        public string? Image { get; set; }
        public string? Nom { get; set; }
        public string? Lien { get; set; }
        public int? Prix { get; set; }
        public string? Description { get; set; }
        public int NbRestant { get; set; }
    }

}
