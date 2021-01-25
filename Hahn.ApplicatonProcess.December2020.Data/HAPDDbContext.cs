using Microsoft.EntityFrameworkCore;

namespace Hahn.ApplicatonProcess.December2020.Data
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