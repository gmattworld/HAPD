using System;
using System.Threading.Tasks;
using Hahn.ApplicatonProcess.December2020.Domain.IRepositories;

namespace Hahn.ApplicatonProcess.December2020.Domain
{
    public interface IUnitOfWork : IDisposable
    {
        IApplicantRepository Applicants { get; }
        Task<int> CompleteAsync();
    }
}
