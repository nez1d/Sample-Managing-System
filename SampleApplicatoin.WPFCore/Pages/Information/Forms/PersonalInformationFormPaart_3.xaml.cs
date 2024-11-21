using SampleApplicatoin.WPFCore.ViewModels;
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
            EmploeeViewModel.Education = EducationInformatinoComboBox.Text;
            EmploeeViewModel.Qualification = QualificationInformatinoTextBox.Text;
            EmploeeViewModel.Specialization = SpecializationInformatinoTextBox.Text;
            this.NavigationService.Navigate(new PersonalInformationFormPaart_4());
        }
    }
}
