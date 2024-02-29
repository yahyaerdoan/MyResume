using MyResume.Entities;
using MyResume.Repositories.EntityRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyResume.Controllers
{
    public class SocialMediaController : Controller
    {
        // GET: SocialMedia
        SocialMediaRepository socialMediaRepository = new SocialMediaRepository();

        public PartialViewResult ScriptPartial()
        {
            return PartialView();
        }
        public ActionResult Index()
        {
            var values = socialMediaRepository.TList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSocialMedia(SocialMedia socialMedia)
        {
            socialMedia.AboutId = 17;
            socialMediaRepository.TAdd(socialMedia);           
            return RedirectToAction("Index");
        }

        
        public ActionResult DeleteSocialMedia(int id)
        {
            var socialMedia = socialMediaRepository.Find(s => s.SocialMediaId == id);
            socialMedia.Statu = false;
            socialMediaRepository.TUpdate(socialMedia);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateSocialMedia(int id)
        {
            var values = socialMediaRepository.Find(s => s.SocialMediaId == id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateSocialMedia(SocialMedia updateSocialMedia)
        {
            var socialMedia = socialMediaRepository.Find(s => s.SocialMediaId == updateSocialMedia.SocialMediaId);
            socialMedia.AboutId = updateSocialMedia.AboutId= 17;
            socialMedia.Statu = updateSocialMedia.Statu= true;
            socialMedia.Name = updateSocialMedia.Name;
            socialMedia.Icon = updateSocialMedia.Icon;
            socialMedia.Url = updateSocialMedia.Url;
            socialMedia.Statu = updateSocialMedia.Statu;
            socialMediaRepository.TUpdate(socialMedia);
            return RedirectToAction("Index");
        }
    }
}