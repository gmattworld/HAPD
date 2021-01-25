using System.Threading.Tasks;
using Hahn.ApplicatonProcess.December2020.Data;
using Hahn.ApplicatonProcess.December2020.Domain.IRepositories;
using Hahn.ApplicatonProcess.December2020.Domain.Repositories.EF;
using Hahn.ApplicatonProcess.December2020.Domain.Repositories.Utilities;
using Microsoft.EntityFrameworkCore;

namespace Hahn.ApplicatonProcess.December2020.Domain.Repositories
{
    public class ApplicantRepository : BaseRepository<Applicant, int>, IApplicantRepository
    {
        protected readonly HAPDDbContext _context;

        public ApplicantRepository(HAPDDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await _context.Applicants.AnyAsync(e => e.ID.Equals(id));
        }
    }
}
