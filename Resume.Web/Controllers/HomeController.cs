using Resumes.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static Resume.Web.Models.ResumeViewModels;

namespace Resume.Web.Controllers
{
  public class HomeController : Controller
  {
    AwardsService AwardsService = new AwardsService();
    CertificationsService CertificationsService = new CertificationsService();


    public ActionResult Index()
    {
    //  ResumeModel model = new ResumeModel();
      AwardsViewModel model = new AwardsViewModel();
      model.Achivements = AwardsService.GetAwards();
      model.Certifications = CertificationsService.GetCertifications();
      return View(model);
    }

    public ActionResult About()
    {
      ViewBag.Message = "Your application description page.";

      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Your contact page.";

      return View();
    }
  }
}
