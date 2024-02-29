using MyResume.Entities;
using MyResume.Repositories.EntityRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyResume.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        AdminRepository adminRepository = new AdminRepository();
        public ActionResult Index()
        {
            var values = adminRepository.TList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateAdmin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateAdmin(Admin admin)
        {
            adminRepository.TAdd(admin);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteAdmin(int id)
        {
            var values = adminRepository.Find(a=> a.AdminId == id);
            adminRepository.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateAdmin(int id)
        {
            var values = adminRepository.Find(a => a.AdminId == id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateAdmin(Admin updateAdmin)
        {
            var admin = adminRepository.Find(a => a.AdminId == updateAdmin.AdminId);
            admin.UserName = updateAdmin.UserName;
            admin.Password = updateAdmin.Password;
            adminRepository.TUpdate(admin);
            return RedirectToAction("Index");
        }
    }
}