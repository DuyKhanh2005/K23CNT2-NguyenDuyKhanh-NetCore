using System;
using System.ComponentModel.DataAnnotations;

namespace NdkLesson07.Models
{
    public class NdkEmployee
    {
        [Key]
        [Display(Name = "Mã nhân viên")]
        public int NdkId { get; set; }

        [Required(ErrorMessage = "Tên nhân viên không được để trống")]
        [Display(Name = "Tên nhân viên")]
        public string NdkName { get; set; }

        [Required(ErrorMessage = "Ngày sinh không được để trống")]
        [DataType(DataType.Date)]
        [Display(Name = "Ngày sinh")]
        public DateTime NdkBirthDay { get; set; }

        [Required(ErrorMessage = "Email không được để trống")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        [Display(Name = "Email")]
        public string NdkEmail { get; set; }

        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [Phone(ErrorMessage = "Số điện thoại không hợp lệ")]
        [Display(Name = "Số điện thoại")]
        public string NdkPhone { get; set; }

        [Required(ErrorMessage = "Lương không được để trống")]
        [Range(0, double.MaxValue, ErrorMessage = "Lương phải lớn hơn hoặc bằng 0")]
        [Display(Name = "Lương")]
        public decimal NdkSalary { get; set; }

        [Display(Name = "Trạng thái làm việc")]
        public bool NdkStatus { get; set; }
    }
}