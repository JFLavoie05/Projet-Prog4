using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Projet_prog_4.Data.SeedConfiguration
{
    public class SiteWebConfiguration : IEntityTypeConfiguration<SiteWeb>
    {
        public void Configure(EntityTypeBuilder<SiteWeb> builder)
        {
            builder.HasData(
                new SiteWeb { Id = 1, Nom = "SiteWeb1" },
                new SiteWeb { Id = 2, Nom = "SiteWeb2" },
                new SiteWeb { Id = 3, Nom = "SiteWeb3" }
                );
        }

    }
}
