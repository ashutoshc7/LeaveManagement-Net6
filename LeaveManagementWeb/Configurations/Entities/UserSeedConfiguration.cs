using LeaveManagementWeb.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementWeb.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "8f63e06a-77eb-473a-ada1-9506d081748c",
                    Email = "admin@test.com",
                    NormalizedEmail = "ADMIN@TEST.COM",
                    UserName = "admin@test.com",
                    Firstname = "Aman",
                    Lastname = "Mishra",
                    PasswordHash = hasher.HashPassword(null, "Amandev@10"),
                    EmailConfirmed = true
                },
                 new Employee
                 {
                     Id = "266f5b79-ddf9-450b-8f9c-d467162a0aa2",
                     Email = "ashuc@gmail.com",
                     NormalizedEmail = "ASHUC@GMAIL.COM",
                     UserName= "ashuc@gmail.com",
                     Firstname = "Ashutosh",
                     Lastname = "Chaudhary",
                     PasswordHash = hasher.HashPassword(null, "Password@123"),
                     EmailConfirmed= true
                 }
              );
        }
    }
}