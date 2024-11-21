using SampleApplicatoin.WPFCore.Pages.Main.Information;
using System.Windows;
using System.Windows.Input;
using SampleApplicatoin.WPFCore.Pages.Salary;
using SampleApplicatoin.WPFCore.Pages.Notifications;
using SampleApplicatoin.WPFCore.Pages.Account.Menu;
using SampleApplicatoin.WPFCore.Pages.Home;
using SampleApplication.Appliaction.Services;
using SampleApplicatoin.Persistence;
using SampleApplicatoin.WPFCore.Models.Constants;

namespace SampleApplicatoin.WPF.Forms
{
    public partial class MainForm : Window
    {
        private readonly ApplicationDbContext applicationDbContext;
        private readonly EmployeeService employeeService;
        public MainForm()
        {
            applicationDbContext = new ApplicationDbContext();
            employeeService = new EmployeeService(applicationDbContext);
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            var valid = employeeService.CheckPersonalInfoAsync(AuthConstants.Login);
/*            if (valid.Result)
            {

            }*/

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
            CenterMenuFrame.Navigate(new HomePage());
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
            /*CenterMenuFrame.Navigate(new InformationPage());*/
        }
    }
}
