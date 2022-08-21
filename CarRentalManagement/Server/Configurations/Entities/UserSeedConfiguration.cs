using CarRentalManagement.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                new ApplicationUser { Id = "11aeffd0-539c-4ceb-8841-9f7f1e374d35", Email = "admin@localhost.com", NormalizedEmail = "ADMIN@LOCALHOST.COM", FirstName = "System", LastName = "Admin", UserName = "admin@localhost.com", NormalizedUserName = "ADMIN@LOCALHOST.COM", PasswordHash = hasher.HashPassword(null, "P@ssword1") },
                new ApplicationUser { Id = "025869cc-4581-442e-bc43-16d1999d7d01", Email = "user@localhost.com", NormalizedEmail = "user@LOCALHOST.COM", FirstName = "System", LastName = "User", UserName = "user@localhost.com", NormalizedUserName = "USER@LOCALHOST.COM", PasswordHash = hasher.HashPassword(null, "P@ssword1") }
                );
        }
    }
}
