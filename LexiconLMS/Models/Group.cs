﻿using System;
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
    public class Group
    {
        [GridColumn(Title = "GruppId", SortEnabled = true, FilterEnabled = true)]
        [Display(Name = "Grupp ID")]
        public int Id { get; set; }

        [GridColumn(Title = "Gruppnamn", SortEnabled = true, FilterEnabled = true)]
        [Display(Name = "Gruppnamn")]
        [Required]
        public string Name { get; set; }

        [GridColumn(Title = "Beskrivning", SortEnabled = true, FilterEnabled = true)]
        [Display(Name = "Beskrivning")]
        public string Description { get; set; }

        [GridColumn(Title = "Startdatum", SortEnabled = true, FilterEnabled = true)]
        [Display(Name = "Start Datum")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? StartDate { get; set; }

        [GridColumn(Title = "Slutdatum", SortEnabled = true, FilterEnabled = true)]
        [Display(Name = "Slut Datum")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? EndDate { get; set; }

        public virtual ICollection<ApplicationUser> GroupStudents { get; set; }
        public virtual ICollection<Course>          GroupCourses { get; set; }
    }
}