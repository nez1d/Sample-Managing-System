using Microsoft.EntityFrameworkCore;
using SampleApplicatoin.Domain.Models;

namespace SampleApplicatoin.Persistence;

public class ApplicationDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Projects\\C#\\WPF\\SampleApplication\\SampleApplicatoin.Persistence\\Database.mdf;Integrated Security=True");
    }

    public DbSet<Employee> Emploees { get; set; }
    public DbSet<Passport> Passports { get; set; }
    public DbSet<Salary> Salaries { get; set; }
    public DbSet<Activity> Activities { get; set; }
    public DbSet<Checkout> Checkouts { get; set; }
}