using MyResume.Entities;
using MyResume.Repositories.EntityRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyResume.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        AboutRepository aboutRepository = new AboutRepository();
        public ActionResult Index()
        {            
            var value = aboutRepository.TList();
            return View(value);
        }
        [HttpGet]
        public ActionResult CreateAbout()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateAbout(About about)
        {
            aboutRepository.TAdd(about);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteAbout(int id)
        {
            About about = aboutRepository.Find(aboutId => aboutId.AboutId == id);
            aboutRepository.TDelete(about);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            About updateAbout = aboutRepository.Find(aboutId => aboutId.AboutId == id);
            return View(updateAbout);
        }

        [HttpPost]
        public ActionResult UpdateAbout(About updateAbout)
        {
            About about = aboutRepository.Find(aboutId => aboutId.AboutId == updateAbout.AboutId);
            about.FirstName = updateAbout.FirstName;
            about.LastName = updateAbout.LastName;
            about.Description = updateAbout.Description;
            about.PhoneNumber = updateAbout.PhoneNumber;
            about.Email = updateAbout.Email;
            about.Address = updateAbout.Address;
            about.City = updateAbout.City;
            about.State = updateAbout.State;
            about.Country = updateAbout.Country;
            about.ZipCode = updateAbout.ZipCode;            
            aboutRepository.TUpdate(updateAbout);
            return RedirectToAction("Index");
        }
    }
}