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
            

            //string[,] groupArray = new string[,]
            //{
            //   {".Net", "Kurs för utvecklare .Net/MVC/C# När du genomfört certifieringsprogrammet Certified ASP.NET MVC Development Specialist - C#, har du visat på förmågan att använda grunderna i språket C# och ramverket ASP.NET. Du kan skapa datadrivna webbapplikationer som använder MVC mönstret för att separera data, främja testdriven utveckling (TDD) och kontrollera innehåll. Du kan skapa sofistikerade användargränssnitt som utnyttjar jQuery för att skapa responsiva webbplatser byggda med moderna tekniker inom webbdesign.", },
            //   {"Sharepoint", "Kurs administratörer Sharepoint"},
            //   {"Java", "Utvecklare Java"},
            //   {"IT-Tekniker", "Support och IT-Teknisk utbildning"},
            //   {"Projektledare", "Projektledutbildning, med fokus på arbetsrelaterade frågor."}
            //};
            //for (int i = 0; i < groupArray.Length / 2; i++)
            //{
            //    var nName = groupArray[i, 0];
            //    var nDescription = groupArray[i, 1];
            //    context.Group.AddOrUpdate
            //    (g => g.Name,
            //      new Group { Id = i + 1, Name = nName, Description = nDescription, StartDate = DateTime.Now.AddDays(-20), EndDate = DateTime.Now.AddDays(40) }
            //    );
            //}

            context.Group.AddOrUpdate(
              g => g.Name,
              new Group { Id = 1, Name = ".Net", Description = "Kurs för utvecklare .Net/MVC/C# När du genomfört certifieringsprogrammet Certified ASP.NET MVC Development Specialist - C#, har du visat på förmågan att använda grunderna i språket C# och ramverket ASP.NET. Du kan skapa datadrivna webbapplikationer som använder MVC mönstret för att separera data, främja testdriven utveckling (TDD) och kontrollera innehåll. Du kan skapa sofistikerade användargränssnitt som utnyttjar jQuery för att skapa responsiva webbplatser byggda med moderna tekniker inom webbdesign.", StartDate = DateTime.Now.AddDays(-90), EndDate = DateTime.Now.AddDays(1) },
              new Group { Id = 2, Name = "Sharepoint", Description = "Kurs administratörer Sharepoint", StartDate = DateTime.Now.AddDays(-90), EndDate = DateTime.Now.AddDays(-20) },
              new Group { Id = 3, Name = "Java", Description = "Utveckla i webapplikationer", StartDate = DateTime.Now.AddDays(-60), EndDate = DateTime.Now.AddDays(20) },
              new Group { Id = 4, Name = "IT-Tekniker", Description = "Praktisk Nätverkskurs – grundkurs ger dig den nödvändiga kunskapen om nätverk och tekniken som ser till att vi kan kommunicera. Under utbildningen går vi igenom terminologi, vi tittar på hur ett nätverk sätts upp, arkitekturen som finns bakom, protokoll och standarder. Läromedlet består av ett kursmaterial, med teori och övningar.", StartDate = DateTime.Now.AddDays(-20), EndDate = DateTime.Now.AddDays(-13) },
              new Group { Id = 5, Name = "Arbetsmiljö", Description = "Arbete på tak Teori, praktiska övningar, riskbedömning och säkerhet. Att jobba säkert på tak borde vara en självklarhet för alla som arbetar i denna miljö. Denna kursdag omfattar såväl teori som praktiska övningar och innehåller säkringsmetoder för arbete på tak med olika lutning och hur man beter sig på hala underlag.", StartDate = DateTime.Now.AddDays(-20), EndDate = DateTime.Now.AddDays(40) },
              new Group { Id = 6, Name = "Grafisk produktion", Description = "Vill du kunna retuschera bilder och fotografier i datorn? Arbetar du med layout och grafisk formgivning? Då ska du inte missa den här utbildningen!", StartDate = DateTime.Now.AddDays(-34), EndDate = DateTime.Now.AddDays(54) },
              new Group { Id = 7, Name = "Exchange", Description = "Testing, testing...", StartDate = DateTime.Now.AddDays(-10), EndDate = DateTime.Now.AddDays(74) },
              new Group { Id = 8, Name = "Office", Description = "Testing, testing...", StartDate = DateTime.Now.AddDays(42), EndDate = DateTime.Now.AddDays(93) },
              new Group { Id = 9, Name = "Crystal Reports", Description = "Skapa dina egna rapporter precis som du själv vill ha dem. Crystal Reports är marknadens mest kraftfulla rap-portgenerator med en mängd möjligheter.", StartDate = DateTime.Now.AddDays(-10), EndDate = DateTime.Now.AddDays(23) },
              new Group { Id = 10, Name = "Visio 2013 Grund", Description = "Visio är det perfekta verktyget för dokumentation av bl.a. processer och projekt och denna kurs ger dig färdigheter för att kunna utnyttja programmets funktioner på effektivast möjliga sätt.", StartDate = DateTime.Now.AddDays(-120), EndDate = DateTime.Now.AddDays(-40) },
              new Group { Id = 11, Name = "Windows", Description = "Micosoft har tagit ett stort kliv framåt och Windows 8 är ett operativsystem med både stora utseendemässiga förändringar och många nya, nyttiga funktioner som ger dig en säkrare miljö och effektiviserar arbetet.", StartDate = DateTime.Now.AddDays(-34), EndDate = DateTime.Now.AddDays(55) },
              new Group { Id = 12, Name = "Ny i ledarrollen", Description = "Ny i ledarrollen Att bli chef eller ledare för första gången kan mottas med en skräckblandad förtjusning. Det ställs nya krav på dig som ledare, förväntningarna kan vara höga från dina medarbetare och målen för din verksamhet är högt satta.", StartDate = DateTime.Now.AddDays(-15), EndDate = DateTime.Now.AddDays(60) },
              new Group { Id = 13, Name = "Kommunikativt ledarskap", Description = "Chefens viktigaste redskap är att vara duktig på kommunikation. Med bra, tydlig kommunikation får du människor att växa, skapar förutsättningar för förändring, löser konflikter och problem, skapar tydlighet som i slutändan leder till en lönsam och effektiv organisation.", StartDate = DateTime.Now.AddDays(-93), EndDate = DateTime.Now.AddDays(63) },
              new Group { Id = 14, Name = "Konflikthantering, Det svåra samtalet", Description = "Det svåra samtalet: Som chef har du ansvaret för att samtalet med dina medarbetare sköts strukturerat och professionellt. Det kan vara någon som har hög sjukfrånvaro, alkoholproblem, presterar dåligt, visar dålig arbetsmoral, inte arbetar efter givna processer och uppsägningar m.m.", StartDate = DateTime.Now.AddDays(-55), EndDate = DateTime.Now.AddDays(3) }
            );


            context.Courses.AddOrUpdate(
              c => c.Name,
              new Course { Id = 1, Name = "C# grundkurs", Description = "Programmeringens grunder med exempel i C# En grundläggande lärobok i programmering. Den fokuserar på det som är gemensamt för de flesta programmeringsspråk – de grundläggande elementen och programkonstruktionerna och hur dessa relaterar till varandra, oberoende av språk Boken går igenom såväl grunderna i strukturerad programmering som grunderna i objektorienterad programmering beskrivs.Inlärningen av ett specifikt programmeringsspråk tonas ner, men exemplen är skrivna i C#.Den är i första hand avsedd för nybörjare i programmering på högskolenivå, men kan läsas av alla som vill lära sig programmeringens grunder.", StartDate = DateTime.Today.AddDays(-90), EndDate = DateTime.Today.AddDays(-87), GroupId = 1 },
              new Course { Id = 2, Name = "C# fortsättingskurs", Description = "Kursen tar C#-utvecklaren till nästa nivå genom att bemästra de objektorienterade principerna i kombination med de funktionella inslagen i C#.", StartDate = DateTime.Today.AddDays(-87), EndDate = DateTime.Today.AddDays(-77), GroupId = 1 },
              new Course { Id = 3, Name = "Webutveckling", Description = "Utveckla i webapplikationer", StartDate = DateTime.Today.AddDays(-77), EndDate = DateTime.Today.AddDays(-65), GroupId = 1 },
              new Course { Id = 4, Name = "Testmetodik", Description = "Testing, testing...", StartDate = DateTime.Today.AddDays(-29), EndDate = DateTime.Today.AddDays(-25), GroupId = 2 },
              new Course { Id = 5, Name = "C# slutkurs", Description = "Ytterligare påbyggnad i C#", StartDate = DateTime.Today.AddDays(-64), EndDate = DateTime.Today.AddDays(-60), GroupId = 1 },
              new Course { Id = 6, Name = "Sharepoint", Description = "SharePoint för användare Denna utbildning lär dig grunderna i SharePoint. Du får en överblick i programmets struktur och lär dig om integrationen med Microsoft Office (med 2013 som grund för exempel och övningar). Det handlar inte längre enbart om intranät utan även om hur vi hanterar information i vår organisation. Målgrupp Den här kursen riktar sig till SharePointanvändare  och blivande administratörer, redaktörer, informationshanterare, kommunikationsansvariga plus dig som arbetar som supportpersonal och behöver en heltäckande bild. Förkunskaper - Inga speciella förkunskaper krävs. Kursmaterial - På Svenska Vår utbildningsportal stöttar dig genom hela utbildningen. Portalen är tidsbesparande och utformad för att ge dig som deltagare en mer effektiv inlärning - som leder till bättre resultat och större kunskapstillämpning efter kursen. Läs mer här > SharepointDU FÅR LÄRA DIG • Vad är Office 365 • Introduktion till SharePoint • Skillnaden mellan olika SharePoint versioner • Så här arbetar du med SharePoints webbsidor • Förstå hur dokumenthantering fungerar med Office • Lär dig söka i SharePoint. • Introduktion till sociala funktioner i SharePoint • Exempel på projektarbete med SharePoint", StartDate = DateTime.Today.AddDays(-12), EndDate = DateTime.Today.AddDays(-8), GroupId = 2 },  
              new Course { Id = 7, Name = "Java 2", Description = "Fortsättningskurs i Java", StartDate = DateTime.Today.AddDays(-15), EndDate = DateTime.Today.AddDays(-10), GroupId = 3 },
              new Course { Id = 8, Name = "Developing ASP .NET MVC 4 Web Applications", Description = "In this course, students will learn to develop advanced ASP.NET MVC applications using .NET Framework 4.5 tools and technologies.", StartDate = DateTime.Today.AddDays(-60), EndDate = DateTime.Today.AddDays(-55), GroupId = 1 },
              new Course { Id = 9, Name = "Utveckling av grafiska gränssnitt för Windows-klienter med XAML och MVVM, grund", Description = "Kursen riktar sig till .NET-utvecklare som vill lära sig mer om utveckling av grafiska gränssnitt för Windows-klienter såsom Windows Phone, Windows 8, WPF och Silverlight. Fokus ligger på XAML, som likt HTML är ett markup-språk för att definiera grafiska gränssnitt för Windows-klienter samt MVVM (Model-View-ViewModel) som är ett populärt designmönster som ger möjlighet att separera vyer från vyernas beteende, något som är bra för separation, förvaltningsbarhet och testning.", StartDate = DateTime.Today.AddDays(-55), EndDate = DateTime.Today.AddDays(-43), GroupId = 1 },
              new Course { Id = 10, Name = "Utveckling av grafiska gränssnitt för Windows-klienter med XAML och MVVM, avancerad", Description = "Kursen riktar sig till .NET-utvecklare som vill lära sig mer om utveckling av grafiska gränssnitt för Windows-klienter såsom Windows Phone, Windows 8, WPF och Silverlight. Fokus ligger på XAML, som likt HTML är ett markup-språk för att definiera grafiska gränssnitt för Windows-klienter samt MVVM (Model-View-ViewModel) som är ett populärt designmönster som ger möjlighet att separera vyer från vyernas beteende, något som är bra för separation, förvaltningsbarhet och testning.", StartDate = DateTime.Today.AddDays(-43), EndDate = DateTime.Today.AddDays(-40), GroupId = 1 },
              new Course { Id = 11, Name = "Programming in HTML5 with JavaScript and CSS3, 20480B", Description = "Denna kurs ger en introduktion till HTML5, CSS3 och JavaScript. Kursen är en inkörsport till både webbprogrammet och Windows Store apps vägar utbildning.", StartDate = DateTime.Today.AddDays(-40), EndDate = DateTime.Today.AddDays(-40), GroupId = 1 },
              new Course { Id = 12, Name = "Developing Data Access Solutions with Microsoft Visual Studio 2010, 10265A", Description = "This audience is comprised of professional .NET software developers who use Microsoft Visual Studio in a team-based, medium-sized to large development environment.", StartDate = DateTime.Today.AddDays(-39), EndDate = DateTime.Today.AddDays(-34), GroupId = 1 },
              new Course { Id = 13, Name = "Implementing a Data Warehouse with Microsoft SQL Server, 10777A", Description = "Data warehousing is a solution organizations use to centralize business data for reporting and analysis. This five-day instructor-led course focuses on teaching individuals how to create a data warehouse with SQL Server 2012, implement ETL with SQL Server Integration Services, and validate and cleanse data with SQL Server Data Quality Services and SQL Server Master Data Services. This course helps people prepare for exam 70-463.", StartDate = DateTime.Today.AddDays(-34), EndDate = DateTime.Today.AddDays(-21), GroupId = 1 },
              new Course { Id = 14, Name = "Administering Microsoft SQL Server Databases, 10775A", Description = "Denna fem dagars lärarledda kurs ger deltagarna de kunskaper och färdigheter som behövs för att upprätthålla en Microsoft SQL Server 2012-databas. Kursen fokuserar på hur man använder SQL Server 2012 produktegenskaper och verktyg med anknytning till att upprätthålla en databas. Även denna kurs hjälper dig att förbereda sig för testet 70-462", StartDate = DateTime.Today.AddDays(-20), EndDate = DateTime.Today.AddDays(-19), GroupId = 1 },
              new Course { Id = 15, Name = "Querying Microsoft SQL Server, 10774A", Description = "Detta är en 5-dagars lärarledd kurs som ger deltagarna den tekniska kompetens som krävs för att skriva grundläggande Transact-SQL-frågor för Microsoft SQL Server 2012. Denna kurs är grunden för alla SQL Server-relaterade discipliner, nämligen databasadministration, databasutveckling och Business Intelligence. Denna kurs hjälper människor förbereda sig för tentamen 70-461.", StartDate = DateTime.Today.AddDays(-16), EndDate = DateTime.Today.AddDays(-10), GroupId = 1 },
              new Course { Id = 16, Name = "Programming in C#, 20483", Description = "Målet med kursen är att ge deltagarna de kunskaper och färdigheter som de behöver för att utveckla C#-applikationer för Microsoft. NET-plattformen. Kursen fokuserar på C# programstruktur, språk syntax och detaljer genomförande.", StartDate = DateTime.Today.AddDays(-10), EndDate = DateTime.Today.AddDays(0), GroupId = 1 },
              new Course { Id = 17, Name = "Responsiv design", Description = "Kursen ger dig förutsättningar för att designa och utveckla webbgränssnitt för användning i olika miljöer och sammanhang. Vidare studeras hur gränssnitt kan anpassa sig för både stationära och handhållna enheter. Kursen beskriver aktuella tekniker som HTML5 och CSS3 med avseende på webbens struktur.", StartDate = DateTime.Today.AddDays(0), EndDate = DateTime.Today.AddDays(1), GroupId = 1 }
            );

            context.Activities.AddOrUpdate(
              a => a.Name,
              new Activities { Id = 1, ActivityType = ActivityTypeEnum.ELearning, Name = "Vad är .NET?", Description = "A Scott Allen video about C#", StartTime = DateTime.Today.AddDays(-90), EndTime = DateTime.Today.AddDays(-90), Deadline = false, CourseId = 1 },
              new Activities { Id = 2, ActivityType = ActivityTypeEnum.Excercise, Name = "Vad är CLR?", Description = "Sätta upp ett garage", StartTime = DateTime.Today.AddDays(-89), EndTime = DateTime.Today.AddDays(-89), Deadline = true, CourseId = 1 },
              new Activities { Id = 3, ActivityType = ActivityTypeEnum.Lecture, Name = "Hur fungerar kompileringsmodellen i C#?", Description = "kompilera ett program.", StartTime = DateTime.Today.AddDays(-89), EndTime = DateTime.Today.AddDays(-88), Deadline = false, CourseId = 1 },
              new Activities { Id = 4, ActivityType = ActivityTypeEnum.Other, Name = "Variabler och fält", Description = "Vad är en variabel...egentligen?", StartTime = DateTime.Today.AddDays(-88), EndTime = DateTime.Today.AddDays(-88), Deadline = false, CourseId = 1 },
              new Activities { Id = 5, ActivityType = ActivityTypeEnum.Excercise, Name = "Metoder och properties", Description = "Gå igenom och pröva metoder", StartTime = DateTime.Today.AddDays(-87), EndTime = DateTime.Today.AddDays(-87), Deadline = false, CourseId = 1 },
              new Activities { Id = 6, ActivityType = ActivityTypeEnum.ELearning, Name = "Conditional statements och loopar", Description = "Genomgång utav for loopar och andra loopar", StartTime = DateTime.Today.AddDays(-87), EndTime = DateTime.Today.AddDays(-87), Deadline = false, CourseId = 1 },
              new Activities { Id = 7, ActivityType = ActivityTypeEnum.Lecture, Name = "Tips och trick i Visual Studio", Description = "Hur Visual Studio fungerar", StartTime = DateTime.Today.AddDays(-87), EndTime = DateTime.Today.AddDays(-87), Deadline = false, CourseId = 1 },
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
   	                        {"Jonas", "Jakobsson","user2@gmail.com","Student","0733765334","1"},
	                        {"Matti", "Boustedt","matti.boustedt@hotmail.com","Student","0764563234","2"},
	                        {"Staffan", "Ericsson","staffan.ericsson@tele2.com","Student","0702345436","1"},
	                        {"Erik", "Lönroth","erik.dalonn@yahoo.com","Student","0762342342","2"},  	
                            {"Adrian", "Luzano","adrian.luxzano@lexicon.se","Teacher","070919292",""},  	
                            {"Anna", "Eklund","anna.eklund@hotmail.com","Student","070919293","4"},  	
                            {"Kenneth", "Forsström","kennet.forsstrom@gmail.com","Student","070919294","2"},  	
                            {"Anna", "Ronnegard","anna.ronnegard@gmail.com","Student","070919295","1"}, 
 	                        {"Maria", "Blom","maty84@gmail.com","Student","0732856434","3"},  	
                            {"Ahmin", "Badou","amin.badou@gmail.com","Student","0724573226","1"},  	
                            {"Selma", "Lööf","lovet@gmail.com","Student","0738762883","4"},  	
                            {"Peter", "Ruugard","peter.ruugard@hotmail.com","Student","0728764453","1"},  	
                            {"Sirpi", "Hammar","sirpi.hammar@gmail.com","Student","0763726112","1"},  	
                            {"Ralf", "Torkelsson","ralf.torkelsson@gmail.com","Student","07098337225","5"},  	
                            {"Susanne", "Hofors","susanne.hofors@hushmail.com","Student","0766251442","6"},  	
                            {"Christina", "Kronblad","christina.kronblad@gmail.com","Student","070919296","1"}  	
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
