using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using GridMvc;
using GridMvc.DataAnnotations;
using GridMvc.Resources;
using GridMvc.Pagination;


namespace LexiconLMS.Models
{
    [GridTable(PagingEnabled = true, PageSize = 20)]
    public class Course
    {
        public int Id { get; set; }
        [GridColumn(Title = "Kurs", SortEnabled = true, FilterEnabled = true)]
        [Display(Name = "Kurs")]
        [Required]
        public string Name { get; set; }

        [GridColumn(Title = "Kursbeskrivning", SortEnabled = true, FilterEnabled = true)]
        [Display(Name = "Kursbeskrivning")]
        [DisplayFormat(NullDisplayText = "..saknas...")]
        public string Description { get; set; }

        [GridColumn(Title = "Startdatum", SortEnabled = true, FilterEnabled = true)]
        [Display(Name = "Startdatum")]
        [DataType(DataType.Date)]
        [DisplayFormat(NullDisplayText = "",DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [GridColumn(Title = "Slutdatum", SortEnabled = true, FilterEnabled = true)]
        [Display(Name = "Slutdatum")]
        [DisplayFormat(NullDisplayText = "", DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [GridColumn(Title = "Grupp", SortEnabled = true, FilterEnabled = true)]
        [Display(Name = "Grupp")]
        [DisplayFormat(NullDisplayText = "")]
        public int GroupId { get; set; }                         // Foreign key
        
        [GridColumn(Title = "Grupp", SortEnabled = true, FilterEnabled = true)]
        [Display(Name = "Grupp")]
        public virtual Group Group { get; set; }                // Navigation property

        public virtual ICollection<Activities> CourseActivities { get; set; }
       
    }

}