using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LexiconLMS.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.AspNet.Identity.EntityFramework;

namespace LexiconLMS.Controllers
{
    public class GroupsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Groups                               //   Ursprungliga Index-versionen
        //public ActionResult Index()
        //{
        //    return View(db.Group.ToList());
        //}


        // GET: Groups
        public ActionResult Index(string sortOrder)                                         //  sortOrder sätts som en inparameter. Den används inte när man kör Index-actionresult första gången, utan bara om man väljer att sortera via någon av kolumnrubriks-länkarna. 
        {
            var userStore = new UserStore<ApplicationUser>(db);
            var userManager = new UserManager<ApplicationUser>(userStore);
            var user = userManager.FindById(User.Identity.GetUserId());
            if (User.IsInRole("Student")) {
                ViewBag.Role = user.Roles;
                ViewBag.BaseUrl = "~/Groups/Details/" + user.GroupId;
                return Redirect(ViewBag.BaseUrl);
            }

            sortOrder = String.IsNullOrEmpty(sortOrder) ? "name" : sortOrder;                      //   Om sortOrder-parametern är null eller tom, som den är första gången, så sätts den istället till "name". Är den inte tom när den kommer in så behålls den som den är. 
            ViewBag.NameSortParm = sortOrder == "name" ? "name_desc" : "name";                     //    ViewBag.NameSortParm sätts till sortOrder. Om sortOrder har värdet "name" så ändras det till name_desc istället, har den något annat värde så sätts den till "name".
            ViewBag.DateSortParm = sortOrder == "date" ? "date_desc" : "date";                             //    _ ? _ : _  är det samma som  "if ... then ... else", dvs if (sortOrder == "Date") then {ViewBag.DateSortParm = "date_desc";} else {ViewBag.DateSortParm ="Date";}
            ViewBag.EndDateSortParm = sortOrder == "end_date" ? "end_date_desc" : "end_date";              //   ViewBag.EndDateSortParm sätts till sortOrder. Om sortOrder har värdet "end_date" sätts det istället till "end_date_desc", har den något annat värde så sätts den till "end_date".
            ViewBag.sortOrder = sortOrder;

            ViewBag.GroupsCurrent = "subopen current";


            //ViewBag.NameSortParm = sortOrder;                                                                //  Det omständliga sättet att skriva det.
            //if (String.IsNullOrEmpty(sortOrder))
            //{
            //    ViewBag.NameSortParm = "name_desc";
            //}
            //else
            //{
            //    ViewBag.NameSortParm = "name";
            //}


            //ViewBag.DateSortParm = sortOrder;                                                                //  Det omständliga sättet att skriva det.
            //if (sortOrder == "date")
            //{
            //    ViewBag.DateSortParm = "date_desc";
            //}
            //else
            //{
            //    ViewBag.DateSortParm = "date";
            //}   
            
            //ViewBag.EndDateSortParm = sortOrder;                                                     //  Det omständliga sättet att skriva det. 
                //if (sortOrder == "end_date")                                                                
                //{
                //    ViewBag.EndDateSortParm = "end_date_desc";
                //}
                //  else // if (sortOrder == "EndDate")
                //{
                //    ViewBag.EndDateSortParm = "end_date"; 
                //}   
            
            var groups = from g in db.Group                                           //  Variabeln groups skapas från Group-tabellen mha LINQ...
                  select g;                                                           
            switch (sortOrder)                                                        //  En switch där man mha LINQ kollar värdet på sortOrder                     
            {
                case "name_desc":                                                     //  Om sortOrder == "name_desc" sorterar man fallande på Name, annars kollar man vidare i switchen, osv...                 
                    groups = groups.OrderByDescending(g => g.Name);
                    break;
                case "date":
                    groups = groups.OrderBy(g => g.StartDate);                    
                    break;
                case "date_desc":
                    groups = groups.OrderByDescending(g => g.StartDate);
                    break;
                case "end_date":
                    groups = groups.OrderBy(g => g.EndDate);
                    break;
                case "end_date_desc":
                    groups = groups.OrderByDescending(g => g.EndDate);
                    break;                
                default:
                    groups = groups.OrderBy(g => g.Name);
                break;
            }
            return View(groups.ToList());
        }
        





        // GET: Groups/Details/5
        public ActionResult Details(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Group group = db.Group.Find(id);
            if (group == null)
            {
                return HttpNotFound();
            }

            ViewBag.GroupsCurrent = "subopen current";

            return View(group);
        }

        // GET: Groups/Create
        public ActionResult Create()
        {
            ViewBag.GroupsCurrent = "subopen current";

            return View();
        }

        // POST: Groups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Description,StartDate,EndDate")] Group group)
        {
            ViewBag.GroupsCurrent = "subopen current";

            if (ModelState.IsValid)
            {
                db.Group.Add(group);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(group);
        }

        // GET: Groups/Edit/5
        public ActionResult Edit(int? id)
        {


            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Group group = db.Group.Find(id);
            if (group == null)
            {
                return HttpNotFound();
            }

            ViewBag.GroupsCurrent = "subopen current";

            return View(group);
        }

        // POST: Groups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Description,StartDate,EndDate")] Group group)
        {
            if (ModelState.IsValid)
            {
                db.Entry(group).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GroupsCurrent = "subopen current";
            return View(group);
        }

        // GET: Groups/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Group group = db.Group.Find(id);
            if (group == null)
            {
                return HttpNotFound();
            }

            ViewBag.GroupsCurrent = "subopen current";
            return View(group);
        }

        // POST: Groups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Group group = db.Group.Find(id);


            db.Group.Remove(group);
            db.SaveChanges();

            ViewBag.GroupsCurrent = "subopen current";
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
