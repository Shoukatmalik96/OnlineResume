using Resume.Data;
using Resume.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resumes.Services
{
  public class AwardsService
  {
    ResumDataContext context = new ResumDataContext();

    public List<Award> GetAwards()
    {
      return context.Awards.ToList();
    }
    public Award GetAwardByID(int ID)
    {
      return context.Awards.Find(ID);
    }
    public void SaveAward(Award award)
    {
      context.Awards.Add(award);
      context.SaveChanges();
    }
    public void UpdateAward(Award award)
    {
      context.Entry(award).State = System.Data.Entity.EntityState.Modified;
      context.SaveChanges();
    }
    public void DeleteAward(Award award)
    {
      context.Entry(award).State = System.Data.Entity.EntityState.Deleted;
      context.SaveChanges();
    }
  }
}
