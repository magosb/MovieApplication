namespace MagsAzureApp.ApplicationDBContext
{
    using MagsAzureApp.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MagsAzureApp.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            MigrationsDirectory = @"ApplicationDBContext";
            ContextKey = "MagsAzureApp.Models.ApplicationDbContext";
        }

        protected override void Seed(MagsAzureApp.Models.ApplicationDbContext context)
        {
            //  enable-migrations -ContextTypeName ApplicationDBContext -MigrationsDirectory:ApplicationDBContext
            //Add-Migration -configuration MagsAzureApp.ApplicationDBContext.Configuration Initial
            //Update-Database -configuration MagsAzureApp.ApplicationDBContext.Configuration -Verbose

            IdentityResult identityResult;
            var roleManager = new RoleManager<IdentityRole>
                (new RoleStore<IdentityRole>(context));
            //create the canEdit role for administrator
            identityResult = roleManager.Create(new IdentityRole("canEdit"));
            var userManager = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context));
            //create a dummy user
            var user = new ApplicationUser()
            {
                UserName = "dummy@dummy.com",
                Email = "dummy@dummy.com"
            };

            identityResult = userManager.Create(user, "password");
            //set the users role to canEdit
            if (identityResult.Succeeded == true)
                identityResult = userManager.AddToRole(user.Id, "canEdit");
        }
    }

  
}
