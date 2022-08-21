using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole { Id = "17f29565-37e6-41fb-bfde-4a96c7af0ab9", Name = "User", NormalizedName = "User" },
                new IdentityRole { Id = "023e1470-35c4-4ee6-af84-4d963521e8b9", Name = "Administrator", NormalizedName = "ADMINISTRATOR" }
                );
        }
    }
}
