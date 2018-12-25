
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Entities
{
  public class Education:BaseEntitiy
  {
    public string Institute { get; set; }

    public string Program { get; set; }

    public string ProgramDescription { get; set; }

    public float GPA { get; set; }

    public string Grade { get; set; }

    public DateTime fromDate { get; set; }

    public DateTime toDate { get; set; }

  }
}
