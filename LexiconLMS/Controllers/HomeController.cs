using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using LexiconLMS.Models;

namespace LexiconLMS.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
 
        public ActionResult Index()
        {
            var userStore = new UserStore<ApplicationUser>(db);             
            var userManager = new UserManager<ApplicationUser>(userStore);
            ViewBag.BaseUrl = "~/Account/Login";
            var user = userManager.FindById(User.Identity.GetUserId());
            if (User.IsInRole("Teacher")) {
                ViewBag.BaseUrl = "~/Groups/Index";
            }
            if (User.IsInRole("Student")) {
                ViewBag.Role = user.Roles;
                ViewBag.BaseUrl = "~/Groups/Details/" + user.GroupId;
           
            }
            return Redirect(ViewBag.BaseUrl);
            //ViewBag.HomeCurrent = "subopen current";
            //return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "LexiconLMS - Utbildningshantering.";
            ViewBag.HomeCurrent = "subopen current";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Kontaktuppgifter.";
            ViewBag.ContactCurrent = "subopen current";

            return View();
        }
    }
}