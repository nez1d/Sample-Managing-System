using System.Windows;
using System.Windows.Controls;

namespace SampleApplicatoin.WPFCore.Pages.Account.Menu
{
    public partial class AccountMenu : Page
    {
        public AccountMenu()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            accountMenuBackBtn.Visibility = Visibility.Hidden;
        }

        private void accountMenuPersonalInforamtionBtn_Click(object sender, RoutedEventArgs e)
        {
            gridRow_2.Height = new GridLength(0);
            gridRow_3.Height = new GridLength(0);
            gridRow_4.Height = new GridLength(0);

            accountMenuBackBtn.Visibility = Visibility.Visible;
            accountMenuFrame.Visibility = Visibility.Visible;
            accountMenuFrame.Navigate(new VerifyFieldsPage());
        }

        private void accountMenuBackBtn_Click(object sender, RoutedEventArgs e)
        {
            gridRow_2.Height = new GridLength(160);
            gridRow_3.Height = new GridLength(160);
            gridRow_4.Height = new GridLength(160);

            accountMenuFrame.Visibility = Visibility.Hidden;
            accountMenuBackBtn.Visibility = Visibility.Hidden;
        }
    }
}
