using SampleApplicatoin.Domain.Models;

namespace SampleApplication.Appliaction.Services;

public interface ISalaryService
{
    Task AddAsync(Salary salary);
    Task UpdateAsync(Salary salary);
    Task DeleteAsync(Guid salary);
    Task ClearAsync(Guid salary);
    Task<IEnumerable<Salary>> GetAllAsync();
    Task GetById(Guid id);
}