using Resume.Data;
using Resume.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resumes.Services
{
  public class CertificationsService
  {
    ResumDataContext context = new ResumDataContext();

    public List<Certification> GetCertifications()
    {
      return context.Certification.ToList();
    }
    public Certification GetCertificateByID(int ID)
    {
      return context.Certification.Find(ID);
    }
    public void SaveCertification(Certification certifications)
    {
      context.Certification.Add(certifications);
      context.SaveChanges();
    }
    public void UpdateCertification(Certification certifications)
    {
      context.Entry(certifications).State = System.Data.Entity.EntityState.Modified;
      context.SaveChanges();
    }
    public void DeleteCertification (Certification certifications)
    {
      context.Entry(certifications).State = System.Data.Entity.EntityState.Deleted;
      context.SaveChanges();
    }
  }
}
