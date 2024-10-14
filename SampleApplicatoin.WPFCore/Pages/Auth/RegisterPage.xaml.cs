using System.Windows;
using System.Windows.Controls;
using SampleApplication.Appliaction.Data.Repository;
using SampleApplicatoin.Persistence;
using SampleApplicatoin.WPFCore.Models.Constants;

namespace SampleApplicatoin.WPF.Pages.Auth
{
    public partial class RegisterPage : Page
    {
        private EmploeeRepository _emploeeRepository;
            
        public RegisterPage()
        {
            ApplicationDbContext _applicatoinDbContext = new ApplicationDbContext();
            _emploeeRepository = new EmploeeRepository(_applicatoinDbContext);
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            bool validPassword = ConfirmPassword(confirmPasswordTextBox.Text,
                passwordTextBox.Text);

            if (validPassword)
            {
                _emploeeRepository.Create(
                    loginTextBox.Text,
                    passwordTextBox.Text);
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
