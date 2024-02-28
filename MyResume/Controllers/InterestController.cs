using MyResume.Entities;
using MyResume.Repositories.EntityRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyResume.Controllers
{
    public class InterestController : Controller
    {
        // GET: Interest
        InterestRepository interestRepository = new InterestRepository();
        [HttpGet]
        public ActionResult Index()
        {
            var values = interestRepository.TList();            
            return View(values);
        }
        [HttpPost]
        public ActionResult Index(Interest updateInterest)
        {
            var interest = interestRepository.Find(i => i.InterestId == updateInterest.InterestId);            
            interest.Title = updateInterest.Title;
            interest.Description = updateInterest.Description;
            interestRepository.TUpdate(interest);
            return RedirectToAction("Index");
        }
    }
}