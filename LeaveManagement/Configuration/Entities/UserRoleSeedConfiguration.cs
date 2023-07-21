using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Configuration.Entities
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "2f451fe1-b32c-4ce8-ba33-760777a3c6a2",
                    UserId = "6f416fe1-b80c-4ce8-ba74-760742a3c7a2"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "2f222fe3-b66c-1ce2-ba21-323678d3b3a2",
                    UserId = "c44d5636-a79b-4c37-ac30-82a2ceb84e70"
                }
            );
        }
    }
}