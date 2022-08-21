using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "023e1470-35c4-4ee6-af84-4d963521e8b9",
                    UserId = "11aeffd0-539c-4ceb-8841-9f7f1e374d35"
                },
                 new IdentityUserRole<string>
                 {
                     RoleId = "17f29565-37e6-41fb-bfde-4a96c7af0ab9",
                     UserId = "025869cc-4581-442e-bc43-16d1999d7d01"
                 }
                );
        }
    }
}
