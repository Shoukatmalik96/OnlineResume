using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Entities
{
  public class Experience:BaseEntitiy
  {
    public string Post { get; set; }

    public string Organization { get; set; }

    public string Description { get; set; }

    public DateTime fromDate { get; set; }

    public DateTime toDate { get; set; }

  }
}
