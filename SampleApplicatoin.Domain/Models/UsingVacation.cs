namespace SampleApplicatoin.Domain.Models
{
    public class UsingVacation
    {
        public int Id { get; set; }
        public string EmploeeId { get; set; }
        public string VacationsView { get; set; }
        public string TypeVacation { get; set; }
        public DateTime StartVacations { get; set; }
        public DateTime EndVacations { get; set; }
    }
}