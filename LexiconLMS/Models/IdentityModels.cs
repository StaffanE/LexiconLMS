using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace LexiconLMS.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Förnamn")]
        public string FirstName { get; set; }

        [Display(Name = "Efternamn")]
        public string LastName { get; set; }

        [Display(Name = "Namn")]
        public string Fullname { get; set; }

        [Display(Name = "Roll")]
        public string Title { get; set; }
        //public string UserEmail { get; set; }
        //public string Phone { get; set; }



        [Display(Name = "Grupp")]
        public int? GroupId { get; set; }                         // Foreign key

        [Display(Name = "Grupp")]
        public virtual Group Group { get; set; }                // Navigation property

        public virtual ICollection<Document> Documents { get; set; }
        
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }


        public DbSet<Models.Group> Group { get; set; }
       // public DbSet<Models.Course> Course { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

         public System.Data.Entity.DbSet<LexiconLMS.Models.Course> Courses { get; set; }

         public System.Data.Entity.DbSet<LexiconLMS.Models.Activities> Activities { get; set; }

         public System.Data.Entity.DbSet<LexiconLMS.Models.Document> Documents { get; set; }

       //  public System.Data.Entity.DbSet<LexiconLMS.Models.ApplicationUser> ApplicationUsers { get; set; }
    }
}