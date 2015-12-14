using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using GridMvc;
using GridMvc.DataAnnotations;
//using GridMvc.Pagination;

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
    [GridTable(PagingEnabled = true, PageSize = 20)]
     public class Activities
    {
        public int Id { get; set; }
        [GridColumn(Title = "Aktivitetstyp", SortEnabled = true, FilterEnabled = true)]
        [Display(Name = "Typ")]
        public ActivityTypeEnum ActivityType { get; set; }
  
        [GridColumn(Title = "Aktivitetsnamn", SortEnabled = true, FilterEnabled = true)]
        [Display(Name = "Aktivitet")]
        public string Name { get; set; }

        [GridColumn(Title = "Aktivitetsbeskrivning", SortEnabled = true, FilterEnabled = true)]
        [Display(Name = "Beskrivning")]
        public string Description { get; set; }

        [GridColumn(Title = "Startdatum/tid", SortEnabled = true, FilterEnabled = true)]
        [Display(Name = "Start datum/tid")]
        public DateTime StartTime { get; set; }

        [GridColumn(Title = "Slutdatum/tid", SortEnabled = true, FilterEnabled = true)]
        [Display(Name = "Slut datum/tid")]
        public DateTime EndTime { get; set; }
        //public DateTime Deadline  { get; set; }

        [GridColumn(Title = "Inlämningsuppgift", SortEnabled = true, FilterEnabled = true)]
        [Display(Name = "Inlämningsuppgift")]
        public bool Deadline { get; set; }

        //[Display(Name = "Kurs")]
        public int CourseId { get; set; }                       // Foreign key

        // [Display(Name = "Ägare / Medlem")]
        public virtual Course Course { get; set; }                // Navigation property
        


    }
}