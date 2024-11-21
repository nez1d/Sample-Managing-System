using System.Windows;
using System.Windows.Controls;
using SampleApplicatoin.WPFCore.Pages.Main.Information;

namespace SampleApplicatoin.WPFCore.Pages.Account.Menu;

public partial class VerifyFieldsPage : Page
{
    public VerifyFieldsPage()
    {
        InitializeComponent();
    }

    private void clickToPassPersonalVerifyButton_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        GridRow_1.Height = new GridLength(0);
        GridRow_2.Height = new GridLength(0);
        GridRow_3.Height = new GridLength(0);

        verifyFieldsFrame.Visibility = Visibility.Visible;
        
        verifyFieldsFrame.Navigate(new InformationPage());
    }
}
