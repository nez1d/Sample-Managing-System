using SampleApplicatoin.Domain.Enums;
using SampleApplicatoin.Domain.Models;
using SampleApplicatoin.Persistence;
using SampleApplicatoin.Persistence.Repository;

namespace SampleApplication.Appliaction.Services;

public class EmployeeService
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

    public async Task AddPersonalInfoAsync(Employee employee)
    {
        if (employee != null)
        {
            var user = await emploeeRepository.GetByLogin(employee.Login);

            var result = await this.PersonalInfoValidator(
                employee.Login, employee.Password,
                employee.FirstName, employee.LastName,
                employee.Patronymic, employee.Gender,
                employee.BirthDate, employee.Education,
                employee.Specialization, employee.Qualification,
                employee.MaritalStatus, employee.Address,
                employee.PhoneNumber, employee.Email);
            if(result)
            {
                user.Login = employee.Login;
                user.Password = employee.Password;
                user.FirstName = employee.FirstName;
                user.LastName = employee.LastName;
                user.Patronymic = employee.Patronymic;
                user.Gender = employee.Gender;
                user.BirthDate = employee.BirthDate;
                user.Education = employee.Education;
                user.Specialization = employee.Specialization;
                user.Qualification = employee.Qualification;
                user.MaritalStatus = employee.MaritalStatus;
                user.Address = employee.Address;
                user.PhoneNumber = employee.PhoneNumber;
                user.Email = employee.Email;

                emploeeRepository.UpdateEmployee(user);
            } 
        }
    }

    /// <summary>
    /// Verifying the validity of user data.
    /// </summary>
    /// <param name="login">User login.</param>
    /// <param name="password">User password.</param>
    /// <param name="firstName">User first name.</param>
    /// <param name="lastName">User last name.</param>
    /// <param name="patronymic">User patronymic.</param>
    /// <param name="gender">User gender.</param>
    /// <param name="birthDate">User birthday.</param>
    /// <param name="education">User education.</param>
    /// <param name="specialization">User specialization.</param>
    /// <param name="qualification">User qualification.</param>
    /// <param name="maritalStatus">User marital status.</param>
    /// <param name="address">User address.</param>
    /// <param name="phoneNumber">User phone number.</param>
    /// <param name="email">User email addess.</param>
    /// <returns></returns>
    public async Task<bool> PersonalInfoValidator(
        string login, string password, 
        string? firstName, string? lastName,
        string? patronymic, Gender? gender, 
        DateTime? birthDate, string? education,
        string? specialization, string? qualification, 
        int? maritalStatus, string? address,
        string? phoneNumber, string? email)
    {
        if (string.IsNullOrWhiteSpace(firstName) ||
            string.IsNullOrWhiteSpace(lastName) ||
            string.IsNullOrWhiteSpace(patronymic) ||
            gender == null || birthDate == null ||
            string.IsNullOrWhiteSpace(education) ||
            string.IsNullOrWhiteSpace(specialization) ||
            string.IsNullOrWhiteSpace(qualification) ||
            maritalStatus == null ||
            string.IsNullOrWhiteSpace(address) ||
            string.IsNullOrWhiteSpace(phoneNumber) ||
            string.IsNullOrWhiteSpace(email))
        {
            return false;
        }
        return true;
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