using Resume.Entities;
using Resumes.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Resume.Web.Controllers
{
    public class EducationsController : Controller
    {
        EducationsService EducationsService = new EducationsService();
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
        public ActionResult Create(Education education)
        {
          EducationsService.SaveEducation(education);
          return View();
        }
        [HttpGet]
        public ActionResult Edit(int ID)
        {
          var Award = EducationsService.GetEducationByID(ID);
          return View(Award);
        }
        [HttpPost]
        public ActionResult Edit(Education education)
        {
          EducationsService.UpdateEducation(education);
          return View();
        }
        [HttpGet]
        public ActionResult Delete(int ID)
        {
          var Award = EducationsService.GetEducationByID(ID);
          return View(Award);
        }
        [HttpPost]
        public ActionResult Delete(Education education)
        {
          EducationsService.DeleteEducation(education);
          return View();
        }
    }
}
