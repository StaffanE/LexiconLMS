using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LexiconLMS.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Display(Name = "Kurs")]
        public string Name { get; set; }

        [Display(Name = "Kursbeskrivning")]
        public string Description { get; set; }

        [Display(Name = "Start Datum")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Slut Datum")]
        public DateTime EndDate { get; set; }

        // [Required(ErrorMessage = "Ägare / Medlem krävs.")]
        public int GroupId { get; set; }                         // Foreign key
        
        // [Display(Name = "Ägare / Medlem")]
        public virtual Group Group { get; set; }                // Navigation property

        // [Display(Name = "Fordonstyp")]                           //  Det verkar vara denna som styr displaNameFor i Viewen, ine den i VehicleType-modellen
        // public virtual VehicleType VehicleType { get; set; }
    }

}