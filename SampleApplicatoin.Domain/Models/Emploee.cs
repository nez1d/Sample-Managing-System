namespace SampleApplicatoin.Domain.Models
{
    public class Emploee
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int? ServieNumber { get; set; }
        public string PensionCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Education { get; set; }
        public string Specialization { get; set; }
        public string Qualification { get; set; }
        public int? MaritalStatus { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string PhotoPath { get; set; }
        public string Photo { get; set; }
    }
}