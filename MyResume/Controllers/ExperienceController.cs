using MyResume.Entities;
using MyResume.Repositories.EntityRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyResume.Controllers
{
    public class ExperienceController : Controller
    {
        // GET: Experience
        ExperienceRepository experienceRepository = new ExperienceRepository();
        public ActionResult Index()
        {
            var values = experienceRepository.TList().OrderByDescending(i=>i.ExperienceId).ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateExperience()
        {            
            return View();
        }
        [HttpPost]
        public ActionResult CreateExperience(Experience experience)
        {
            experienceRepository.TAdd(experience);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteExperience(int id)
        {
            var values = experienceRepository.Find(e => e.ExperienceId == id);
            experienceRepository.TDelete(values);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult UpdateExperience(int id)
        {
            var updateExperience = experienceRepository.Find(e => e.ExperienceId == id);
            return View(updateExperience);
        }
        [HttpPost]
        public ActionResult UpdateExperience(Experience updateExperience)
        {
            var experience = experienceRepository.Find(e => e.ExperienceId == updateExperience.ExperienceId);
            experience.Header = updateExperience.Header;
            experience.Title = updateExperience.Title;
            experience.Description = updateExperience.Description;
            experience.StartingMonth = updateExperience.StartingMonth;
            experience.StartingYear = updateExperience.StartingYear;
            experience.EndingMonth = updateExperience.EndingMonth;
            experience.EndingYear = updateExperience.EndingYear;
            experienceRepository.TUpdate(experience);
            return RedirectToAction("Index");
        }
    }
}