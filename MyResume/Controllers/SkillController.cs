using MyResume.Entities;
using MyResume.Repositories.EntityRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyResume.Controllers
{
    public class SkillController : Controller
    {
        // GET: Skill
        SkillRepository skillRepository = new SkillRepository();
        public ActionResult Index()
        {
            var values = skillRepository.TList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateSkill()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateSkill(Skill skill)
        {
            skillRepository.TAdd(skill);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteSkill(int id)
        {
            Skill skill = skillRepository.Find(skillId => skillId.SkillId == id);
            skillRepository.TDelete(skill);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateSkill(int id)
        {
            Skill UpdateSkill = skillRepository.Find(skillId => skillId.SkillId == id);
            return View(UpdateSkill);
        }

        [HttpPost]
        public ActionResult UpdateSkill(Skill updateSkill)
        {
            Skill skill = skillRepository.Find(updateSkillId => updateSkillId.SkillId == updateSkill.SkillId);
            skill.Title = updateSkill.Title;
            skill.Description = updateSkill.Description;
            skill.Icon = updateSkill.Icon;
            skill.Rate = updateSkill.Rate;
            skillRepository.TUpdate(updateSkill);
            return RedirectToAction("Index");
        }
    }
}