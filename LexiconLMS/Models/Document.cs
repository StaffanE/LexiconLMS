using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace LexiconLMS.Models
{
    public class Document
    {
        public int Id { get; set; }

        [Display(Name = "Dokumentnamn")]
        public string Name { get; set; }

        public string Description { get; set; }

        [Display(Name = "Dokument skapat")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime dateCreated
        {
           get; set;
           // get { return DateTime.Now; }
        }

        public int? GroupId { get; set; }
        public virtual Group Group { get; set; }    //Navigation Property

        public int? CourseId { get; set; }
        public virtual Course Course { get; set; }    //Navigation Property

        public int? ActivitiesId { get; set; }
        public virtual Activities Activities { get; set; }    //Navigation Property

        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }                      //Foreign Key
        //public virtual ApplicationUser ApplicationUser { get; set; }    //Navigation Property
        public virtual ApplicationUser ApplicationUser { get; set; }    //Navigation Property


        //public int UserId { get; set; }                      //Foreign Key
        //public virtual ApplicationUser ApplicationUser { get; set; }    //Navigation Property

      

    }
}
