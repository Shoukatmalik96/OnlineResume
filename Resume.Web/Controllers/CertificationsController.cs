using Resume.Entities;
using Resumes.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Resume.Web.Controllers
{
    public class CertificationsController : Controller
    {
        CertificationsService CertificationsService = new CertificationsService();
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
        public ActionResult Create(Certification certification)
        {
           CertificationsService.SaveCertification(certification);
           return View();
        }
        [HttpGet]
        public ActionResult Edit(int ID)
        {
          var certification = CertificationsService.GetCertificateByID(ID);
          return View(certification);
        }
        [HttpPost]
        public ActionResult Edit(Certification certification)
        {
          CertificationsService.UpdateCertification(certification);
          return View();
        }
        [HttpGet]
        public ActionResult Delete(int ID)
        {
          var certification = CertificationsService.GetCertificateByID(ID);
          return View(certification);
        }
        [HttpPost]
        public ActionResult Delete(Certification certification)
        {
          CertificationsService.DeleteCertification(certification);
          return View();
        }
  }
}
