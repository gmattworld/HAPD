using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hahn.ApplicatonProcess.December2020.Data;

namespace Hahn.ApplicatonProcess.December2020.Domain
{
    public class ApplicantRepository : IApplicantRepository
    {
        protected readonly HAPDDbContext _context;

        public ApplicantRepository(HAPDDbContext context)
        {
            _context = context;
        }


        public Applicant CreateApplicant(Applicant applicant)
        {
            _ = _context.Applicants.Add(applicant);
            return applicant;
        }

        public Applicant UpdateApplicant(Applicant applicant)
        {
            _ = _context.Applicants.Update(applicant);
            return applicant;
        }

        public void DeleteApplicant(Applicant applicant)
        {
            _ = _context.Applicants.Remove(applicant);
        }

        public Applicant GetApplicant(int ID)
        {
            return _context.Applicants.Find(ID);
        }

        public IEnumerable<Applicant> GetApplicants()
        {
            return _context.Applicants.ToList();
        }
    }
}
