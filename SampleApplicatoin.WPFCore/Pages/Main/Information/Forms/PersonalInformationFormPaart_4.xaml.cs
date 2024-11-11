using System.Windows;
using System.Windows.Controls;

namespace SampleApplicatoin.WPFCore.Pages.Main.Information.Forms
{
    public partial class PersonalInformationFormPaart_4 : Page
    {
        public PersonalInformationFormPaart_4()
        {
            InitializeComponent();
        }

        private void SendRequestButtonPart_4_Click(object sender, RoutedEventArgs e)
        {
            InformationPage.model.Email = EmailInformatinoTextBox.Text;
            InformationPage.model.PhoneNumber = PhoneInformatinoTextBox.Text;
            InformationPage.model.Address = AddressInformatinoTextBox.Text;
            this.NavigationService.Navigate(new PersonalInformationFormPaart_5());
        }
    }
}