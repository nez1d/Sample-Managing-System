namespace SampleApplicatoin.Domain.Models
{
    public class WorkExporience
    {
        public int Id { get; set; }
        public string EmploeeId { get; set; }
        public string CompanyName { get; set; }
        public string Post { get; set; }
        public string StartWork { get; set; }
        public string FinishWork { get; set; }
        public string ReasonForDimissal { get; set; }
    }
}