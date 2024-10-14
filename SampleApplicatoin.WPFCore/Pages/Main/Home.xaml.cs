using System.Windows;
using System.Windows.Controls;

namespace SampleApplicatoin.WPFCore.Pages.Main
{
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            notifBorder.Visibility = System.Windows.Visibility.Hidden;
            notifRow.Height = new GridLength();
            notifRow.MaxHeight = 80;
        }
    }
}
