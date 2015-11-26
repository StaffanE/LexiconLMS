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


            var roleStore = new RoleStore<IdentityRole>(context);                                  // Role beh�ver tilldelas innan user, f�r att det ska funka att registrera
            var roleManager = new RoleManager<IdentityRole>(roleStore);
            string[] rolesArray = { "Teacher", "Student" };                               //  Skapar array f�r roles
            foreach (var roleName in rolesArray)
            {
                if (!roleManager.RoleExists(roleName))                                        // Kollar nedan om rolesen finns sen innan, annars tilldelar man dem
                {
                    var role = new IdentityRole { Name = roleName };
                    roleManager.Create(role);                                                // roleManager anv�nds f�r att skapa rollen
                }
            };

            

            var userStore = new UserStore<ApplicationUser>(context);                                          // Storen anv�nds f�r att skapa en manager
            var userManager = new UserManager<ApplicationUser>(userStore);

            var user = new ApplicationUser();

            string[] userArray = { "User1@gmail.se", "User2@gmail.se", "User3@gmail.se", "User4@gmail.se", "User5@gmail.se" };                               //  Skapar array f�r users

            foreach (var userString in userArray)
            {
                if (!context.Users.Any(u => u.UserName == userString))                              // I Users-tabellen kollar vi om n�gon heter staffan. Om det inte finns n�gon, g�r nedanst�ende:
                {
                    user = new ApplicationUser { UserName = userString, Email = userString };                    // H�r skapas en user...
                    userManager.Create(user, "foobar");                                                        // ..och h�r kopplas usern till v�r databas. Usern l�ggs till med en hash - foobar �r "l�senordet"
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
