using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GridMvc;
using GridMvc.DataAnnotations;
using GridMvc.Resources;
using GridMvc.Pagination;

namespace LexiconLMS.Models
{
    [GridTable(PagingEnabled = true, PageSize = 20)]
    public class Document
    {
        public int Id { get; set; }

        [GridColumn(Title = "Dokumentnamn", SortEnabled = true, FilterEnabled = true)]
        [Display(Name = "Dokumentnamn")]
        [DisplayFormat(NullDisplayText = " ")]
        public string Name { get; set; }

        [GridColumn(Title = "Beskrivning", SortEnabled = true, FilterEnabled = true)]
        [DisplayFormat(NullDisplayText = "")]
        public string Description { get; set; }

        [GridColumn(Title = "Dokument skapat", SortEnabled = true, FilterEnabled = true)]
        [Display(Name = "Dokument skapat")]
        [DisplayFormat(NullDisplayText = "",DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime dateCreated
        {
           get; set;
           // get { return DateTime.Now; }
        }
        [DisplayFormat(NullDisplayText = "")]
        public int? GroupId { get; set; }
        public virtual Group Group { get; set; }    //Navigation Property

        [DisplayFormat(NullDisplayText = "")]
        public int? CourseId { get; set; }
        public virtual Course Course { get; set; }    //Navigation Property

        public int? ActivitiesId { get; set; }
        public virtual Activities Activities { get; set; }    //Navigation Property

        [ForeignKey("ApplicationUser")]
        [DisplayFormat(NullDisplayText = "")]
        public string ApplicationUserId { get; set; }                      //Foreign Key
        public virtual ApplicationUser ApplicationUser { get; set; }    //Navigation Property
 
    }
}
