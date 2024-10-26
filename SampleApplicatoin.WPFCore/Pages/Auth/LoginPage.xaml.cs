using System.Windows.Controls;
using System.Windows;
using System.Windows.Input;
using SampleApplication.Appliaction.Data.Repository;
using SampleApplicatoin.Persistence;
using System.Linq;
using SampleApplicatoin.WPFCore.Models.Constants;


namespace SampleApplicatoin.WPF.Pages.Auth
{
    public partial class LoginPage : Page
    {
        private EmploeeRepository _emploeeRepository;
        ApplicationDbContext _applicatoinDbContext;

        public LoginPage()
        {
            _applicatoinDbContext = new ApplicationDbContext();
            _emploeeRepository = new EmploeeRepository(_applicatoinDbContext);
            InitializeComponent();
        }

        public void toRegisterBtn_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
        }

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            var user = _emploeeRepository.GetByLogin(
                loginTextBox.Text);
            if(user != null)
            {
                if(user.Login == loginTextBox.Text && user.Password == passwordTextBox.Text)
                {
                    AuthConstants.Login = loginTextBox.Text;
                    AuthConstants.Password = passwordTextBox.Text;
                    Forms.MainForm mainForm = new Forms.MainForm();
                    Application.Current.MainWindow.Close();
                    mainForm.Show();
                }
            }
        }
    }
}
