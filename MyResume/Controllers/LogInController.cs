using MyResume.Entities;
using MyResume.Repositories.EntityRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MyResume.Controllers
{
    [AllowAnonymous]
    public class LogInController : Controller
    {
        // GET: LogIn
        
        AdminRepository adminRepository = new AdminRepository();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            var values = adminRepository.Find(a => a.AdminId == a.AdminId && a.Password == admin.Password);
            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.UserName, false);
                Session["UserName"] = values.UserName.ToString();
                return RedirectToAction("Index", "About");
            }
            else
            {
                return RedirectToAction("Index", "LogIn");
            }            
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "LogIn");
        }
    }
}