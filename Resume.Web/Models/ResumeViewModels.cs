using Resume.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resume.Web.Models
{
  public class ResumeViewModels
  {

    public class AwardsViewModel
    {
      public List<Certification> Certifications { get; set; }
      public List<Award> Achivements { get; set; }
    }

    public class ResumeModel
    {
      public AwardsViewModel Awards { get; set; }
    }

  }
}
