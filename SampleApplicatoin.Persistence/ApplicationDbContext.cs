using Microsoft.EntityFrameworkCore;
using SampleApplicatoin.Domain.Models;

namespace SampleApplicatoin.Persistence
{
    public class ApplicatoinDbContext : DbContext
    {
        public ApplicatoinDbContext(DbContextOptions<ApplicatoinDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Emploee> Emploees { get; set; }
        public DbSet<FamilyComposition> FamilyCompositions { get; set; }
        public DbSet<Passport> Passports { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<UsingVacation> Vacations { get; set; }
        public DbSet<WorkExperienceOnCompany> WorkExperienceOnCompanies { get; set; }
        public DbSet<WorkExporience> WorkExporiences { get; set; }
    }
}
