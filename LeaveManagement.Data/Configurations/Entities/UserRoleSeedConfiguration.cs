using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Data.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(new IdentityUserRole<string>{
                RoleId = "5dcc4009-05b4-492f-9c3b-47ebccf33688",
                UserId = "5dca4089-05b4-492f-9c3b-47ebccf33688"
            },
            new IdentityUserRole<string>
            {
                RoleId = "5dcc4089-05b4-492f-9c3b-47ecccf33688",
                UserId = "a569cdd0-692e-4a6e-ab4e-297edf553a3e"
            });
        }
    }
}