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
     
            string[,] groupArray = new string[,]
   	        {
               {".Net", "Kurs för utvecklare .Net/MVC/C#"},
               {"Sharepoint", "Kurs administratörer Sharepoint"},
               {"Java", "Utvecklare Java"},
               {"Tomte", "Kurs varuhustomte (säsongsberoende)"}
   	        };
            for (int i = 0; i < groupArray.Length / 2; i++)
            {
                var nName = groupArray[i, 0];
                var nDescription = groupArray[i, 1];
                context.Group.AddOrUpdate
                ( g => g.Name,
                  new Group { Id = i, Name = nName, Description = nDescription }
                );
            }


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

            string[, , , ,] userArray = new string[,,,,]
   	        {
                {
                    {
                        {
                        //  {"FirstName", "LastName","Email","Role","Phone"},
   	                        {"Adolf", "Hitler","dead.nazze@nazist.de","Student","07000000"},
	                        {"Nisse", "Näsa","nisse.nose@gmail.se","Teacher","070909090"},
	                        {"Donald", "Duck","kalle.anka@gmail.se","Student","070919091"},
	                        {"Mickey", "Mouse","the.rat@gmail.se","Student","070919291"},
  	                        {"Ronald", "Reagan","dead.expresident@gmail.se","Student","070929292"}                        }
                    }
                }
   	        };

            // Loop based on length.
            // ... Assumes each subarray is five elements long.
            for (int i = 0; i < userArray.Length / 5; i++) {
                // userArray[0, 0, 0, rad, kolumn/element];
                string uFirstName = userArray[0, 0, 0, i, 0];
                string uLastName = userArray[0, 0, 0, i, 1];
                string eMail = userArray[0, 0, 0, i, 2];
                string uTitle = userArray[0, 0, 0, i, 3];
                string uPhone = userArray[0, 0, 0, i, 4];
                if (!context.Users.Any(u => u.Email == eMail))  // I Users-tabellen kollar vi mot e-mail(förhoppningsvis unikt)
                {                                               //Om användare med detta e-mail inte finns i databasen läggs ny användare upp
                    user = new ApplicationUser {
                        UserName = eMail,
                        FirstName = uFirstName,
                        LastName = uLastName,
                        Fullname = uFirstName + " " + uLastName,
                        Email = eMail,
                        Title = uTitle,
                        PhoneNumber = uPhone
                    };        // Här skapas en user...
                    userManager.Create(user, "foobar");       // ..och här kopplas usern till vår databas. Usern läggs till med en hash - foobar är "lösenordet"
                    user = userManager.FindByEmail(eMail);    // Sök rätt på vår nysakapade användare och tilldela UserRole med rätt id
                    userManager.AddToRole(user.Id, uTitle);
                }
            }
        }
    }
}
