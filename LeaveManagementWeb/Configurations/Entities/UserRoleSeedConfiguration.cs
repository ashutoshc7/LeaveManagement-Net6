using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementWeb.Web.Configurations.Entities
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId= "266f5b89-def9-450b-8f9c-d467162a0ab2",
                    UserId= "8f63e06a-77eb-473a-ada1-9506d081748c"
                },
                 new IdentityUserRole<string>
                 {
                     RoleId = "866f4b79-dzf9-450b-8f9c-f467162a0ac2",
                     UserId = "266f5b79-ddf9-450b-8f9c-d467162a0aa2"
                 }
             );
        }
    }
}