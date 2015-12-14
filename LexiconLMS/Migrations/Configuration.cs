namespace LexiconLMS.Migrations {
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using LexiconLMS.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LexiconLMS.Models.ApplicationDbContext> {
        public Configuration() {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(LexiconLMS.Models.ApplicationDbContext context) {
            // context.Database.

            string[,] groupArray = new string[,]
   	        {
               {".Net", "Kurs för utvecklare .Net/MVC/C# När du genomfört certifieringsprogrammet Certified ASP.NET MVC Development Specialist - C#, har du visat på förmågan att använda grunderna i språket C# och ramverket ASP.NET. Du kan skapa datadrivna webbapplikationer som använder MVC mönstret för att separera data, främja testdriven utveckling (TDD) och kontrollera innehåll. Du kan skapa sofistikerade användargränssnitt som utnyttjar jQuery för att skapa responsiva webbplatser byggda med moderna tekniker inom webbdesign.", },
               {"Sharepoint", "Kurs administratörer Sharepoint"},
               {"Java", "Utvecklare Java"},
               {"Tomte", "Kurs varuhustomte (säsongsberoende)"}
   	        };
            for (int i = 0; i < groupArray.Length / 2; i++) {
                var nName = groupArray[i, 0];
                var nDescription = groupArray[i, 1];
                context.Group.AddOrUpdate
                (g => g.Name,
                  new Group { Id = i + 1, Name = nName, Description = nDescription, StartDate = DateTime.Now.AddDays(-20), EndDate = DateTime.Now.AddDays(40) }
                );
            }




            context.Courses.AddOrUpdate(
              c => c.Name,
              new Course { Id = 1, Name = "C# grundkurs", Description = "Programmeringens grunder med exempel i C# En grundläggande lärobok i programmering. Den fokuserar på det som är gemensamt för de flesta programmeringsspråk – de grundläggande elementen och programkonstruktionerna och hur dessa relaterar till varandra, oberoende av språk Boken går igenom såväl grunderna i strukturerad programmering som grunderna i objektorienterad programmering beskrivs.Inlärningen av ett specifikt programmeringsspråk tonas ner, men exemplen är skrivna i C#.Den är i första hand avsedd för nybörjare i programmering på högskolenivå, men kan läsas av alla som vill lära sig programmeringens grunder.", StartDate = DateTime.Today.AddDays(-45), EndDate = DateTime.Today.AddDays(-40), GroupId = 1 },
              new Course { Id = 2, Name = "C# fortsättingskurs", Description = "Påbyggnad i C#", StartDate = DateTime.Today.AddDays(-39), EndDate = DateTime.Today.AddDays(-35), GroupId = 1 },
              new Course { Id = 3, Name = "Webutveckling", Description = "Utveckla i webapplikationer", StartDate = DateTime.Today.AddDays(-34), EndDate = DateTime.Today.AddDays(-30), GroupId = 1 },
              new Course { Id = 4, Name = "Testmetodik", Description = "Testing, testing...", StartDate = DateTime.Today.AddDays(-29), EndDate = DateTime.Today.AddDays(-25), GroupId = 2 },
              new Course { Id = 5, Name = "C# slutkurs", Description = "Ytterligare påbyggnad i C#", StartDate = DateTime.Today.AddDays(-15), EndDate = DateTime.Today.AddDays(-10), GroupId = 1 },
              new Course { Id = 6, Name = "Sharepoint", Description = "SharePoint för användare Denna utbildning lär dig grunderna i SharePoint. Du får en överblick i programmets struktur och lär dig om integrationen med Microsoft Office (med 2013 som grund för exempel och övningar). Det handlar inte längre enbart om intranät utan även om hur vi hanterar information i vår organisation. Målgrupp Den här kursen riktar sig till SharePointanvändare  och blivande administratörer, redaktörer, informationshanterare, kommunikationsansvariga plus dig som arbetar som supportpersonal och behöver en heltäckande bild. Förkunskaper - Inga speciella förkunskaper krävs. Kursmaterial - På Svenska Vår utbildningsportal stöttar dig genom hela utbildningen. Portalen är tidsbesparande och utformad för att ge dig som deltagare en mer effektiv inlärning - som leder till bättre resultat och större kunskapstillämpning efter kursen. Läs mer här > SharepointDU FÅR LÄRA DIG • Vad är Office 365 • Introduktion till SharePoint • Skillnaden mellan olika SharePoint versioner • Så här arbetar du med SharePoints webbsidor • Förstå hur dokumenthantering fungerar med Office • Lär dig söka i SharePoint. • Introduktion till sociala funktioner i SharePoint • Exempel på projektarbete med SharePoint", StartDate = DateTime.Today.AddDays(-12), EndDate = DateTime.Today.AddDays(-8), GroupId = 2 },  new Course { Id = 7, Name = "Java 2", Description = "Fortsättningskurs i Java", StartDate = DateTime.Today.AddDays(-15), EndDate = DateTime.Today.AddDays(-10), GroupId = 3 },
              new Course { Id = 8, Name = "Projektarbete", Description = "Grupparbete med slutlig redovisning", StartDate = DateTime.Today.AddDays(-1), EndDate = DateTime.Today.AddDays(-3), GroupId = 1 }
            );

            context.Activities.AddOrUpdate(
              a => a.Name,
              new Activities { Id = 1, ActivityType = ActivityTypeEnum.ELearning, Name = "C# Fundamentals", Description = "A Scott Allen video about C#", StartTime = DateTime.Today.AddDays(-45), EndTime = DateTime.Today.AddDays(-40), Deadline = false, CourseId = 1 },
              new Activities { Id = 2, ActivityType = ActivityTypeEnum.Excercise, Name = "Garage 1.0", Description = "Sätta upp ett garage", StartTime = DateTime.Today.AddDays(-35), EndTime = DateTime.Today.AddDays(-30), Deadline = true, CourseId = 1 },
              new Activities { Id = 3, ActivityType = ActivityTypeEnum.Lecture, Name = "Garage 1.1", Description = "Sätta upp ett garage", StartTime = DateTime.Today.AddDays(-35), EndTime = DateTime.Today.AddDays(-30), Deadline = false, CourseId = 1 },
              new Activities { Id = 4, ActivityType = ActivityTypeEnum.Other, Name = "Garage 1.2", Description = "Sätta upp ett garage", StartTime = DateTime.Today.AddDays(-35), EndTime = DateTime.Today.AddDays(-30), Deadline = false, CourseId = 2 },
              new Activities { Id = 5, ActivityType = ActivityTypeEnum.Excercise, Name = "Garage 1.3", Description = "Sätta upp ett garage", StartTime = DateTime.Today.AddDays(-35), EndTime = DateTime.Today.AddDays(-30), Deadline = false, CourseId = 3 },
              new Activities { Id = 6, ActivityType = ActivityTypeEnum.ELearning, Name = "Garage 1.4", Description = "Sätta upp ett garage", StartTime = DateTime.Today.AddDays(-35), EndTime = DateTime.Today.AddDays(-30), Deadline = false, CourseId = 4 },
              new Activities { Id = 7, ActivityType = ActivityTypeEnum.Lecture, Name = "Garage 1.5", Description = "Sätta upp ett garage", StartTime = DateTime.Today.AddDays(-35), EndTime = DateTime.Today.AddDays(-30), Deadline = false, CourseId = 2 },
              new Activities { Id = 8, ActivityType = ActivityTypeEnum.Excercise, Name = "Garage 1.6", Description = "Sätta upp ett garage", StartTime = DateTime.Today.AddDays(-35), EndTime = DateTime.Today.AddDays(-30), Deadline = true, CourseId = 3 }
            );





            var roleStore = new RoleStore<IdentityRole>(context);                                  // Role behöver tilldelas innan user, för att det ska funka att registrera
            var roleManager = new RoleManager<IdentityRole>(roleStore);
            string[] rolesArray = { "Teacher", "Student" };                               //  Skapar array för roles
            foreach (var roleName in rolesArray) {
                if (!roleManager.RoleExists(roleName))                                        // Kollar nedan om rolesen finns sen innan, annars tilldelar man dem
                {
                    var role = new IdentityRole { Name = roleName };
                    roleManager.Create(role);                                                // roleManager används för att skapa rollen
                }
            };


            var userStore = new UserStore<ApplicationUser>(context);                                          // Storen används för att skapa en manager
            var userManager = new UserManager<ApplicationUser>(userStore);

            var user = new ApplicationUser();

            string[, , , , ,] userArray = new string[,,,,,]
   	        {
                {
                    {
                        {
                           {
                        //  {"FirstName", "LastName","Email","Role","Phone"},
                            {"Oscar", "Jakobsson","user1@gmail.com","Teacher","070909090",""},
   	                        {"Jonas", "Jakobsson","user2@gmail.com","Student","07000000","3"},
	                        {"Matti", "Boustedt","user3@gmail.com","Student","070909090","2"},
	                        {"Staffan", "Ericsson","user4@gmail.com","Student","070919091","1"},
	                        {"Kalle", "Anka","user5@gmail.com","Student","070919291","2"},  	
                            {"Adrian", "Luzano","user6@gmail.com","Teacher","070919292",""},  	
                            {"Anna", "Eklund","user7@gmail.com","Student","070919293","4"},  	
                            {"Kenneth", "Forsström","user8@gmail.com","Student","070919294","2"},  	
                            {"Anna", "Ronnegard","user9@gmail.com","Student","070919295","3"},  	
                            {"Christina", "Kronblad","user10@gmail.com","Student","070919296","2"}  	
                           }
                        }
                    }
                }
   	        };

            // Loop based on length.
            // ... Assumes each subarray is five elements long.
            for (int i = 0; i < userArray.Length / 6; i++) {
                // userArray[0, 0, 0, rad, kolumn/element];
                string uFirstName = userArray[0, 0, 0, 0, i, 0];
                string uLastName = userArray[0, 0, 0, 0, i, 1];
                string eMail = userArray[0, 0, 0, 0, i, 2];
                string uTitle = userArray[0, 0, 0, 0, i, 3];
                string uPhone = userArray[0, 0, 0, 0, i, 4];
                string uGroupId = userArray[0, 0, 0, 0, i, 5];



                // GroupId = 2;




                if (!context.Users.Any(u => u.Email == eMail))  // I Users-tabellen kollar vi mot e-mail(förhoppningsvis unikt)
                {

                    if (uGroupId == "")
                    {
                        uGroupId = "0";
                    }

                    // Om grupp id inte har en siffra sätter vi gruppId till null.
                    int? tGroupId = Int32.Parse(uGroupId);
                        
                    if  (!(tGroupId > 0)) {
                       tGroupId = null;
                    }
   

                    //Om användare med detta e-mail inte finns i databasen läggs ny användare upp
                    user = new ApplicationUser {
                        UserName = eMail,
                        FirstName = uFirstName,
                        LastName = uLastName,
                        FullName = uFirstName + " " + uLastName,
                        Email = eMail,
                        Title = uTitle,
                        PhoneNumber = uPhone,
                        GroupId = tGroupId

                        //if (String.IsNullOrEmpty(uGroupId)) 
                        //    GroupId = null;
                        //else
                        //    GroupId = 2;


                    };        // Här skapas en user...
                    userManager.Create(user, "foobar");       // ..och här kopplas usern till vår databas. Usern läggs till med en hash - foobar är "lösenordet"
                    user = userManager.FindByEmail(eMail);    // Sök rätt på vår nyskapade användare och tilldela UserRole med rätt id
                    userManager.AddToRole(user.Id, uTitle);
                }
            }


            context.Documents.AddOrUpdate(
              d => d.Name,
              new Document { Id = 1, Name = "Övning 1", Description = "Övningsuppgift om loopar etc", dateCreated = DateTime.Today.AddDays(-45), GroupId = 1, ApplicationUserId = context.Users.Where(u => u.FirstName == "Oscar").FirstOrDefault().Id },
              new Document { Id = 2, Name = "Kursinformation", Description = "Översikt över delkursen", dateCreated = DateTime.Today.AddDays(-40), CourseId = 1, ApplicationUserId = context.Users.Where(u => u.FirstName == "Staffan").FirstOrDefault().Id },
              new Document { Id = 3, Name = "Inlämningsuppgift 5", Description = "Inlämningsuppgift", dateCreated = DateTime.Today.AddDays(-45), ActivitiesId = 1, ApplicationUserId = context.Users.Where(u => u.FirstName == "Matti").FirstOrDefault().Id },
              new Document { Id = 4, Name = "Inlämningsuppgift 6", Description = "Elevinlämnad inlämningsuppgift", dateCreated = DateTime.Today.AddDays(-35), ActivitiesId = 1, ApplicationUserId = context.Users.Where(u => u.FirstName == "Jonas").FirstOrDefault().Id },
              new Document { Id = 5, Name = "Inlämningsuppgift 7", Description = "Elevinlämnad inlämningsuppgift", dateCreated = DateTime.Today.AddDays(-35), ActivitiesId = 1, ApplicationUserId = context.Users.Where(u => u.FirstName == "Oscar").FirstOrDefault().Id }
            );


        }
    }
}
