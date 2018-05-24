using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieReview.Data;
using MovieReview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieReview.Data
{
    public class RolesDbIntialzer
    {
        public static async Task Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                //1. Create the admin role
                var roleManager = serviceProvider.GetService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync("admin"))
                {
                    //admin role does not exit - let's create it
                    IdentityResult IR = await roleManager.CreateAsync(new IdentityRole("admin"));
                }

                //2.  Create the admin user
                var userManager = serviceProvider.GetService<UserManager<ApplicationUser>>();

                //Check if admin user already exists
                var user = await userManager.FindByEmailAsync("admin@moviereview.com");

                if (user == null)
                {
                    //The admin user represented by admin@identitydemo.com
                    //does not exist - create it

                    user = new ApplicationUser
                    {
                        UserName = "admin@moviereview.com",
                        Email = "admin@moviereview.com",
                        FirstName = "Robert",
                        LastName = "Phillipenko",

                    };
                    //Add it to the database
                    await userManager.CreateAsync(user, "AdminPa55word@");
                    //no lockout for the admin
                    await userManager.SetLockoutEnabledAsync(user, false);

                }//end if

                //3.  Add admin user to the admin role
                IdentityResult result = await userManager.AddToRoleAsync(user, "admin");


            }//end of using statement


        }//end of method
    }//end of class
}//end of namespace
