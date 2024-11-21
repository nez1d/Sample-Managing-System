using System;
using System.Windows;
using System.Windows.Controls;
using SampleApplication.Appliaction.Services;
using SampleApplicatoin.Domain.Enums;
using SampleApplicatoin.Domain.Models;
using SampleApplicatoin.Persistence;
using SampleApplicatoin.WPFCore.Models.Constants;
using SampleApplicatoin.WPFCore.ViewModels;

namespace SampleApplicatoin.WPFCore.Pages.Main.Information.Forms;

public partial class PersonalInformationFormPaart_5 : Page
{
    private ApplicationDbContext context;
    private readonly EmployeeService employeeService;
    public PersonalInformationFormPaart_5()
    {
        context = new ApplicationDbContext();
        employeeService = new EmployeeService(context);
        InitializeComponent();
    }

    private void SendRequestButtonPart_5_Click(object sender, RoutedEventArgs e)
    {
        DataPost();

        MessageBox.Show("Данные успешно отправлены!");
        this.Visibility = Visibility.Hidden;

    }

    private void DataPost()
    {
        var employee = new Employee
        {
            Login = AuthConstants.Login, 
            Password = AuthConstants.Password,
            FirstName = EmploeeViewModel.FirstName,
            LastName = EmploeeViewModel.LastName,
            Patronymic = EmploeeViewModel.Patronymic,
            Gender = Gender.Female,
            BirthDate = EmploeeViewModel.BirthDate,
            Education = EmploeeViewModel.Education,
            Specialization = EmploeeViewModel.Specialization, 
            Qualification = EmploeeViewModel.Qualification,
            MaritalStatus = EmploeeViewModel.MaritalStatus,
            Address = EmploeeViewModel.Address,
            PhoneNumber = EmploeeViewModel.PhoneNumber,
            Email = EmploeeViewModel.Email,
        };
        
        employeeService.AddPersonalInfoAsync(employee);
    }
}