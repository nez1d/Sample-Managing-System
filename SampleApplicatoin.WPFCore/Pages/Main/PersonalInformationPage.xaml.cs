using SampleApplication.Appliaction.Data.Repository;
using SampleApplicatoin.Persistence;
using SampleApplicatoin.WPFCore.Models.Constants;
using System.Windows.Controls;

namespace SampleApplicatoin.WPF.Pages.Main
{
    public partial class PersonalInformationPage : Page
    {
        private EmploeeRepository _emploeeRepository;
        public PersonalInformationPage()
        {
            ApplicationDbContext _applicatoinDbContext = new ApplicationDbContext();
            _emploeeRepository = new EmploeeRepository(_applicatoinDbContext);
            InitializeComponent();
        }

        private void savePersonalInformationBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            string login = AuthConstants.Login;

            var user = _emploeeRepository.GetByLogin(login);
            if(user != null)
            {
                _emploeeRepository.Update(login, null, "", firstNameTextBox.Text, lastNameTextBox.Text, patronymicTextBox.Text,
                    genderTextBox.Text, null, educationTextBox.Text, specializationTextBox.Text,
                    QualificationTextBox.Text, null, "", "", "", "");
            }
        }

        private void updatePersonalInformationBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }
    }
}
