using MyResume.Entities;
using MyResume.Repositories.EntityRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyResume.Controllers
{
    public class AwardController : Controller
    {
        // GET: Award
        AwardRepository awardRepositories = new AwardRepository();
        public ActionResult Index()
        {
            var values = awardRepositories.TList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateAward()
        {           
            return View();
        }
        [HttpPost]
        public ActionResult CreateAward(Award award)
        {
            awardRepositories.TAdd(award);
            return RedirectToAction("Index");
        }
              
        public ActionResult DeleteAward(int id)
        {
            var values = awardRepositories.Find(deleteAward => deleteAward.AwardId == id);
            awardRepositories.TDelete(values);
            return View();
        }


        [HttpGet]
        public ActionResult UpdateAward(int id)
        {
            var values = awardRepositories.Find(deleteAward => deleteAward.AwardId == id);          
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateAward(Award updateAward)
        {
            var award = awardRepositories.Find(a => a.AwardId == updateAward.AwardId);           
            award.Title = updateAward.Title;
            award.Subject = updateAward.Subject;
            award.Category = updateAward.Category;
            award.Icon = updateAward.Icon;
            award.Description = updateAward.Description;
            award.IssuedFrom = updateAward.IssuedFrom;
            award.IssuedDate = updateAward.IssuedDate;
            awardRepositories.TUpdate(updateAward);
            return RedirectToAction("Index");
        }
    }
}