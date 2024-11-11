using System.Windows;
using System.Windows.Controls;
using SampleApplicatoin.Domain.Models;
using SampleApplicatoin.Persistence;
using SampleApplicatoin.Persistence.Repository;
using SampleApplicatoin.WPFCore.Models.Constants;

namespace SampleApplicatoin.WPF.Pages.Auth
{
    public partial class RegisterPage : Page
    {
        private EmploeeRepository emploeeRepository;
            
        public RegisterPage()
        {
            ApplicationDbContext applicatoinDbContext = new ApplicationDbContext();
            emploeeRepository = new EmploeeRepository(applicatoinDbContext);
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            bool validPassword = ConfirmPassword(confirmPasswordTextBox.Text,
                passwordTextBox.Text);

            if (validPassword)
            {
                Employee emploee = new Employee
                {
                    Login = loginTextBox.Text,
                    Password = passwordTextBox.Text
                };
                emploeeRepository.Create(emploee);

                MessageBox.Show("Аккаунт Создан!");
                AuthConstants.Login = loginTextBox.Text;
                AuthConstants.Password = passwordTextBox.Text;
                Forms.MainForm mainForm = new Forms.MainForm();
                mainForm.Show();
                Application.Current.MainWindow.Close();
            }
        }
        public bool ConfirmPassword(string password, string confirmPassword)
        {
            if(password == confirmPassword && password != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
