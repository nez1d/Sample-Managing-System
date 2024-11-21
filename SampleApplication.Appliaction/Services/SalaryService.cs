using SampleApplicatoin.Domain.Models;

namespace SampleApplication.Appliaction.Services;

public class SalaryService : ISalaryService
{
    public async Task AddAsync(Salary salary) { }

    public async Task UpdateAsync(Salary salary) { }

    public async Task DeleteAsync(Guid salary) { }

    public async Task ClearAsync(Guid salary) { }

    public async Task<IEnumerable<Salary>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public async Task GetById(Guid id) { }
}