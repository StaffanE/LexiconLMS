using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LexiconLMS.Models
{

    public enum ActivityTypeEnum {

        [Display(Name = "E-Learning")]
        ELearning,

        [Display(Name = "Föreläsning")]
        Lecture,

        [Display(Name = "Övningstillfälle")]
        Excercise,

        [Display(Name = "Övrigt")]
        Other 

    }

    public class Activities
    {
        public int Id { get; set; }
        
        [Display(Name = "Aktivitetstyp")]
        public ActivityTypeEnum ActivityType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        //public DateTime Deadline  { get; set; }
        public bool Deadline { get; set; }

        public int CourseId { get; set; }                       // Foreign key

        // [Display(Name = "Ägare / Medlem")]
        public virtual Course Course { get; set; }                // Navigation property
        


    }
}