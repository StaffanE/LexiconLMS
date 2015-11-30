using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LexiconLMS.Models
{
    public class Group
    {
        public int Id { get; set; }

        [Display(Name = "Gruppnamn")]
        public string Name { get; set; }
        [Display(Name = "Beskrivning")]
        public string Description { get; set; }

        [Display(Name = "Start Datum")]
        public DateTime? StartDate { get; set; }

        [Display(Name = "Slut Datum")]
        public DateTime? EndDate { get; set; }
    }
}