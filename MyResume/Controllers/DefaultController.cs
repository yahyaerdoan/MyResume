using MyResume.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyResume.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbResumeContext dbResumeContext = new DbResumeContext();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult About()
        {
            var values = dbResumeContext.Abouts.ToList();
            return PartialView(values);
        }

        public PartialViewResult Experience()
        {
            var values = dbResumeContext.Experiences.ToList();
            return PartialView(values);
        }

        public PartialViewResult Education()
        {
            var values = dbResumeContext.Educations.ToList();
            return PartialView(values);
        }

        public PartialViewResult Skill()
        {
            var values = dbResumeContext.Skills.ToList();
            return PartialView(values);
        }

        public PartialViewResult Interest()
        {
            var values = dbResumeContext.Interests.ToList();
            return PartialView(values);
        }

        public PartialViewResult Award()
        {
            var values = dbResumeContext.Awards.ToList();
            return PartialView(values);
        }
    }
}