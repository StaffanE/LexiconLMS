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
    public class UsersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Users                                  //  Original-index
        //public ActionResult Index()
        //{
        //    var Users = db.Users.Include(a => a.Group);
        //    return View(Users.ToList());
        //}


        // GET: Users
        public ActionResult Index(string sortOrder)
        {
            var Users = db.Users.Include(a => a.Group);
            // return View(Users.ToList());

            sortOrder = String.IsNullOrEmpty(sortOrder) ? "name" : sortOrder;                      //   Om sortOrder-parametern är null eller tom, som den är första gången, så sätts den istället till "name". Är den inte tom när den kommer in så behålls den som den är. 
            ViewBag.NameSortParm = sortOrder == "name" ? "name_desc" : "name";                     //   ViewBag.NameSortParm sätts till sortOrder. Om sortOrder har värdet "name" så ändras det till name_desc istället, har den något annat värde så sätts den till "name".
            ViewBag.GroupSortParm = sortOrder == "group" ? "group_desc" : "group";                 //   _ ? _ : _  är det samma som  "if ... then ... else", dvs if (sortOrder == "group") then {ViewBag.GroupSortParm = "group_desc";} else {ViewBag.GroupSortParm ="group";}
            ViewBag.MailSortParm = sortOrder == "mail" ? "mail_desc" : "mail";                     //   ViewBag.MaildSortParm sätts till sortOrder. Om sortOrder har värdet "mail" sätts det istället till "mail_desc", har den något annat värde så sätts den till "mail".
            ViewBag.sortOrder = sortOrder;                                                         //   Viewbag.sortOrder sätts till sortOrder för att kunna kolla i Viewen vilket värde på sortOrder som gäller.
                        
            var users = from u in db.Users                                                         //   Variabeln users skapas från Users-tabellen mha LINQ...
                  where u.GroupId == 1
                //  u.GroupId == User.Identity.
                  //select u;     
                  join g in db.Group on u.GroupId equals g.Id
                  select u;                     
            switch (sortOrder)                                                                             
            {
                case "name_desc":                                                                  //  Om sortOrder == "name_desc" sorterar man fallande på Fullname, annars kollar man vidare i switchen, osv...                 
                    users = users.OrderByDescending(u => u.LastName);
                    break;
                case "group":
                    users = users.OrderBy(u => u.Group.Name);                    
                    break;
                case "group_desc":
                    users = users.OrderByDescending(u => u.Group.Name);
                    break;
                case "mail":
                    users = users.OrderBy(u => u.Email);
                    break;
                case "mail_desc":
                    users = users.OrderByDescending(u => u.Email);
                    break;                
                default:
                    users = users.OrderBy(u => u.LastName);
                break;
            }
            return View(users.ToList());
        }

        


        // GET: Users/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicationUser applicationUser = db.Users.Find(id);
            if (applicationUser == null)
            {
                return HttpNotFound();
            }
            return View(applicationUser);
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            ViewBag.GroupId = new SelectList(db.Group, "Id", "Name");
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,Fullname,Title,GroupId,Email,EmailConfirmed,PasswordHash,SecurityStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEndDateUtc,LockoutEnabled,AccessFailedCount,UserName")] ApplicationUser applicationUser)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(applicationUser);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GroupId = new SelectList(db.Group, "Id", "Name", applicationUser.GroupId);
            return View(applicationUser);
        }

        // GET: Users/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicationUser applicationUser = db.Users.Find(id);
            if (applicationUser == null)
            {
                return HttpNotFound();
            }
            ViewBag.GroupId = new SelectList(db.Group, "Id", "Name", applicationUser.GroupId);
            return View(applicationUser);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,Fullname,Title,GroupId,Email,EmailConfirmed,PasswordHash,SecurityStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEndDateUtc,LockoutEnabled,AccessFailedCount,UserName")] ApplicationUser applicationUser)
        {
            if (ModelState.IsValid)
            {
                db.Entry(applicationUser).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GroupId = new SelectList(db.Group, "Id", "Name", applicationUser.GroupId);
            return View(applicationUser);
        }

        // GET: Users/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicationUser applicationUser = db.Users.Find(id);
            if (applicationUser == null)
            {
                return HttpNotFound();
            }
            return View(applicationUser);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ApplicationUser applicationUser = db.Users.Find(id);
            db.Users.Remove(applicationUser);
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
