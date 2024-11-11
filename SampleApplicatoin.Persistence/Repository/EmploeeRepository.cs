using Microsoft.EntityFrameworkCore;
using SampleApplicatoin.Domain.Models;
using System.Web;

namespace SampleApplicatoin.Persistence.Repository;

public class EmploeeRepository
{
    private ApplicationDbContext context;
    public EmploeeRepository(ApplicationDbContext context) =>
        this.context = context;

    public async Task<bool> Create(Employee emploee)
    {
        var user = await GetByLogin(emploee.Login);

        if(user == null)
        {
            context.Emploees.AddAsync(emploee);
            context.SaveChangesAsync();
            return true;
        }
        return false;
    }

    public async Task<bool> Update(Employee emploee)
    {
        var user = await GetByLogin(emploee.Login);
        if(user != null)
        {
            context.Emploees.Update(user);
            await context.SaveChangesAsync();
            return true;
        }
        return false;
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

    public async Task<Employee> GetById(Guid id)
    {
        return await context.Emploees
            .FirstOrDefaultAsync(emploee => emploee.Id == id);
    }

    public async Task<Employee> GetByLogin(string login)
    {
        return await context.Emploees
            .Where(emploee => emploee.Login == login)
            .FirstOrDefaultAsync();
    }

    public async Task<Employee> GetByLoginAndPassword(string login, string password)
    {
        return await context.Emploees
            .Where(emploee => emploee.Login == login &&
                emploee.Password == password)
                .FirstOrDefaultAsync();
    }
}