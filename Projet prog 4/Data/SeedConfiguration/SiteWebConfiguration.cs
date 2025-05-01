using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Projet_prog_4.Data.SeedConfiguration
{
    public class SiteWebConfiguration : IEntityTypeConfiguration<SiteWeb>
    {
        public void Configure(EntityTypeBuilder<SiteWeb> builder)
        {
            builder.HasData(
                new SiteWeb { Id = 1, Nom = "SiteWeb1", Description = "Description SiteWeb1", Prix = "100000", NbRestant = 500 },
                new SiteWeb { Id = 2, Nom = "SiteWeb2", Description = "Description SiteWeb2", Prix = "500000", NbRestant = 1000 },
                new SiteWeb { Id = 3, Nom = "SiteWeb3", Description = "Description SiteWeb3", Prix = "600000", NbRestant = 2000 },
                new SiteWeb { Id = 4, Nom = "SiteWeb4", Description = "Description SiteWeb4", Prix = "300000", NbRestant = 100 },
                new SiteWeb { Id = 5, Nom = "SiteWeb5", Description = "Description SiteWeb5", Prix = "200000", NbRestant = 8000 },
                new SiteWeb { Id = 6, Nom = "SiteWeb6", Description = "Description SiteWeb6", Prix = "800000", NbRestant = 4000 },
                new SiteWeb { Id = 7, Nom = "SiteWeb7", Description = "Description SiteWeb7", Prix = "1000000", NbRestant = 800 },
                new SiteWeb { Id = 8, Nom = "SiteWeb8", Description = "Description SiteWeb8", Prix = "900000", NbRestant = 1500 }
                );
        }

    }
}
