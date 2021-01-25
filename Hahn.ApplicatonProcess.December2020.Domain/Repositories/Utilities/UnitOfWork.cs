using System.Threading.Tasks;
using Hahn.ApplicatonProcess.December2020.Domain.IRepositories;
using Hahn.ApplicatonProcess.December2020.Domain.Repositories.EF;

namespace Hahn.ApplicatonProcess.December2020.Domain.Repositories.Utilities
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HAPDDbContext _context;

        public UnitOfWork(HAPDDbContext context)
        {
            _context = context;
            Applicants = new ApplicantRepository(_context);
        }

        public IApplicantRepository Applicants { get; private set; }



        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync().ConfigureAwait(false);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}