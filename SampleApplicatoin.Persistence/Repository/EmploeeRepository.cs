using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SampleApplicatoin.Domain.Models;

namespace SampleApplicatoin.Persistence.Repository;

public class EmploeeRepository
{
    private ApplicationDbContext context;
    public EmploeeRepository(ApplicationDbContext context) =>
        this.context = context;

    public async Task<Employee> Create(Employee emploee)
    {
        var user = this.GetByLogin(emploee.Login);

        if(user.Result == null)
        {
            if (user.Result == null)
            {
                await context.Emploees.AddAsync(emploee);
                context.SaveChangesAsync();
                return emploee;
            }
        }
        return null;
    }

    public async Task UpdateEmployee(Employee emploee)
    {
        context.Emploees.Update(emploee);
        context.Entry(emploee).State = EntityState.Modified;
        context.SaveChanges();
    }

    public async Task Delete(Guid id)
    {
        var user = await GetById(id);
        if (user != null)
        {
            context.Emploees.Remove(user);
            await context.SaveChangesAsync();
        }
        throw new ArgumentException();
    }

    public async Task<List<Employee>> GetAll()
    {
        return await context.Emploees
            .OrderBy(emploee => emploee.Id)
            .ToListAsync();
    }

    public Task<Employee> GetById(Guid id)
    {
        return context.Emploees
            .FirstOrDefaultAsync(emploee => emploee.Id == id);
    }

    public async Task<Employee> GetByLogin(string login)
    {
        return context.Emploees
            .Where(emploee => emploee.Login == login)
            .FirstOrDefault();
    }
}