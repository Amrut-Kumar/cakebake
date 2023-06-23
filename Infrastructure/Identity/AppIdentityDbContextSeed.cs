using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager){
            if(!userManager.Users.Any()){
                var user = new AppUser{
                    DisplayName = "Sonu",
                    Email = "sonu_cakebake@gmail.com",
                    UserName = "sonu_admin",
                    Address = new Address{
                        FirstName = "Sonu",
                        LastName = "Skyfire",
                        Street = "Ambedkar Road",
                        City = "Bengaluru",
                        State = "Karnataka",
                        Zipcode = "560066"
                    }
                };

                await userManager.CreateAsync(user, "Sonu@312");
            }
        }
    }
}