﻿using System;
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
        [DisplayFormat(NullDisplayText = "")]
        public ActivityTypeEnum ActivityType { get; set; }
  
        [GridColumn(Title = "Aktivitetsnamn", SortEnabled = true, FilterEnabled = true)]
        [Display(Name = "Aktivitet")]
        [DisplayFormat(NullDisplayText = "")]
        public string Name { get; set; }

        [GridColumn(Title = "Aktivitetsbeskrivning", SortEnabled = true, FilterEnabled = true)]
        [Display(Name = "Beskrivning")]
        [DisplayFormat(NullDisplayText = "")]
        public string Description { get; set; }

        [GridColumn(Title = "Startdatum", SortEnabled = true, FilterEnabled = true)]
        [Display(Name = "Startdatum")]
        [DisplayFormat(NullDisplayText = "")]
        public DateTime StartTime { get; set; }

        [GridColumn(Title = "Slutdatum", SortEnabled = true, FilterEnabled = true)]
        [Display(Name = "Slutdatum")]
        [DisplayFormat(NullDisplayText = "")]
        public DateTime EndTime { get; set; }
        //public DateTime Deadline  { get; set; }

        [GridColumn(Title = "Inlämning", SortEnabled = true, FilterEnabled = true)]
        [Display(Name = "Inlämning")]
        [DisplayFormat(NullDisplayText = "")]
        public bool Deadline { get; set; }

        //[Display(Name = "Kurs")]
        public int CourseId { get; set; }                       // Foreign key

        // [Display(Name = "Ägare / Medlem")]
        public virtual Course Course { get; set; }                // Navigation property
        


    }
}