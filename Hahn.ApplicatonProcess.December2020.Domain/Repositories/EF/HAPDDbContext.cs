using Hahn.ApplicatonProcess.December2020.Data;
using Microsoft.EntityFrameworkCore;

namespace Hahn.ApplicatonProcess.December2020.Domain.Repositories.EF
{
    public class HAPDDbContext : DbContext
    {
        public HAPDDbContext(DbContextOptions<HAPDDbContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Add applicant dataset to DBContext
        /// </summary>
        public DbSet<Applicant> Applicants { get; set; }
    }
}