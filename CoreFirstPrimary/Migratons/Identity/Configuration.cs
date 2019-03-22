using System.Net.Mime;
using CoreFirstPrimary.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CoreFirstPrimary.Migratons.Identity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CoreFirstPrimary.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migratons\Identity";
        }

        protected override void Seed(ApplicationDbContext context)
        {

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            if (!roleManager.RoleExists("Admin"))
            {
                roleManager.Create(new IdentityRole("Admin"));
            }
            if (!roleManager.RoleExists("Guest"))
            {
                roleManager.Create(new IdentityRole("Guest"));
            }

            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            //string[] emails = { "admin@gmail.com", "guest@gmail.com" };
            if (userManager.FindById("1") == null)
            {
                var user = new ApplicationUser
                {
                    Id = "1",
                    UserName = "rokon",
                };
                var result = userManager.Create(user, "123");
                if (result.Succeeded)
                {
                    userManager.AddToRole(userManager.FindById(user.Id).Id, "Admin");
                }
            }
            if (userManager.FindById("guest@gmail.com") == null)
            {
                var user = new ApplicationUser
                {
                    Id = "11",
                    UserName = "guest@gmail.com",
                };
                var result = userManager.Create(user, "123123");
                if (result.Succeeded)
                {
                    userManager.AddToRole(userManager.FindById(user.Id).Id, "Guest");
                }
            }
           
        }
    }
}
