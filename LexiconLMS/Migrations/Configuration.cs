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
               {".Net", "Kurs f�r utvecklare .Net/MVC/C# N�r du genomf�rt certifieringsprogrammet Certified ASP.NET MVC Development Specialist - C#, har du visat p� f�rm�gan att anv�nda grunderna i spr�ket C# och ramverket ASP.NET. Du kan skapa datadrivna webbapplikationer som anv�nder MVC m�nstret f�r att separera data, fr�mja testdriven utveckling (TDD) och kontrollera inneh�ll. Du kan skapa sofistikerade anv�ndargr�nssnitt som utnyttjar jQuery f�r att skapa responsiva webbplatser byggda med moderna tekniker inom webbdesign.", },
               {"Sharepoint", "Kurs administrat�rer Sharepoint"},
               {"Java", "Utvecklare Java"},
               {"Tomte", "Kurs varuhustomte (s�songsberoende)"}
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
              new Course { Id = 1, Name = "C# grundkurs", Description = "Programmeringens grunder med exempel i C# En grundl�ggande l�robok i programmering. Den fokuserar p� det som �r gemensamt f�r de flesta programmeringsspr�k � de grundl�ggande elementen och programkonstruktionerna och hur dessa relaterar till varandra, oberoende av spr�k Boken g�r igenom s�v�l grunderna i strukturerad programmering som grunderna i objektorienterad programmering beskrivs.Inl�rningen av ett specifikt programmeringsspr�k tonas ner, men exemplen �r skrivna i C#.Den �r i f�rsta hand avsedd f�r nyb�rjare i programmering p� h�gskoleniv�, men kan l�sas av alla som vill l�ra sig programmeringens grunder.", StartDate = DateTime.Today.AddDays(-45), EndDate = DateTime.Today.AddDays(-40), GroupId = 1 },
              new Course { Id = 2, Name = "C# forts�ttingskurs", Description = "P�byggnad i C#", StartDate = DateTime.Today.AddDays(-39), EndDate = DateTime.Today.AddDays(-35), GroupId = 1 },
              new Course { Id = 3, Name = "Webutveckling", Description = "Utveckla i webapplikationer", StartDate = DateTime.Today.AddDays(-34), EndDate = DateTime.Today.AddDays(-30), GroupId = 1 },
              new Course { Id = 4, Name = "Testmetodik", Description = "Testing, testing...", StartDate = DateTime.Today.AddDays(-29), EndDate = DateTime.Today.AddDays(-25), GroupId = 2 },
              new Course { Id = 5, Name = "C# slutkurs", Description = "Ytterligare p�byggnad i C#", StartDate = DateTime.Today.AddDays(-15), EndDate = DateTime.Today.AddDays(-10), GroupId = 1 },
              new Course { Id = 6, Name = "Sharepoint", Description = "SharePoint f�r anv�ndare Denna utbildning l�r dig grunderna i SharePoint. Du f�r en �verblick i programmets struktur och l�r dig om integrationen med Microsoft Office (med 2013 som grund f�r exempel och �vningar). Det handlar inte l�ngre enbart om intran�t utan �ven om hur vi hanterar information i v�r organisation. M�lgrupp Den h�r kursen riktar sig till SharePointanv�ndare  och blivande administrat�rer, redakt�rer, informationshanterare, kommunikationsansvariga plus dig som arbetar som supportpersonal och beh�ver en helt�ckande bild. F�rkunskaper - Inga speciella f�rkunskaper kr�vs. Kursmaterial - P� Svenska V�r utbildningsportal st�ttar dig genom hela utbildningen. Portalen �r tidsbesparande och utformad f�r att ge dig som deltagare en mer effektiv inl�rning - som leder till b�ttre resultat och st�rre kunskapstill�mpning efter kursen. L�s mer h�r > SharepointDU F�R L�RA DIG � Vad �r Office 365 � Introduktion till SharePoint � Skillnaden mellan olika SharePoint versioner � S� h�r arbetar du med SharePoints webbsidor � F�rst� hur dokumenthantering fungerar med Office � L�r dig s�ka i SharePoint. � Introduktion till sociala funktioner i SharePoint � Exempel p� projektarbete med SharePoint", StartDate = DateTime.Today.AddDays(-12), EndDate = DateTime.Today.AddDays(-8), GroupId = 2 },  new Course { Id = 7, Name = "Java 2", Description = "Forts�ttningskurs i Java", StartDate = DateTime.Today.AddDays(-15), EndDate = DateTime.Today.AddDays(-10), GroupId = 3 },
              new Course { Id = 8, Name = "Projektarbete", Description = "Grupparbete med slutlig redovisning", StartDate = DateTime.Today.AddDays(-1), EndDate = DateTime.Today.AddDays(-3), GroupId = 1 }
            );

            context.Activities.AddOrUpdate(
              a => a.Name,
              new Activities { Id = 1, ActivityType = ActivityTypeEnum.ELearning, Name = "C# Fundamentals", Description = "A Scott Allen video about C#", StartTime = DateTime.Today.AddDays(-45), EndTime = DateTime.Today.AddDays(-40), Deadline = false, CourseId = 1 },
              new Activities { Id = 2, ActivityType = ActivityTypeEnum.Excercise, Name = "Garage 1.0", Description = "S�tta upp ett garage", StartTime = DateTime.Today.AddDays(-35), EndTime = DateTime.Today.AddDays(-30), Deadline = true, CourseId = 1 },
              new Activities { Id = 3, ActivityType = ActivityTypeEnum.Lecture, Name = "Garage 1.1", Description = "S�tta upp ett garage", StartTime = DateTime.Today.AddDays(-35), EndTime = DateTime.Today.AddDays(-30), Deadline = false, CourseId = 1 },
              new Activities { Id = 4, ActivityType = ActivityTypeEnum.Other, Name = "Garage 1.2", Description = "S�tta upp ett garage", StartTime = DateTime.Today.AddDays(-35), EndTime = DateTime.Today.AddDays(-30), Deadline = false, CourseId = 2 },
              new Activities { Id = 5, ActivityType = ActivityTypeEnum.Excercise, Name = "Garage 1.3", Description = "S�tta upp ett garage", StartTime = DateTime.Today.AddDays(-35), EndTime = DateTime.Today.AddDays(-30), Deadline = false, CourseId = 3 },
              new Activities { Id = 6, ActivityType = ActivityTypeEnum.ELearning, Name = "Garage 1.4", Description = "S�tta upp ett garage", StartTime = DateTime.Today.AddDays(-35), EndTime = DateTime.Today.AddDays(-30), Deadline = false, CourseId = 4 },
              new Activities { Id = 7, ActivityType = ActivityTypeEnum.Lecture, Name = "Garage 1.5", Description = "S�tta upp ett garage", StartTime = DateTime.Today.AddDays(-35), EndTime = DateTime.Today.AddDays(-30), Deadline = false, CourseId = 2 },
              new Activities { Id = 8, ActivityType = ActivityTypeEnum.Excercise, Name = "Garage 1.6", Description = "S�tta upp ett garage", StartTime = DateTime.Today.AddDays(-35), EndTime = DateTime.Today.AddDays(-30), Deadline = true, CourseId = 3 }
            );





            var roleStore = new RoleStore<IdentityRole>(context);                                  // Role beh�ver tilldelas innan user, f�r att det ska funka att registrera
            var roleManager = new RoleManager<IdentityRole>(roleStore);
            string[] rolesArray = { "Teacher", "Student" };                               //  Skapar array f�r roles
            foreach (var roleName in rolesArray) {
                if (!roleManager.RoleExists(roleName))                                        // Kollar nedan om rolesen finns sen innan, annars tilldelar man dem
                {
                    var role = new IdentityRole { Name = roleName };
                    roleManager.Create(role);                                                // roleManager anv�nds f�r att skapa rollen
                }
            };


            var userStore = new UserStore<ApplicationUser>(context);                                          // Storen anv�nds f�r att skapa en manager
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
                            {"Kenneth", "Forsstr�m","user8@gmail.com","Student","070919294","2"},  	
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




                if (!context.Users.Any(u => u.Email == eMail))  // I Users-tabellen kollar vi mot e-mail(f�rhoppningsvis unikt)
                {

                    if (uGroupId == "")
                    {
                        uGroupId = "0";
                    }

                    // Om grupp id inte har en siffra s�tter vi gruppId till null.
                    int? tGroupId = Int32.Parse(uGroupId);
                        
                    if  (!(tGroupId > 0)) {
                       tGroupId = null;
                    }
   

                    //Om anv�ndare med detta e-mail inte finns i databasen l�ggs ny anv�ndare upp
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


                    };        // H�r skapas en user...
                    userManager.Create(user, "foobar");       // ..och h�r kopplas usern till v�r databas. Usern l�ggs till med en hash - foobar �r "l�senordet"
                    user = userManager.FindByEmail(eMail);    // S�k r�tt p� v�r nyskapade anv�ndare och tilldela UserRole med r�tt id
                    userManager.AddToRole(user.Id, uTitle);
                }
            }


            context.Documents.AddOrUpdate(
              d => d.Name,
              new Document { Id = 1, Name = "�vning 1", Description = "�vningsuppgift om loopar etc", dateCreated = DateTime.Today.AddDays(-45), GroupId = 1, ApplicationUserId = context.Users.Where(u => u.FirstName == "Oscar").FirstOrDefault().Id },
              new Document { Id = 2, Name = "Kursinformation", Description = "�versikt �ver delkursen", dateCreated = DateTime.Today.AddDays(-40), CourseId = 1, ApplicationUserId = context.Users.Where(u => u.FirstName == "Staffan").FirstOrDefault().Id },
              new Document { Id = 3, Name = "Inl�mningsuppgift 5", Description = "Inl�mningsuppgift", dateCreated = DateTime.Today.AddDays(-45), ActivitiesId = 1, ApplicationUserId = context.Users.Where(u => u.FirstName == "Matti").FirstOrDefault().Id },
              new Document { Id = 4, Name = "Inl�mningsuppgift 6", Description = "Elevinl�mnad inl�mningsuppgift", dateCreated = DateTime.Today.AddDays(-35), ActivitiesId = 1, ApplicationUserId = context.Users.Where(u => u.FirstName == "Jonas").FirstOrDefault().Id },
              new Document { Id = 5, Name = "Inl�mningsuppgift 7", Description = "Elevinl�mnad inl�mningsuppgift", dateCreated = DateTime.Today.AddDays(-35), ActivitiesId = 1, ApplicationUserId = context.Users.Where(u => u.FirstName == "Oscar").FirstOrDefault().Id }
            );


        }
    }
}
