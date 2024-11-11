using SampleApplicatoin.WPFCore.Pages.Main;
using SampleApplicatoin.WPFCore.Pages.Main.Information;
using System.Windows;
using System.Windows.Input;
using SampleApplicatoin.WPFCore.Pages.Salary;
using SampleApplicatoin.WPFCore.Pages.Notifications;
using SampleApplicatoin.WPFCore.Pages.Account.Menu;
using SampleApplicatoin.WPFCore.Pages.Home;

namespace SampleApplicatoin.WPF.Forms
{
    public partial class MainForm : Window
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            CenterMenuFrame.Navigate(new HomePage());
        }

        private int couter = 0;

        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void fullScreenBtn_Click(object sender, RoutedEventArgs e)
        {
            if(couter % 2 != 0)
            {
                couter++;
                this.WindowState = WindowState.Normal;
            }
            else
            {
                couter++;
                this.WindowState = WindowState.Maximized;
            }
        }

        private void minimizeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void homeMenuBtn_Click(object sender, RoutedEventArgs e)
        {
            CenterMenuFrame.Navigate(new SampleApplicatoin.WPFCore.Pages.Home.HomePage());
        }

        private void profileMenuBtn_Click(object sender, RoutedEventArgs e)
        {
            CenterMenuFrame.Navigate(new AccountMenu());
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Border_Loaded(object sender, RoutedEventArgs e)
        {
            RightMenuFrame.Navigate(new InfoNotificationPage());
            RightMenuFrame.Navigate(new SussessNotificationPage());
            RightMenuFrame.Navigate(new WarningNotificationPage());
            RightMenuFrame.Navigate(new ErrorNotificationPage());
        }

        private void RightMenuFrame_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void salaryMenuBtn_Click(object sender, RoutedEventArgs e)
        {
            CenterMenuFrame.Navigate(new SalaryPage());
        }

        private void informationMenuBtn_Click(object sender, RoutedEventArgs e)
        {
            CenterMenuFrame.Navigate(new InformationPage());
        }
    }
}
