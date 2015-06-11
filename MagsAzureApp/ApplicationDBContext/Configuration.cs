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
                UserName = "user1@contoso.com",
                Email = "user1@contoso.com"
            };

            identityResult = userManager.Create(user, "P_assw0rd1");
            //set the users role to canEdit
            if (identityResult.Succeeded == true)
                identityResult = userManager.AddToRole(user.Id, "canEdit");
        }
        bool AddUserAndRole(MagsAzureApp.Models.ApplicationDbContext context)
        {
            IdentityResult identityResult;
            var roleManager = new RoleManager<IdentityRole>
                (new RoleStore<IdentityRole>(context));
            identityResult = roleManager.Create(new IdentityRole("canEdit"));
            var userManager = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context));
            var user = new ApplicationUser()
            {
                UserName = "admin1@admin.com",
                Email = "admin1@admin.com"
            };
            identityResult = userManager.Create(user, "_Password1234_");
            if (identityResult.Succeeded == false)
                return identityResult.Succeeded;
            identityResult = userManager.AddToRole(user.Id, "canEdit");
            var user2 = new ApplicationUser()
            {
                UserName = "user1@contoso.com",
            };
            identityResult = userManager.Create(user2, "_Password1234_");
            if (identityResult.Succeeded == false)
                return identityResult.Succeeded;
            identityResult = userManager.AddToRole(user2.Id, "canEdit");

            var user3 = new ApplicationUser()
            {
                UserName = "user2@contoso.se",
            };
            identityResult = userManager.Create(user2, "P_assw0rd3");
            if (identityResult.Succeeded == false)
                return identityResult.Succeeded;
            identityResult = userManager.AddToRole(user3.Id, "canEdit");
            return identityResult.Succeeded;
        }
    }

  
}
