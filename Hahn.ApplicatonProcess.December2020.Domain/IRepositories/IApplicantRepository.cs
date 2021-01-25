using System.Threading.Tasks;
using Hahn.ApplicatonProcess.December2020.Data;
using Hahn.ApplicatonProcess.December2020.Domain.IRepositories.Utilities;

namespace Hahn.ApplicatonProcess.December2020.Domain.IRepositories
{
    public interface IApplicantRepository : IBaseRepository<Applicant, int>
    {
        Task<bool> ExistsAsync(int id);
    }
}
