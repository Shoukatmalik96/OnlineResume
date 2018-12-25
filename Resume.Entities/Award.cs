using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Entities
{
  public class Award:BaseEntitiy
  {
    public string Position { get; set; }

    public string Institute { get; set; }

    public string Competition { get; set; }

  }
}
