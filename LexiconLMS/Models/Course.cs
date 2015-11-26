using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LexiconLMS.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // [Required(ErrorMessage = "Ägare / Medlem krävs.")]
        public int GroupId { get; set; }                         // Foreign key
        
        // [Display(Name = "Ägare / Medlem")]
        public virtual Group Group { get; set; }                // Navigation property

        // [Display(Name = "Fordonstyp")]                           //  Det verkar vara denna som styr displaNameFor i Viewen, ine den i VehicleType-modellen
        // public virtual VehicleType VehicleType { get; set; }
    }

}