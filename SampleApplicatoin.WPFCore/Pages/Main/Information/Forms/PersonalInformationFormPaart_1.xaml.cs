using System.Windows;
using System.Windows.Controls;

namespace SampleApplicatoin.WPFCore.Pages.Main.Information.Forms
{
    public partial class PersonalInformationFormPaart_1 : Page
    {
        public PersonalInformationFormPaart_1()
        {
            InitializeComponent();
        }

        private void SendRequestButtonPart_1_Click(object sender, RoutedEventArgs e)
        {
            InformationPage.model.FirstName = FirstNameInformatinoTextBox.Text;
            InformationPage.model.LastName = LastNameInformatinoTextBox.Text;
            InformationPage.model.Patronymic = PatronymicInformatinoTextBox.Text;
            /*InformationPage.model.BirthDate = Convert.ToDateTime(BirthDateInformatinoTextBox.Text);*/
            InformationPage.model.MaritalStatus = MaterialStatusInformatinoTextBox.Text;
            this.NavigationService.Navigate(new PersonalInformationFormPaart_2());
        }
    }
}