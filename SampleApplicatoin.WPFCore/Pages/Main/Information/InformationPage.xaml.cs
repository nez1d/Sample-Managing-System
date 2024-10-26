using SampleApplicatoin.WPFCore.Data.Constants;
using SampleApplicatoin.WPFCore.Pages.Main.Information.Forms;
using SampleApplicatoin.WPFCore.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace SampleApplicatoin.WPFCore.Pages.Main.Information;

public partial class InformationPage : Page
{
    public static EmploeeViewModel model = new EmploeeViewModel();
    public PersonalInformationFormPaart_1 personalInformationFormPaart_1;
    public PersonalInformationFormPaart_2 personalInformationFormPaart_2;
    public PersonalInformationFormPaart_3 personalInformationFormPaart_3;
    public PersonalInformationFormPaart_4 personalInformationFormPaart_4;
    public PersonalInformationFormPaart_5 personalInformationFormPaart_5;

    public InformationPage()
    {
        personalInformationFormPaart_1 = new PersonalInformationFormPaart_1();
        personalInformationFormPaart_2 = new PersonalInformationFormPaart_2();
        personalInformationFormPaart_3 = new PersonalInformationFormPaart_3();
        personalInformationFormPaart_4 = new PersonalInformationFormPaart_4();
        personalInformationFormPaart_5 = new PersonalInformationFormPaart_5();
        InitializeComponent();
    }

    private void Grid_Loaded(object sender, RoutedEventArgs e)
    {
        InformationPagesRadioButtonPart_1.IsChecked = true;
        PersonalInformationFormFrame.Navigate(new PersonalInformationFormPaart_1());
    }

    private void InformationPagesRadioButtonPart_1_Click(object sender, RoutedEventArgs e)
    {
        PersonalInformationFormFrame.Navigate(personalInformationFormPaart_1);
    }

    private void InformationPagesRadioButtonPart_2_Click(object sender, RoutedEventArgs e)
    {
        PersonalInformationFormFrame.Navigate(personalInformationFormPaart_2);
    }

    private void InformationPagesRadioButtonPart_3_Click(object sender, RoutedEventArgs e)
    {
        PersonalInformationFormFrame.Navigate(personalInformationFormPaart_3);
    }

    private void InformationPagesRadioButtonPart_4_Click(object sender, RoutedEventArgs e)
    {
        PersonalInformationFormFrame.Navigate(personalInformationFormPaart_4);
    }

    private void InformationPagesRadioButtonPart_5_Click(object sender, RoutedEventArgs e)
    {
        PersonalInformationFormFrame.Navigate(personalInformationFormPaart_5);
    }
}