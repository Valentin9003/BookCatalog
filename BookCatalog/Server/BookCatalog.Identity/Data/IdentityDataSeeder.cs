using System.Linq;
using System.Threading.Tasks;
using BookCatalog.Common;
using BookCatalog.Common.Services;
using BookCatalog.Identity.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace BookCatalog.Identity.Data
{
    public class IdentityDataSeeder: IDataSeeder
    {
        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public IdentityDataSeeder(
            UserManager<User> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        public void SeedData()
        {
            if (this.roleManager.Roles.Any())
            {
                return;
            }

            Task
                .Run(async () =>
                {
                    var adminRole = new IdentityRole(Constants.AdministratorRoleName);

                    await this.roleManager.CreateAsync(adminRole);

                    var adminUser = new User
                    {
                        UserName = "valio@abv.com",
                        Email = "valio@abv.com",
                        SecurityStamp = "Value"
                    };

                    await userManager.CreateAsync(adminUser, "Password123456");

                    await userManager.AddToRoleAsync(adminUser, Constants.AdministratorRoleName);
                })
                .GetAwaiter()
                .GetResult();
        }
    }
}

