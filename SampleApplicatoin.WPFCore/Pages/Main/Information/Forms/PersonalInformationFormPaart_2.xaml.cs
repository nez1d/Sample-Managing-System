using System.Windows;
using System.Windows.Controls;

namespace SampleApplicatoin.WPFCore.Pages.Main.Information.Forms
{
    public partial class PersonalInformationFormPaart_2 : Page
    {
        public PersonalInformationFormPaart_2()
        {
            InitializeComponent();
        }

        private void SendRequestButtonPart_2_Click(object sender, RoutedEventArgs e)
        {
            InformationPage.model.Gender = GenderInformatinoComboBox.Text;
            this.NavigationService.Navigate(new PersonalInformationFormPaart_3());
        }
    }
}
