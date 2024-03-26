using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "5dca4089-05b4-492f-9c3b-47ebccf33688",
                    Email = "admi@admin.com",
                    NormalizedEmail = "ADMI@ADMIN.COM",
                    UserName = "admi@admin.com",
                    NormalizedUserName = "ADMI@ADMIN.COM",
                    Firstname = "System",
                    Lastname = "Admin",
                    TaxId = "1111",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true,
                },
                 new Employee
                 {
                     Id = "a569cdd0-692e-4a6e-ab4e-297edf553a3e",
                     Email = "test@test.com",
                     NormalizedEmail = "TEST@TEST.COM",
                     UserName = "test@test.com",
                     NormalizedUserName = "TEST@TEST.COM",
                     Firstname = "System",
                     Lastname = "User",
                     TaxId = "2222",
                     PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true,

                 }
                );
        }
    }
}