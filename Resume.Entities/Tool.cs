using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Entities
{
  public class Tool:BaseEntitiy
  {
    public string toolName { get; set; }

    public string ImageURL
    {
      get; set;
    }
   }
}
