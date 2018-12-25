using Resume.Entities;
using Resumes.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Resume.Web.Controllers
{
    public class AwardsController : Controller
    {
        AwardsService AwardsService = new AwardsService();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
          return View();
        }
        [HttpPost]
        public ActionResult Create(Award award)
        {
          AwardsService.SaveAward(award);
          return View();
        }
        [HttpGet]
        public ActionResult Edit(int ID)
        {
          var Award = AwardsService.GetAwardByID(ID);
          return View(Award);
        }
        [HttpPost]
        public ActionResult Edit(Award award)
        {
          AwardsService.UpdateAward(award);
          return View();
        }
        [HttpGet]
        public ActionResult Delete(int ID)
        {
          var Award = AwardsService.GetAwardByID(ID);
          return View(Award);
        }
        [HttpPost]
        public ActionResult Delete(Award award)
        {
          AwardsService.DeleteAward(award);
          return View();
        }
    }
} 
