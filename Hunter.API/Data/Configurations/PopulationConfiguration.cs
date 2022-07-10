using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hunter.API.Data.Configurations
{
    public class PopulationConfiguration : IEntityTypeConfiguration<Population>
    {
        public void Configure(EntityTypeBuilder<Population> builder)
        {
            builder.HasData(
                new Population
                {
                    Id = 1,
                    Evolution = 0,
                    Era = 0,
                    isActive = true,
                    initialEra = "",
                    ProjectId = 1
                }
            );
        }
    }
}
