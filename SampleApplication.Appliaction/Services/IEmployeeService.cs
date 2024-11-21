namespace SampleApplication.Appliaction.Services;

public interface IEmployeeService
{
    /// <summary>
    /// Register user async.
    /// </summary>
    /// <param name="login">User login.</param>
    /// <param name="password">User password.</param>
    /// <param name="confirmPassword">User confirm password.</param>
    /// <returns></returns>
    Task<bool> RegisterAsync(string login, 
                             string password, 
                             string confirmPassword);
    Task LoginAsync();
    Task UpdateAsync();
    Task DeleteAsync();
    Task GetPersonalInfoAsync();
    Task EditPersonalInfoAsync();
    Task AddPersonalInfoAsync();
    Task CheckPersonalInfoAsync();
    Task HiringAnAsync();
    Task PromotionAsync();
    Task DismissalAsync();
    Task BonusesForAsync();
}
