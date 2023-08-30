using Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess.EntityFramework
{
    public class ShoppingDbInitializer
    {
        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            // UserManager ve RoleManager servislerini kullanabilmek için bir servis kapsamı yaratıyorum

            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                // Roles ile ilgili kısım

                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                // veritabanındaki identity ile ilgili tablolarda veri var mı/yok mu
                // Role tanımları için örneğin Admin,User gibi. Bunun içinde UserRoles isminde bir static class tanımlıyorum.

                // Admin rolü tanımlı mı
                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));

                // User rolü tanımlı mı
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));
                // -----------------

                // Users ile ilgili kısım
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();

                // Admin haklarına sahip bir user yaratalım

                string adminUserEMail = "admin@gmail.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEMail);

                if (adminUser == null)
                {
                    // böyle bir kullanıcı yoksa

                    var newAdminUser = new AppUser()
                    {
                        UserName = "admin",
                        Email = adminUserEMail,
                        EmailConfirmed = true
                    };

                    await userManager.CreateAsync(newAdminUser, "Admin123*");

                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);


                }
                           
            }
        }

    }
}
