using System.Collections.Generic;
using Hahn.ApplicatonProcess.December2020.Data;

namespace Hahn.ApplicatonProcess.December2020.Domain
{
    public interface IApplicantRepository
    {
        IEnumerable<Applicant> GetApplicants();
        Applicant GetApplicant(int ID);
        Applicant CreateApplicant(Applicant applicant);
        void DeleteApplicant(Applicant applicant);
    }
}
