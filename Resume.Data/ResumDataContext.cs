using Resume.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Data
{
  public class ResumDataContext:DbContext
  {
    public ResumDataContext():base("name=ResumeConnectionString")
    {

    }
    public DbSet<About> Abouts { get; set; }

    public DbSet<Education> Educations { get; set; }

    public DbSet<Experience> Experiences { get; set; }

    public DbSet<Skill> Skills { get; set; }

    public DbSet<Interest> Interests { get; set; }

    public DbSet<Certification> Certification { get; set; }

    public DbSet<Award> Awards { get; set; }

    public DbSet<Language> Languages { get; set; }

    public DbSet<workFlow> WorkFlows { get; set; }

    public DbSet<Tool> Tools { get; set; }

  }
}
