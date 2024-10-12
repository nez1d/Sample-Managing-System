namespace SampleApplicatoin.Domain.Models
{
    public class FamilyComposition
    {
        public int Id { get; set; }
        public int EmploeeId { get; set; }
        public string DegreeOfKinship { get; set; }
        public string Address { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string BirthDate { get; set; }
        public string MaterialStatus { get; set; }
    }
}
