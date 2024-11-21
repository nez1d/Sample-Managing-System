using SampleApplicatoin.WPFCore.ViewModels;
using System;
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
            EmploeeViewModel.FirstName = FirstNameInformatinoTextBox.Text;
            EmploeeViewModel.LastName = LastNameInformatinoTextBox.Text;
            EmploeeViewModel.Patronymic = PatronymicInformatinoTextBox.Text;
            EmploeeViewModel.BirthDate = /*Convert.ToDateTime(BirthDateInformatinoTextBox.Text);*/ DateTime.UtcNow;
            EmploeeViewModel.MaritalStatus = /*Convert.ToInt16(MaterialStatusInformatinoTextBox.Text);*/ 1;
            this.NavigationService.Navigate(new PersonalInformationFormPaart_2());
        }
    }
}