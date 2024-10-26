using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace SampleApplicatoin.WPFCore.Pages.Main.Information.Forms
{
    public partial class PersonalInformationFormPaart_3 : Page
    {
        public PersonalInformationFormPaart_3()
        {
            InitializeComponent();
        }

        private void SendRequestButtonPart_3_Click(object sender, RoutedEventArgs e)
        {
            InformationPage.model.Education = EducationInformatinoComboBox.Text;
            InformationPage.model.Qualification = QualificationInformatinoTextBox.Text;
            InformationPage.model.Specialization = SpecializationInformatinoTextBox.Text;
            this.NavigationService.Navigate(new PersonalInformationFormPaart_4());
        }
    }
}
