using SampleApplicatoin.WPF.Pages.Auth;
using System.Windows;
using System.Windows.Input;
using SampleApplicatoin.WPF.Forms;

namespace SampleApplicatoin.WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private LoginPage _loginPage = new LoginPage();
        private RegisterPage _registerPage = new RegisterPage();
        private int _authPageCounter = 0;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            AuthFrame.Navigate(new LoginPage());
        }

        private void Border_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        public void forgotPasswordBtn_Click(object sender, RoutedEventArgs e)
        {
        }

        private void toRegisterBtn_Click(object sender, RoutedEventArgs e)
        {
            if(_authPageCounter % 2 != 0)
            {
                toAuthBtn.Content = "Register";
                AuthFrame.Content = _loginPage;
                _authPageCounter++;
            }
            else
            {
                toAuthBtn.Content = "Login";
                AuthFrame.Content = _registerPage;
                _authPageCounter++;
            }

            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
