using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projet_prog_4.Data.SeedConfiguration;
using Projet_prog_4.Data;

namespace Projet_prog_4.Data
{
    public class Projet_prog_4Context : DbContext
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

        }
        public DbSet<Projet_prog_4.Data.Panier> Panier { get; set; } = default!;
    }
}
