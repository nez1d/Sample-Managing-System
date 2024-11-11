using Microsoft.EntityFrameworkCore;
using SampleApplicatoin.Domain.Models;

namespace SampleApplicatoin.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Projects\\C#\\WPF\\SampleApplication\\SampleApplicatoin.Persistence\\DatabaseTest.mdf;Integrated Security=True");
        }

        public DbSet<Employee> Emploees { get; set; }
        /*public DbSet<FamilyComposition> FamilyCompositions { get; set; }
        public DbSet<Passport> Passports { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<UsingVacation> Vacations { get; set; }
        public DbSet<WorkExperienceOnCompany> WorkExperienceOnCompanies { get; set; }
        public DbSet<WorkExporience> WorkExporiences { get; set; }*/
    }
}
