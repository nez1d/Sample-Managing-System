﻿namespace SampleApplicatoin.Domain.Models
{
    public class Salary
    {
        public int Id { get; set; }
        public string EmploeeId { get; set; }
        public string TypeOfSalary { get; set; }
        public string SalaryAmount { get; set; }
        public string BeginnigOfAction { get; set; }
        public string OrderNumber { get; set; }
        public DateTime DateOfTheOrder { get; set; }
    }
}