using System;

namespace NdkLab06.Models
{
    public class NdkEmployee
    {
        public int ndkId { get; set; }
        public string ndkName { get; set; } = string.Empty;
        public DateTime ndkBirthDay { get; set; }
        public string ndkEmail { get; set; } = string.Empty;
        public string ndkPhone { get; set; } = string.Empty;
        public double ndkSalary { get; set; }
        public bool ndkStatus { get; set; }
    }
}