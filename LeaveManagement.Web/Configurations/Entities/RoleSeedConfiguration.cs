using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "5dcc4009-05b4-492f-9c3b-47ebccf33688",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                },
                 new IdentityRole
                 {
                     Id = "5dcc4089-05b4-492f-9c3b-47ecccf33688",
                     Name = "User",
                     NormalizedName = "USER"
                 });
        }
    }
}