using Resume.Data;
using Resume.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resumes.Services
{
  public class EducationsService
  {
    ResumDataContext context = new ResumDataContext();

    public List<Education> GetEducations()
    {
      return context.Educations.ToList();
    }
    public Education GetEducationByID(int ID)
    {
      return context.Educations.Find(ID);
    }
    public void SaveEducation(Education education)
    {
      context.Educations.Add(education);
      context.SaveChanges();
    }
    public void UpdateEducation(Education education)
    {
      context.Entry(education).State = System.Data.Entity.EntityState.Modified;
      context.SaveChanges();
    }
    public void DeleteEducation(Education education)
    {
      context.Entry(education).State = System.Data.Entity.EntityState.Deleted;
      context.SaveChanges();
    }
  }
}
