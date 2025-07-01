using System;
using System.ComponentModel.DataAnnotations;

namespace NguyenDuyKhanh_2310900050.Models
{
    public class NdkEmployee
    {
        [Key]
        public int NdkEmpId { get; set; }

        [Required]
        public string NdkEmpName { get; set; }

        public string NdkEmpLevel { get; set; }

        [DataType(DataType.Date)]
        public DateTime NdkEmpStartDate { get; set; }

        public bool NdkEmpStatus { get; set; }
    }
}       