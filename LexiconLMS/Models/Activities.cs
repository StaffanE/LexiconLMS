using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LexiconLMS.Models
{
    public class Activities
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime Deadline  { get; set; }

        public int CourseId { get; set; }                       // Foreign key

        // [Display(Name = "Ägare / Medlem")]
        public virtual Course Course { get; set; }                // Navigation property
        


    }
}