namespace SampleApplicatoin.Domain.Models
{
    public class Passport
    {
        public int Id { get; set; }
        public string EmploeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string Serie { get; set; }
        public string Number { get; set; }
        public string IssueByWhrom { get; set; }
        public DateTime DateOfIssue { get; set; }
    }
}
