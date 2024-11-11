using SampleApplicatoin.Persistence;

namespace SampleApplication.Appliaction.Services;

public class EmployeeService : IEmployeeService
{
    private readonly ApplicationDbContext applicationDbContext;
    public EmployeeService(ApplicationDbContext applicationDbContext) =>
        this.applicationDbContext = applicationDbContext;

    public async Task RegisterAsync() { }

    public async Task LoginAsync() { }

    public async Task UpdateAsync() { }

    public async Task DeleteAsync() { }

    public async Task AddPersonalInfoAsync() { }

    public async Task EditPersonalInfoAsync() { }

    public async Task GetPersonalInfoAsync() { }

    public async Task CheckPersonalInfoAsync() { }

    public async Task HiringAnAsync() { }

    public async Task PromotionAsync() { }

    public async Task DismissalAsync() { }

    public async Task BonusesForAsync() { }
}