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
    public class ActivitiesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Activities
        public ActionResult Index()
        {
            var activities = db.Activities.Include(a => a.Course);
            ViewBag.ActivitiesCurrent = "subopen current";

            return View(activities.ToList());
        }

        // GET: Activities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Activities activities = db.Activities.Find(id);
            if (activities == null)
            {
                return HttpNotFound();
            }
            ViewBag.ActivitiesCurrent = "subopen current";
            return View(activities);
        }

        // GET: Activities/Create
        public ActionResult Create(int? id)
        {
            ViewBag.bla = id;
            ViewBag.ActivitiesCurrent = "subopen current";
            ViewBag.CourseId = new SelectList(db.Courses, "Id", "Name");
           // ViewBag.CourseName = db.Courses.Where(c => c.Id == id).Select;


            //ViewBag.CourseName = from db.Courses
            //                     where db.Courses.Id==id
            //                     select db.Courses.Name;

            ViewBag.CourseName = db.Courses.Where(c => c.Id == id).FirstOrDefault().Name;

            return View();


        }

        // POST: Activities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ActivityType,Name,Description,StartTime,EndTime,Deadline,CourseId")] Activities activities)
        {
            var courseID = activities.CourseId;
            if (ModelState.IsValid)
            {
                db.Activities.Add(activities);
                db.SaveChanges();
                //return RedirectToAction("Details", "Courses", courseID);
                return Redirect("~/Courses/Details/" + activities.CourseId);

                //return RedirectToAction("Index");
            }

            ViewBag.ActivitiesCurrent = "subopen current";
            ViewBag.CourseId = new SelectList(db.Courses, "Id", "Name", activities.CourseId);
            return View(activities);
        }

        // GET: Activities/Edit/5
        [Authorize(Roles = "Teacher")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Activities activities = db.Activities.Find(id);
            if (activities == null)
            {
                return HttpNotFound();
            }

            ViewBag.ActivitiesCurrent = "subopen current";
            ViewBag.bla = id;
            ViewBag.CourseId = new SelectList(db.Courses, "Id", "Name", activities.CourseId);
            return View(activities);
        }

        // POST: Activities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize(Roles = "Teacher")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ActivityType,Name,Description,StartTime,EndTime,Deadline,CourseId")] Activities activities)
        {
            if (ModelState.IsValid)
            {
                db.Entry(activities).State = EntityState.Modified;
                db.SaveChanges();
                // return RedirectToAction("Index");
                return Redirect("~/Courses/Details/" + activities.CourseId);

            }

            ViewBag.ActivitiesCurrent = "subopen current";
            ViewBag.CourseId = new SelectList(db.Courses, "Id", "Name", activities.CourseId);
            // return View(activities);
            return Redirect("~/Courses/Details/" + activities.CourseId);

        }

        // GET: Activities/Delete/5
        [Authorize(Roles = "Teacher")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Activities activities = db.Activities.Find(id);
            if (activities == null)
            {
                return HttpNotFound();
            }

            ViewBag.ActivitiesCurrent = "subopen current";
            return View(activities);
        }

        // POST: Activities/Delete/5
        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "Teacher")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Activities activities = db.Activities.Find(id);
            db.Activities.Remove(activities);
            db.SaveChanges();

            ViewBag.ActivitiesCurrent = "subopen current";
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

        public string CourseId { get; set; }
    }
}
