using Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework.Config
{
    public class UserConfig : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            builder.HasData(
                new IdentityUser
                {
                    UserName = "user",
                    PasswordHash = "user123",
                    Email = "user@gmail.com",
                    EmailConfirmed = true,
                    NormalizedUserName= "USER",

                },
                new IdentityUser
                {
                    UserName = "admin",
                    Email = "admin@gmail.com",
                    NormalizedUserName = "ADMIN",
                    EmailConfirmed = true,
                });

        }

    }

}
