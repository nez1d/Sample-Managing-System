using System.Reflection.Metadata;

namespace SampleApplicatoin.Domain.Models;

public class Activity
{
    public Guid id { get; set; }
    public string? DaysWorked { get; set; }
    public string? DaysWorkedInAWeek { get; set; }
    public string? DaysWorkedInAMonth { get; set; }
    public Employee Employee { get; set; }
    public Salary? Salary { get; set; }
    public IEnumerable<string>? Fines { get; set; }
    public int? FinesCounter { get; set; }
}
