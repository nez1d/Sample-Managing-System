using SampleApplicatoin.Domain.Enums;
using SampleApplicatoin.Domain.Models;
using SampleApplicatoin.Persistence;
using SampleApplicatoin.Persistence.Repository;

namespace SampleApplication.Appliaction.Services;

public class EmployeeService/* : IEmployeeService*/
{
    private readonly ApplicationDbContext applicationDbContext;
    private readonly EmploeeRepository emploeeRepository;
    public EmployeeService(ApplicationDbContext applicationDbContext)
    {
        this.applicationDbContext = applicationDbContext;
        emploeeRepository = new EmploeeRepository(applicationDbContext);
    }

    public async Task<bool> RegisterAsync(
        string login, 
        string password, 
        string confirmPassword) 
    {
        bool validPassword = ConfirmPassword(
            password, confirmPassword);

        if (!validPassword)
        {
            return false;
        }

        var employee = new Employee
        {
            Login = login,
            Password = password
        };

        var result = await emploeeRepository.Create(employee);

        if (result != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public async Task LoginAsync() { }

    public async Task UpdateAsync() { }

    public async Task DeleteAsync() { }

    public async Task AddPersonalInfoAsync(
        string login, string password, string firstName, string lastName,
        string patronymic, Gender gender, DateTime birthDate, string education,
        string specialization, string qualification, int maritalStatus,
        string address, string phoneNumber)
    {
        if (!string.IsNullOrWhiteSpace(firstName) &&
            !string.IsNullOrWhiteSpace(lastName) &&
            !string.IsNullOrWhiteSpace(patronymic) &&
            gender != null && birthDate != null &&
            !string.IsNullOrWhiteSpace(education) &&
            !string.IsNullOrWhiteSpace(specialization) &&
            !string.IsNullOrWhiteSpace(qualification) &&
            maritalStatus != null &&
            !string.IsNullOrWhiteSpace(address) &&
            !string.IsNullOrWhiteSpace(phoneNumber))
        {
            var emploee = new Employee
            {
                Login = login,
                Password = password,
                FirstName = firstName,
                LastName = lastName,
                Patronymic = patronymic,
                Gender = gender,
                BirthDate = birthDate,
                Education = education,
                Specialization = specialization,
                Qualification = qualification,
                MaritalStatus = maritalStatus,
                Address = address,
                PhoneNumber = phoneNumber,
                IsValidInfo = true
            };

            await emploeeRepository.Update(emploee);
        }
    }

    public async Task EditPersonalInfoAsync() { }

    public async Task<Employee> GetPersonalInfoAsync(string login) 
    {
        return await emploeeRepository.GetByLogin(login);
    }

    public async Task<bool> CheckPersonalInfoAsync(string login) 
    {
        var emploee = await emploeeRepository.GetByLogin(login);

        if((bool)emploee.IsValidInfo)
        {
            return true;
        }
        return false;
    }

    public async Task HiringAnAsync() { }

    public async Task PromotionAsync() { }

    public async Task DismissalAsync() { }

    public async Task BonusesForAsync() { }

    public bool ConfirmPassword(string password, string confirmPassword)
    {
        if (password == confirmPassword && 
            !string.IsNullOrWhiteSpace(password))
            return true;
        else
            return false;
    }
    /// <summary>
    /// Get user First Name and Last Name.
    /// </summary>
    /// <param name="login">User Login</param>
    /// <returns></returns>
    public async Task<string> GetUserNameAsync(string login)
    {
        var user = await emploeeRepository.GetByLogin(login);

        if(user.FirstName != null && user.LastName != null)
            return $"{user.FirstName} {user.LastName}";

        return null;
    }
}