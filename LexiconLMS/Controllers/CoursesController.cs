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
using Microsoft.AspNet.Identity.EntityFramework;

namespace LexiconLMS.Controllers
{
    public class CoursesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Courses
        public ActionResult Index(string sortOrder)
        {
           // var courses = db.Courses.Include(c => c.Group);   // Original-rad
           // return View(courses.ToList());                    // Original-rad
            
            var courses = db.Courses.Include(c=> c.Group);                                            

            sortOrder = String.IsNullOrEmpty(sortOrder) ? "date" : sortOrder;                      
            ViewBag.StartDateSortParm = sortOrder == "date" ? "date_desc" : "date";
            ViewBag.EndDateSortParm = sortOrder == "end_date" ? "end_date_desc" : "end_date";         
            ViewBag.GroupSortParm = sortOrder == "group" ? "group_desc" : "group";                 
            ViewBag.CourseSortParm = sortOrder == "course" ? "course_desc" : "course";                     
            ViewBag.sortOrder = sortOrder;                                                         

            string currentUserId = User.Identity.GetUserId();                                      //   Hämtar inloggade användarens Id
            var currentUser = db.Users.Where(u => u.Id == currentUserId).FirstOrDefault();         //   CurrentUser sätts till den användaren från dbUsers som har samma ID som  inloggade användaren. FirstOrDeafault används istället för First som inte riktigt funkar. Returnerar första hittade värdet.
            var users = db.Users.Where(u => u.GroupId == (int)currentUser.GroupId);                //   users tilldelas användarna med samma grupp.id som currentUser
            
            if (Request.IsAuthenticated)
            {
                if (User.IsInRole("Student"))
                {
                   courses = db.Courses.Where(c => c.GroupId == (int)currentUser.GroupId);         //   courses tilldelas kurserna med samma grupp-id som current user
                   ViewBag.groupName = currentUser.Group.Name;
                   // ViewBag.groupDescription = currentUser.Group.Description;
                   // ViewBag.groupStartDate = currentUser.Group.StartDate;
                   // ViewBag.groupEndDate = currentUser.Group.EndDate;
                }
            }
                                    
            switch (sortOrder)                                                                             
            {
                case "date_desc":                                                                  //  Om sortOrder == "name_desc" sorterar man fallande på Fullname, annars kollar man vidare i switchen, osv...                 
                    courses = courses.OrderByDescending(c => c.StartDate);
                    break;
                case "group":
                    courses = courses.OrderBy(c => c.Group.Name);                    
                    break;
                case "group_desc":
                    courses = courses.OrderByDescending(c => c.Group.Name);
                    break;
                case "course":
                    courses = courses.OrderBy(c => c.Name);
                    break;
                case "course_desc":
                    courses = courses.OrderByDescending(c => c.Name);
                    break;
                case "end_date_desc":
                    courses = courses.OrderByDescending(c => c.EndDate);
                    break;
                case "end_date":
                    courses = courses.OrderBy(c => c.EndDate);
                    break;         
                default:
                    courses = courses.OrderBy(c => c.StartDate);
                break;
            }
            return View(courses.ToList());
        }




        // GET: Courses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = db.Courses.Find(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        // GET: Courses/Create
        [Authorize(Roles = "Teacher")]
        public ActionResult Create()
        {
            ViewBag.GroupId = new SelectList(db.Group, "Id", "Name");
            return View();
        }

        // POST: Courses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Teacher")]
        public ActionResult Create([Bind(Include = "Id,Name,Description,StartDate,EndDate,GroupId")] Course course)
        {
            if (ModelState.IsValid)
            {
                db.Courses.Add(course);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GroupId = new SelectList(db.Group, "Id", "Name", course.GroupId);
            return View(course);
        }

        // GET: Courses/Edit/5
        [Authorize(Roles = "Teacher")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = db.Courses.Find(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            ViewBag.GroupId = new SelectList(db.Group, "Id", "Name", course.GroupId);
            return View(course);
        }

        // POST: Courses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Teacher")]
        public ActionResult Edit([Bind(Include = "Id,Name,Description,StartDate,EndDate,GroupId")] Course course)
        {
            if (ModelState.IsValid)
            {
                db.Entry(course).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GroupId = new SelectList(db.Group, "Id", "Name", course.GroupId);
            return View(course);
        }

        // GET: Courses/Delete/5
        [Authorize(Roles = "Teacher")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = db.Courses.Find(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        // POST: Courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Teacher")]
        public ActionResult DeleteConfirmed(int id)
        {
            Course course = db.Courses.Find(id);
            db.Courses.Remove(course);
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
