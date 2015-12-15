using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Web.Mvc;
using GridMvc;
using GridMvc.DataAnnotations;
using GridMvc.Resources;
using GridMvc.Pagination;


namespace LexiconLMS.Models
{
    [GridTable(PagingEnabled = true, PageSize = 20)]
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        [GridColumn(Title = "Förnamn", SortEnabled = true, FilterEnabled = true)]
        [Display(Name = "Förnamn")]
        [DisplayFormat(NullDisplayText = "")]
        public string FirstName { get; set; }

        [GridColumn(Title = "Efternamn", SortEnabled = true, FilterEnabled = true)]
        [Display(Name = "Efternamn")]
        [DisplayFormat(NullDisplayText = "")]
        public string LastName { get; set; }

        //[Display(Name = "Namn")]
        //public string Fullname { get; set; }

        [GridColumn(Title = "Namn", SortEnabled = true, FilterEnabled = true)]
        [Display(Name = "Namn")]
        [DisplayFormat(NullDisplayText = "")]
        public string FullName 
        { 
            get
            {
                var fullName = FirstName + " " + LastName;
                fullName.Trim();
                return fullName;
            }
            set {  }
        }

        [GridColumn(Title = "Roll", SortEnabled = true, FilterEnabled = true)]
        [Display(Name = "Roll")]
        //[Required]
        [DisplayFormat(NullDisplayText = "")]
        public string Title { get; set; }
        
        //public string UserEmail { get; set; }
        //public string Phone { get; set; }


        [GridColumn(Title = "Grupp", SortEnabled = true, FilterEnabled = true)]
        [Display(Name = "Grupp")]
        [DisplayFormat(NullDisplayText = "")]
        public int? GroupId { get; set; }                         // Foreign key

        [GridColumn(Title = "Grupp", SortEnabled = true, FilterEnabled = true)]
        [Display(Name = "Grupp")]
        [DisplayFormat(NullDisplayText = "")]
        public virtual Group Group { get; set; }                // Navigation property

        public virtual ICollection<Document> Documents { get; set; }

        //public IEnumerable<SelectListItem> RolesList { get; set; }
        //public string RolesListId { get; set; }


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