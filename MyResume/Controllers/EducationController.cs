using MyResume.Entities;
using MyResume.Repositories.EntityRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyResume.Controllers
{
    public class EducationController : Controller
    {
        // GET: Education
        EducationRepository educationRepository = new EducationRepository();
        public ActionResult Index()
        {
            var values = educationRepository.TList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateEducation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateEducation(Education education)
        {
            educationRepository.TAdd(education);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteEducation(int id)
        {
            var delete = educationRepository.Find(i=> i.EducationId == id);
            educationRepository.TDelete(delete);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateEducation(int id)
        {
            var updateEducation = educationRepository.Find(e => e.EducationId == id);
            return View(updateEducation);
        }
        [HttpPost]
        public ActionResult UpdateEducation(Education updateEducation)
        {
            var education = educationRepository.Find(e => e.EducationId == updateEducation.EducationId);
            education.SchoolName = updateEducation.SchoolName;
            education.Degree = updateEducation.Degree;
            education.Description = updateEducation.Description;
            education.FieldOfStudy = updateEducation.FieldOfStudy;
            education.Grade = updateEducation.Grade;
            education.GradePointAverage = updateEducation.GradePointAverage;
            education.StartingMonth = updateEducation.StartingMonth;
            education.StartingYear = updateEducation.StartingYear;
            education.EndingMonth = updateEducation.EndingMonth;
            education.EndingYear = updateEducation.EndingYear;
            educationRepository.TUpdate(updateEducation);
            return RedirectToAction("Index");
        }
    }
}