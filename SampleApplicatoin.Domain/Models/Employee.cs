using SampleApplicatoin.Domain.Enums;

namespace SampleApplicatoin.Domain.Models;

public class Employee
{
    public Guid Id { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Patronymic { get; set; }
    public Gender? Gender { get; set; }
    public DateTime? BirthDate { get; set; }
    public string? Education { get; set; }
    public string? Specialization { get; set; }
    public string? Qualification { get; set; }
    public int? MaritalStatus { get; set; }
    public string? Address { get; set; }
    public string? PhoneNumber { get; set; }
    public string? PhotoPath { get; set; }
    public bool? IsValidInfo { get; set; }
    /*public Salary Salary { get; set; }
    public Guid SalaryId { get; set; }*/
}