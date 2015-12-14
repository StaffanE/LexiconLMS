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
        public string Description { get; set; }

        [GridColumn(Title = "Startdatum", SortEnabled = true, FilterEnabled = true)]
        [Display(Name = "Start Datum")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [GridColumn(Title = "Slutdatum", SortEnabled = true, FilterEnabled = true)]
        [Display(Name = "Slut Datum")]
        [DataType(DataType.Date)]
        // [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }
        [GridColumn(Title = "Grupp", SortEnabled = true, FilterEnabled = true)]
        [Display(Name = "Grupp")]
        public int GroupId { get; set; }                         // Foreign key
        
        // [Display(Name = "Ägare / Medlem")]
        [GridColumn(Title = "Grupp", SortEnabled = true, FilterEnabled = true)]
        [Display(Name = "Grupp")]
        public virtual Group Group { get; set; }                // Navigation property

        public virtual ICollection<Activities> CourseActivities { get; set; }
        // [Display(Name = "Fordonstyp")]                           //  Det verkar vara denna som styr displaNameFor i Viewen, ine den i VehicleType-modellen
        // public virtual VehicleType VehicleType { get; set; }
    }

}