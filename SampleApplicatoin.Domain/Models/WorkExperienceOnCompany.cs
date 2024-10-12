namespace SampleApplicatoin.Domain.Models
{
    public class WorkExperienceOnCompany
    {
        public int Id { get; set; }
        public string CompanyId { get; set; }
        public string EmploeeId { get; set; }
        public string Division { get; set; }
        public string Post { get; set; }
        public string OrderNumer { get; set; }
        public DateTime DateOrder { get; set; }
        public DateTime StartWork { get; set; }
    }
}