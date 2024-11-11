using System.Windows.Controls;
using System.Windows;
using System.Windows.Input;
using SampleApplicatoin.Persistence;
using SampleApplication.Appliaction.Services;
using SampleApplicatoin.WPFCore.Models.Constants;
using SampleApplicatoin.Persistence.Repository;


namespace SampleApplicatoin.WPF.Pages.Auth
{
    public partial class LoginPage : Page
    {
        private readonly EmployeeService emploeeService;
        private readonly ApplicationDbContext applicatoinDbContext;
        private readonly EmploeeRepository emploeeRepository;

        public LoginPage()
        {
            applicatoinDbContext = new ApplicationDbContext();
            EmployeeService emploeeService = new EmployeeService(applicatoinDbContext);
            emploeeRepository = new EmploeeRepository(applicatoinDbContext);
            InitializeComponent();
        }

        public void toRegisterBtn_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
        }

        private async void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            var user = await emploeeRepository.GetByLogin(loginTextBox.Text);

            if (user != null)
            {
                if (user.Login == loginTextBox.Text && 
                    user.Password == passwordTextBox.Text)
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
