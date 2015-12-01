using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LexiconLMS.Models;

namespace LexiconLMS.Controllers
{
    public class GroupsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Groups
        //public ActionResult Index()
        //{
        //    return View(db.Group.ToList());
        //}



        // GET: Groups
        public ActionResult Index(string sortOrder)                                         //  sortOrder sätt som en inparameter. Den används inte när man kör Index-actionresult första gången, utan bara om man väljer att sortera via någon av kolumnrubriks-länkarna.
        {
            
            
            
            
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";                      //   Om sortOrder-parametern är null eller tom, sätts ViewBag.NameSortParm till "name_desc"; annars sätts den till en tom sträng.
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";                             //    _ ? _ : _  är det samma som  "if ... then ... else", dvs if (sortOrder == "Date") then {ViewBag.DateSortParm = "date_desc";} else {ViewBag.DateSortParm ="Date";}
            ViewBag.EndDateSortParm = sortOrder == "end_date" ? "end_date_desc" : "end_date";
                        
              //if (sortOrder == "Date")                                                                //  Det omständliga sättet att skriva det, som dessutom inte riktigt funkar just nu. 
              //{
              //    ViewBag.DateSortParm = "date_desc";
              //}
              //else
              //{
              //    ViewBag.DateSortParm = "Date";
              //}

              //if (sortOrder == "Date")                                                                //  Det omständliga sättet att skriva det, som dessutom inte riktigt funkar just nu. 
              //{
              //    ViewBag.DateSortParm = "date_desc";
              //}
              //else
              //{
              //    ViewBag.DateSortParm = "Date";
              //}


            
            var groups = from g in db.Group
                  select g;
            switch (sortOrder)
            {
                case "name_desc":
                    groups = groups.OrderByDescending(g => g.Name);
                    break;
                case "Date":
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
            return View(group);
        }

        // GET: Groups/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Groups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Description,StartDate,EndDate")] Group group)
        {
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
