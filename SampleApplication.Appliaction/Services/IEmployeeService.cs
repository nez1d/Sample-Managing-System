namespace SampleApplication.Appliaction.Services;

public interface IEmployeeService
{
    Task RegisterAsync();
    Task LoginAsync();
    Task UpdateAsync();
    Task DeleteAsync();
    Task GetPersonalInfoAsync();
    Task EditPersonalInfoAsync();
    Task AddPersonalInfoAsync();
    Task GetPersonalInfoAsync();
    Task CheckPersonalInfoAsync();
    Task HiringAnAsync();
    Task PromotionAsync();
    Task DismissalAsync();
    Task BonusesForAsync();
}
