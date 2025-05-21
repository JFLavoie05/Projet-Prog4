using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projet_prog_4.Data.SeedConfiguration;
using Projet_prog_4.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Projet_prog_4.Data
{
    public class Projet_prog_4Context : IdentityDbContext<IdentityUser>
    {
        public Projet_prog_4Context (DbContextOptions<Projet_prog_4Context> options)
            : base(options)
        {
        }
        
        public DbSet<Projet_prog_4.Data.SiteWeb> SiteWeb { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new SiteWebConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.Entity<Panier>()
            .HasMany(p => p.SiteWeb)
            .WithMany() 
            .UsingEntity(j => j.ToTable("PanierSiteWeb"));
        }
        public DbSet<Projet_prog_4.Data.Panier> Panier { get; set; } = default!;
        public DbSet<Projet_prog_4.Data.Commande> Commande { get; set; } = default!;
    }
}
