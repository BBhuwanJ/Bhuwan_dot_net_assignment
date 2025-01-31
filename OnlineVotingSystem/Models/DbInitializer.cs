using Microsoft.AspNetCore.Identity;
using OnlineVotingSystem.Areas.Identity.Data;
using OnlineVotingSystem.Data;

namespace OnlineVotingSystem.Models
{
    public static class DbInitializer
    {
        public static async Task InitializeAsync(OnlineVotingSystemContext context, IServiceProvider serviceProvider, UserManager<OnlineVotingSystemUser> userManager)
        {
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            string[] roleNames = { "Admin", "Voter", "Candidate" };
            IdentityResult roleResult;
            foreach (var RoleName in roleNames)
            {
                var roleExists = await RoleManager.RoleExistsAsync(RoleName);
                if (!roleExists)
                {
                    roleResult = await RoleManager.CreateAsync(new IdentityRole(RoleName));

                }
            }
            string Email = "admin@eemc.com";
            string Password = "Admin@123";
            if (userManager.FindByEmailAsync(Email).Result == null)
            {
                OnlineVotingSystemUser user = new OnlineVotingSystemUser();
                user.UserName = Email;
                user.Email = Email;
                IdentityResult result = userManager.CreateAsync(user, Password).Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }


        }
    }
}
