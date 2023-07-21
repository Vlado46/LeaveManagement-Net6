using LeaveManagement.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Configuration.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
            public void Configure(EntityTypeBuilder<Employee> builder)
            {
                var hasher = new PasswordHasher<Employee>();
                builder.HasData(
                    new Employee
                    {
                        Id = "6f416fe1-b80c-4ce8-ba74-760742a3c7a2",
                        Email = "admin@test.com",
                        NormalizedEmail = "ADMIN@TEST.COM",
                        NormalizedUserName = "ADMIN@TEST.COM",
                        UserName = "admin@test.com",
                        FirstName = "System",
                        LastName = "Admin",
                        PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                        EmailConfirmed = true
                    },                    
                    new Employee
                    {
                        Id = "c44d5636-a79b-4c37-ac30-82a2ceb84e70",
                        Email = "admin2@test.com",
                        NormalizedEmail = "ADMIN2@TEST.COM",
                        NormalizedUserName = "ADMIN2@TEST.COM",
                        UserName = "admin2@test.com",
                        FirstName = "System",
                        LastName = "User",
                        PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                        EmailConfirmed = true
                    }
                );
            }
    }
}