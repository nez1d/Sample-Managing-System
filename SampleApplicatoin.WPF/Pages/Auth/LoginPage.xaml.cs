using System.Windows.Controls;
using System.Windows;
using System.Windows.Input;
using SampleApplicatoin.WPF.Pages.Auth;

namespace SampleApplicatoin.WPF.Pages.Auth
{
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        public void toRegisterBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                
            }
        }

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
