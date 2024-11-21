using System.Windows;
using System.Windows.Controls;
using SampleApplication.Appliaction.Services;
using SampleApplicatoin.Domain.Models;
using SampleApplicatoin.Persistence;
using SampleApplicatoin.Persistence.Repository;
using SampleApplicatoin.WPFCore.Models.Constants;

namespace SampleApplicatoin.WPF.Pages.Auth
{
    public partial class RegisterPage : Page
    {
        private readonly EmployeeService employeeService;
        private readonly EmploeeRepository emploeeRepository;

        public RegisterPage()
        {
            ApplicationDbContext applicatoinDbContext = new ApplicationDbContext();
            employeeService = new EmployeeService(applicatoinDbContext);
            emploeeRepository = new EmploeeRepository(applicatoinDbContext);
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, RoutedEventArgs e)
        {
            var user = employeeService.RegisterAsync(
                loginTextBox.Text, 
                passwordTextBox.Text, 
                confirmPasswordTextBox.Text);

            if (user.Result)
            {
                MessageBox.Show("Аккаунт Создан!");
                AuthConstants.Login = loginTextBox.Text;
                AuthConstants.Password = passwordTextBox.Text;
                Forms.MainForm mainForm = new Forms.MainForm();
                mainForm.Show();
                Application.Current.MainWindow.Close();
            }
            else
            {
                MessageBox.Show("Ошибка создания аккаунта!");
            }
        }

    }
}
