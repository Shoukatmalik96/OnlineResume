using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Entities
{
  public class About: BaseEntitiy
  {

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string Address { get; set; }

    public string Description { get; set; }

    public string GitURL { get; set; }

    public string FaceBookURL { get; set; }

    public string LinkedentURL { get; set; }

    public string TwitterURL { get; set; }
  }
}

