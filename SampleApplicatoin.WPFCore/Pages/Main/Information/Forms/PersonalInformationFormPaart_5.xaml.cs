using System;
using System.Windows;
using System.Windows.Controls;
using SampleApplication.Appliaction.Services;
using SampleApplicatoin.Domain.Enums;
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

    private void SendRequestButtonPart_5_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        employeeService.AddPersonalInfoAsync(
            AuthConstants.Login, AuthConstants.Password, EmploeeViewModel.FirstName, 
            EmploeeViewModel.LastName, EmploeeViewModel.Patronymic, Gender.Female, 
            EmploeeViewModel.BirthDate, EmploeeViewModel.Education, EmploeeViewModel.Specialization, 
            EmploeeViewModel.Qualification, EmploeeViewModel.MaritalStatus, EmploeeViewModel.Address, 
            EmploeeViewModel.PhoneNumber);

        MessageBox.Show("Данные отправлены!");
        this.Visibility = Visibility.Hidden;

    }
}