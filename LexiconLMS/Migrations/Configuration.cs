namespace LexiconLMS.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;                                     // Tillagd manuellt    
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LexiconLMS.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(LexiconLMS.Models.ApplicationDbContext context)
        {

            context.Group.AddOrUpdate(
              g => g.Name,
              new Group{ Id = 1, Name = ".Net", Description = "Kurs i .Net"  },
              new Group { Id = 2, Name = "Sharepoint" },
              new Group { Id = 3, Name = "Java" },
              new Group { Id = 4, Name = ".Net2" }
            );


            var roleStore = new RoleStore<IdentityRole>(context);                                  // Role behöver tilldelas innan user, för att det ska funka att registrera
            var roleManager = new RoleManager<IdentityRole>(roleStore);
            string[] rolesArray = { "Teacher", "Student" };                               //  Skapar array för roles
            foreach (var roleName in rolesArray)
            {
                if (!roleManager.RoleExists(roleName))                                        // Kollar nedan om rolesen finns sen innan, annars tilldelar man dem
                {
                    var role = new IdentityRole { Name = roleName };
                    roleManager.Create(role);                                                // roleManager används för att skapa rollen
                }
            };

            

            var userStore = new UserStore<ApplicationUser>(context);                                          // Storen används för att skapa en manager
            var userManager = new UserManager<ApplicationUser>(userStore);

            var user = new ApplicationUser();

            string[] userArray = { "User1@gmail.se", "User2@gmail.se", "User3@gmail.se", "User4@gmail.se", "User5@gmail.se" };                               //  Skapar array för users

            foreach (var userString in userArray)
            {
                if (!context.Users.Any(u => u.UserName == userString))                              // I Users-tabellen kollar vi om någon heter staffan. Om det inte finns någon, gör nedanstående:
                {
                    user = new ApplicationUser { UserName = userString, Email = userString };                    // Här skapas en user...
                    userManager.Create(user, "foobar");                                                        // ..och här kopplas usern till vår databas. Usern läggs till med en hash - foobar är "lösenordet"
                }
            }

            user = userManager.FindByName("User1@gmail.se");
            userManager.AddToRole(user.Id, "Teacher");
            user = userManager.FindByName("User2@gmail.se");
            userManager.AddToRole(user.Id, "Student");
            //user = userManager.FindByName("User3@gmail.se");
            //userManager.AddToRole(user.Id, "Student");
            //user = userManager.FindByName("User4@gmail.se");
            //userManager.AddToRole(user.Id, "Student");
            //user = userManager.FindByName("User5@gmail.se");
            //userManager.AddToRole(user.Id, "Student");
        }
    }
}
