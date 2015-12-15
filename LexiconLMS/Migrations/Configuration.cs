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
            //   {".Net", "Kurs f�r utvecklare .Net/MVC/C# N�r du genomf�rt certifieringsprogrammet Certified ASP.NET MVC Development Specialist - C#, har du visat p� f�rm�gan att anv�nda grunderna i spr�ket C# och ramverket ASP.NET. Du kan skapa datadrivna webbapplikationer som anv�nder MVC m�nstret f�r att separera data, fr�mja testdriven utveckling (TDD) och kontrollera inneh�ll. Du kan skapa sofistikerade anv�ndargr�nssnitt som utnyttjar jQuery f�r att skapa responsiva webbplatser byggda med moderna tekniker inom webbdesign.", },
            //   {"Sharepoint", "Kurs administrat�rer Sharepoint"},
            //   {"Java", "Utvecklare Java"},
            //   {"IT-Tekniker", "Support och IT-Teknisk utbildning"},
            //   {"Projektledare", "Projektledutbildning, med fokus p� arbetsrelaterade fr�gor."}
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
              new Group { Id = 1, Name = ".Net", Description = "Kurs f�r utvecklare .Net/MVC/C# N�r du genomf�rt certifieringsprogrammet Certified ASP.NET MVC Development Specialist - C#, har du visat p� f�rm�gan att anv�nda grunderna i spr�ket C# och ramverket ASP.NET. Du kan skapa datadrivna webbapplikationer som anv�nder MVC m�nstret f�r att separera data, fr�mja testdriven utveckling (TDD) och kontrollera inneh�ll. Du kan skapa sofistikerade anv�ndargr�nssnitt som utnyttjar jQuery f�r att skapa responsiva webbplatser byggda med moderna tekniker inom webbdesign.", StartDate = DateTime.Now.AddDays(-90), EndDate = DateTime.Now.AddDays(1) },
              new Group { Id = 2, Name = "Sharepoint", Description = "Kurs administrat�rer Sharepoint", StartDate = DateTime.Now.AddDays(-90), EndDate = DateTime.Now.AddDays(-20) },
              new Group { Id = 3, Name = "Java", Description = "Utveckla i webapplikationer", StartDate = DateTime.Now.AddDays(-60), EndDate = DateTime.Now.AddDays(20) },
              new Group { Id = 4, Name = "IT-Tekniker", Description = "Praktisk N�tverkskurs � grundkurs ger dig den n�dv�ndiga kunskapen om n�tverk och tekniken som ser till att vi kan kommunicera. Under utbildningen g�r vi igenom terminologi, vi tittar p� hur ett n�tverk s�tts upp, arkitekturen som finns bakom, protokoll och standarder. L�romedlet best�r av ett kursmaterial, med teori och �vningar.", StartDate = DateTime.Now.AddDays(-20), EndDate = DateTime.Now.AddDays(-13) },
              new Group { Id = 5, Name = "Arbetsmilj�", Description = "Arbete p� tak Teori, praktiska �vningar, riskbed�mning och s�kerhet. Att jobba s�kert p� tak borde vara en sj�lvklarhet f�r alla som arbetar i denna milj�. Denna kursdag omfattar s�v�l teori som praktiska �vningar och inneh�ller s�kringsmetoder f�r arbete p� tak med olika lutning och hur man beter sig p� hala underlag.", StartDate = DateTime.Now.AddDays(-20), EndDate = DateTime.Now.AddDays(40) },
              new Group { Id = 6, Name = "Grafisk produktion", Description = "Vill du kunna retuschera bilder och fotografier i datorn? Arbetar du med layout och grafisk formgivning? D� ska du inte missa den h�r utbildningen!", StartDate = DateTime.Now.AddDays(-34), EndDate = DateTime.Now.AddDays(54) },
              new Group { Id = 7, Name = "Exchange", Description = "Testing, testing...", StartDate = DateTime.Now.AddDays(-10), EndDate = DateTime.Now.AddDays(74) },
              new Group { Id = 8, Name = "Office", Description = "Testing, testing...", StartDate = DateTime.Now.AddDays(42), EndDate = DateTime.Now.AddDays(93) },
              new Group { Id = 9, Name = "Crystal Reports", Description = "Skapa dina egna rapporter precis som du sj�lv vill ha dem. Crystal Reports �r marknadens mest kraftfulla rap-portgenerator med en m�ngd m�jligheter.", StartDate = DateTime.Now.AddDays(-10), EndDate = DateTime.Now.AddDays(23) },
              new Group { Id = 10, Name = "Visio 2013 Grund", Description = "Visio �r det perfekta verktyget f�r dokumentation av bl.a. processer och projekt och denna kurs ger dig f�rdigheter f�r att kunna utnyttja programmets funktioner p� effektivast m�jliga s�tt.", StartDate = DateTime.Now.AddDays(-120), EndDate = DateTime.Now.AddDays(-40) },
              new Group { Id = 11, Name = "Windows", Description = "Micosoft har tagit ett stort kliv fram�t och Windows 8 �r ett operativsystem med b�de stora utseendem�ssiga f�r�ndringar och m�nga nya, nyttiga funktioner som ger dig en s�krare milj� och effektiviserar arbetet.", StartDate = DateTime.Now.AddDays(-34), EndDate = DateTime.Now.AddDays(55) },
              new Group { Id = 12, Name = "Ny i ledarrollen", Description = "Ny i ledarrollen Att bli chef eller ledare f�r f�rsta g�ngen kan mottas med en skr�ckblandad f�rtjusning. Det st�lls nya krav p� dig som ledare, f�rv�ntningarna kan vara h�ga fr�n dina medarbetare och m�len f�r din verksamhet �r h�gt satta.", StartDate = DateTime.Now.AddDays(-15), EndDate = DateTime.Now.AddDays(60) },
              new Group { Id = 13, Name = "Kommunikativt ledarskap", Description = "Chefens viktigaste redskap �r att vara duktig p� kommunikation. Med bra, tydlig kommunikation f�r du m�nniskor att v�xa, skapar f�ruts�ttningar f�r f�r�ndring, l�ser konflikter och problem, skapar tydlighet som i slut�ndan leder till en l�nsam och effektiv organisation.", StartDate = DateTime.Now.AddDays(-93), EndDate = DateTime.Now.AddDays(63) },
              new Group { Id = 14, Name = "Konflikthantering, Det sv�ra samtalet", Description = "Det sv�ra samtalet: Som chef har du ansvaret f�r att samtalet med dina medarbetare sk�ts strukturerat och professionellt. Det kan vara n�gon som har h�g sjukfr�nvaro, alkoholproblem, presterar d�ligt, visar d�lig arbetsmoral, inte arbetar efter givna processer och upps�gningar m.m.", StartDate = DateTime.Now.AddDays(-55), EndDate = DateTime.Now.AddDays(3) }
            );


            context.Courses.AddOrUpdate(
              c => c.Name,
              new Course { Id = 1, Name = "C# grundkurs", Description = "Programmeringens grunder med exempel i C# En grundl�ggande l�robok i programmering. Den fokuserar p� det som �r gemensamt f�r de flesta programmeringsspr�k � de grundl�ggande elementen och programkonstruktionerna och hur dessa relaterar till varandra, oberoende av spr�k Boken g�r igenom s�v�l grunderna i strukturerad programmering som grunderna i objektorienterad programmering beskrivs.Inl�rningen av ett specifikt programmeringsspr�k tonas ner, men exemplen �r skrivna i C#.Den �r i f�rsta hand avsedd f�r nyb�rjare i programmering p� h�gskoleniv�, men kan l�sas av alla som vill l�ra sig programmeringens grunder.", StartDate = DateTime.Today.AddDays(-90), EndDate = DateTime.Today.AddDays(-87), GroupId = 1 },
              new Course { Id = 2, Name = "C# forts�ttingskurs", Description = "Kursen tar C#-utvecklaren till n�sta niv� genom att bem�stra de objektorienterade principerna i kombination med de funktionella inslagen i C#.", StartDate = DateTime.Today.AddDays(-87), EndDate = DateTime.Today.AddDays(-77), GroupId = 1 },
              new Course { Id = 3, Name = "Webutveckling", Description = "Utveckla i webapplikationer", StartDate = DateTime.Today.AddDays(-77), EndDate = DateTime.Today.AddDays(-65), GroupId = 1 },
              new Course { Id = 4, Name = "Testmetodik", Description = "Testing, testing...", StartDate = DateTime.Today.AddDays(-29), EndDate = DateTime.Today.AddDays(-25), GroupId = 2 },
              new Course { Id = 5, Name = "C# slutkurs", Description = "Ytterligare p�byggnad i C#", StartDate = DateTime.Today.AddDays(-64), EndDate = DateTime.Today.AddDays(-60), GroupId = 1 },
              new Course { Id = 6, Name = "Sharepoint", Description = "SharePoint f�r anv�ndare Denna utbildning l�r dig grunderna i SharePoint. Du f�r en �verblick i programmets struktur och l�r dig om integrationen med Microsoft Office (med 2013 som grund f�r exempel och �vningar). Det handlar inte l�ngre enbart om intran�t utan �ven om hur vi hanterar information i v�r organisation. M�lgrupp Den h�r kursen riktar sig till SharePointanv�ndare  och blivande administrat�rer, redakt�rer, informationshanterare, kommunikationsansvariga plus dig som arbetar som supportpersonal och beh�ver en helt�ckande bild. F�rkunskaper - Inga speciella f�rkunskaper kr�vs. Kursmaterial - P� Svenska V�r utbildningsportal st�ttar dig genom hela utbildningen. Portalen �r tidsbesparande och utformad f�r att ge dig som deltagare en mer effektiv inl�rning - som leder till b�ttre resultat och st�rre kunskapstill�mpning efter kursen. L�s mer h�r > SharepointDU F�R L�RA DIG � Vad �r Office 365 � Introduktion till SharePoint � Skillnaden mellan olika SharePoint versioner � S� h�r arbetar du med SharePoints webbsidor � F�rst� hur dokumenthantering fungerar med Office � L�r dig s�ka i SharePoint. � Introduktion till sociala funktioner i SharePoint � Exempel p� projektarbete med SharePoint", StartDate = DateTime.Today.AddDays(-12), EndDate = DateTime.Today.AddDays(-8), GroupId = 2 },  
              new Course { Id = 7, Name = "Java 2", Description = "Forts�ttningskurs i Java", StartDate = DateTime.Today.AddDays(-15), EndDate = DateTime.Today.AddDays(-10), GroupId = 3 },
              new Course { Id = 8, Name = "Developing ASP .NET MVC 4 Web Applications", Description = "In this course, students will learn to develop advanced ASP.NET MVC applications using .NET Framework 4.5 tools and technologies.", StartDate = DateTime.Today.AddDays(-60), EndDate = DateTime.Today.AddDays(-55), GroupId = 1 },
              new Course { Id = 9, Name = "Utveckling av grafiska gr�nssnitt f�r Windows-klienter med XAML och MVVM, grund", Description = "Kursen riktar sig till .NET-utvecklare som vill l�ra sig mer om utveckling av grafiska gr�nssnitt f�r Windows-klienter s�som Windows Phone, Windows 8, WPF och Silverlight. Fokus ligger p� XAML, som likt HTML �r ett markup-spr�k f�r att definiera grafiska gr�nssnitt f�r Windows-klienter samt MVVM (Model-View-ViewModel) som �r ett popul�rt designm�nster som ger m�jlighet att separera vyer fr�n vyernas beteende, n�got som �r bra f�r separation, f�rvaltningsbarhet och testning.", StartDate = DateTime.Today.AddDays(-55), EndDate = DateTime.Today.AddDays(-43), GroupId = 1 },
              new Course { Id = 10, Name = "Utveckling av grafiska gr�nssnitt f�r Windows-klienter med XAML och MVVM, avancerad", Description = "Kursen riktar sig till .NET-utvecklare som vill l�ra sig mer om utveckling av grafiska gr�nssnitt f�r Windows-klienter s�som Windows Phone, Windows 8, WPF och Silverlight. Fokus ligger p� XAML, som likt HTML �r ett markup-spr�k f�r att definiera grafiska gr�nssnitt f�r Windows-klienter samt MVVM (Model-View-ViewModel) som �r ett popul�rt designm�nster som ger m�jlighet att separera vyer fr�n vyernas beteende, n�got som �r bra f�r separation, f�rvaltningsbarhet och testning.", StartDate = DateTime.Today.AddDays(-43), EndDate = DateTime.Today.AddDays(-40), GroupId = 1 },
              new Course { Id = 11, Name = "Programming in HTML5 with JavaScript and CSS3, 20480B", Description = "Denna kurs ger en introduktion till HTML5, CSS3 och JavaScript. Kursen �r en ink�rsport till b�de webbprogrammet och Windows Store apps v�gar utbildning.", StartDate = DateTime.Today.AddDays(-40), EndDate = DateTime.Today.AddDays(-40), GroupId = 1 },
              new Course { Id = 12, Name = "Developing Data Access Solutions with Microsoft Visual Studio 2010, 10265A", Description = "This audience is comprised of professional .NET software developers who use Microsoft Visual Studio in a team-based, medium-sized to large development environment.", StartDate = DateTime.Today.AddDays(-39), EndDate = DateTime.Today.AddDays(-34), GroupId = 1 },
              new Course { Id = 13, Name = "Implementing a Data Warehouse with Microsoft SQL Server, 10777A", Description = "Data warehousing is a solution organizations use to centralize business data for reporting and analysis. This five-day instructor-led course focuses on teaching individuals how to create a data warehouse with SQL Server 2012, implement ETL with SQL Server Integration Services, and validate and cleanse data with SQL Server Data Quality Services and SQL Server Master Data Services. This course helps people prepare for exam 70-463.", StartDate = DateTime.Today.AddDays(-34), EndDate = DateTime.Today.AddDays(-21), GroupId = 1 },
              new Course { Id = 14, Name = "Administering Microsoft SQL Server Databases, 10775A", Description = "Denna fem dagars l�rarledda kurs ger deltagarna de kunskaper och f�rdigheter som beh�vs f�r att uppr�tth�lla en Microsoft SQL Server 2012-databas. Kursen fokuserar p� hur man anv�nder SQL Server 2012 produktegenskaper och verktyg med anknytning till att uppr�tth�lla en databas. �ven denna kurs hj�lper dig att f�rbereda sig f�r testet 70-462", StartDate = DateTime.Today.AddDays(-20), EndDate = DateTime.Today.AddDays(-19), GroupId = 1 },
              new Course { Id = 15, Name = "Querying Microsoft SQL Server, 10774A", Description = "Detta �r en 5-dagars l�rarledd kurs som ger deltagarna den tekniska kompetens som kr�vs f�r att skriva grundl�ggande Transact-SQL-fr�gor f�r Microsoft SQL Server 2012. Denna kurs �r grunden f�r alla SQL Server-relaterade discipliner, n�mligen databasadministration, databasutveckling och Business Intelligence. Denna kurs hj�lper m�nniskor f�rbereda sig f�r tentamen 70-461.", StartDate = DateTime.Today.AddDays(-16), EndDate = DateTime.Today.AddDays(-10), GroupId = 1 },
              new Course { Id = 16, Name = "Programming in C#, 20483", Description = "M�let med kursen �r att ge deltagarna de kunskaper och f�rdigheter som de beh�ver f�r att utveckla C#-applikationer f�r Microsoft. NET-plattformen. Kursen fokuserar p� C# programstruktur, spr�k syntax och detaljer genomf�rande.", StartDate = DateTime.Today.AddDays(-10), EndDate = DateTime.Today.AddDays(0), GroupId = 1 },
              new Course { Id = 17, Name = "Responsiv design", Description = "Kursen ger dig f�ruts�ttningar f�r att designa och utveckla webbgr�nssnitt f�r anv�ndning i olika milj�er och sammanhang. Vidare studeras hur gr�nssnitt kan anpassa sig f�r b�de station�ra och handh�llna enheter. Kursen beskriver aktuella tekniker som HTML5 och CSS3 med avseende p� webbens struktur.", StartDate = DateTime.Today.AddDays(0), EndDate = DateTime.Today.AddDays(1), GroupId = 1 }
            );

            context.Activities.AddOrUpdate(
              a => a.Name,
              new Activities { Id = 1, ActivityType = ActivityTypeEnum.ELearning, Name = "Vad �r .NET?", Description = "A Scott Allen video about C#", StartTime = DateTime.Today.AddDays(-90), EndTime = DateTime.Today.AddDays(-90), Deadline = false, CourseId = 1 },
              new Activities { Id = 2, ActivityType = ActivityTypeEnum.Excercise, Name = "Vad �r CLR?", Description = "S�tta upp ett garage", StartTime = DateTime.Today.AddDays(-89), EndTime = DateTime.Today.AddDays(-89), Deadline = true, CourseId = 1 },
              new Activities { Id = 3, ActivityType = ActivityTypeEnum.Lecture, Name = "Hur fungerar kompileringsmodellen i C#?", Description = "kompilera ett program.", StartTime = DateTime.Today.AddDays(-89), EndTime = DateTime.Today.AddDays(-88), Deadline = false, CourseId = 1 },
              new Activities { Id = 4, ActivityType = ActivityTypeEnum.Other, Name = "Variabler och f�lt", Description = "Vad �r en variabel...egentligen?", StartTime = DateTime.Today.AddDays(-88), EndTime = DateTime.Today.AddDays(-88), Deadline = false, CourseId = 1 },
              new Activities { Id = 5, ActivityType = ActivityTypeEnum.Excercise, Name = "Metoder och properties", Description = "G� igenom och pr�va metoder", StartTime = DateTime.Today.AddDays(-87), EndTime = DateTime.Today.AddDays(-87), Deadline = false, CourseId = 1 },
              new Activities { Id = 6, ActivityType = ActivityTypeEnum.ELearning, Name = "Conditional statements och loopar", Description = "Genomg�ng utav for loopar och andra loopar", StartTime = DateTime.Today.AddDays(-87), EndTime = DateTime.Today.AddDays(-87), Deadline = false, CourseId = 1 },
              new Activities { Id = 7, ActivityType = ActivityTypeEnum.Lecture, Name = "Tips och trick i Visual Studio", Description = "Hur Visual Studio fungerar", StartTime = DateTime.Today.AddDays(-87), EndTime = DateTime.Today.AddDays(-87), Deadline = false, CourseId = 1 },
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
   	                        {"Jonas", "Jakobsson","user2@gmail.com","Student","0733765334","1"},
	                        {"Matti", "Boustedt","matti.boustedt@hotmail.com","Student","0764563234","2"},
	                        {"Staffan", "Ericsson","staffan.ericsson@tele2.com","Student","0702345436","1"},
	                        {"Erik", "L�nroth","erik.dalonn@yahoo.com","Student","0762342342","2"},  	
                            {"Adrian", "Luzano","adrian.luxzano@lexicon.se","Teacher","070919292",""},  	
                            {"Anna", "Eklund","anna.eklund@hotmail.com","Student","070919293","4"},  	
                            {"Kenneth", "Forsstr�m","kennet.forsstrom@gmail.com","Student","070919294","2"},  	
                            {"Anna", "Ronnegard","anna.ronnegard@gmail.com","Student","070919295","1"}, 
 	                        {"Maria", "Blom","maty84@gmail.com","Student","0732856434","3"},  	
                            {"Ahmin", "Badou","amin.badou@gmail.com","Student","0724573226","1"},  	
                            {"Selma", "L��f","lovet@gmail.com","Student","0738762883","4"},  	
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
