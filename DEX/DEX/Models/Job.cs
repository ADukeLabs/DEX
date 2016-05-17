using System;

namespace DEX.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string JobTitle { get; set; }
        public DateTime DateApplied { get; set; }
        public Company Company { get; set; }
    }
}