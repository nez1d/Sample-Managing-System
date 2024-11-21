using SampleApplication.Appliaction.Services;
using SampleApplicatoin.Persistence;
using SampleApplicatoin.WPFCore.Models.Constants;
using System.Windows.Controls;

namespace SampleApplicatoin.WPFCore.Pages.Home;

public partial class HomePage : Page
{
    private readonly ApplicationDbContext applicationDbContext;
    private readonly EmployeeService employeeService;
    public HomePage()
    {
        applicationDbContext = new ApplicationDbContext();
        employeeService = new EmployeeService(applicationDbContext);
        InitializeComponent();
    }

    private async void Grid_Loaded(object sender, System.Windows.RoutedEventArgs e)
    {
        /*var result = employeeService.CheckPersonalInfoAsync(AuthConstants.Login);
        if (result.Result)
        {
            var user = await employeeService.GetUserNameAsync(AuthConstants.Login);
            HomeName1TextBlock.Visibility = System.Windows.Visibility.Visible;
            HomeNameTextBlock.Visibility = System.Windows.Visibility.Visible;
            HomeNameTextBlock.Text = $"{user}";
            HomeName2TextBlock.Visibility = System.Windows.Visibility.Visible;
        }
        else
        {
            HomeNameErrorTextBlock.Visibility = System.Windows.Visibility.Visible;
        }*/
    }
}
