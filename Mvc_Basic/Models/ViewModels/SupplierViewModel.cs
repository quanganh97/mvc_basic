using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Mvc_Basic.Models.ViewModels
{
    public class SupplierViewModel
    {
        public Guid Id { get; set; } 

        [Required(ErrorMessage = "Vui lòng nhập tên nhà cung cấp")]
        [MaxLength(250, ErrorMessage = "Tên nhà cung cấp không được quá 250 ký tự")]
        [DisplayName("Tên Nhà cc")]
        public string Name { get; set; }
        
        [MaxLength(50, ErrorMessage = "Tên nhà cung cấp không được quá 250 ký tự")]
        [DisplayName("Mã code")]
        public string CodeName { get; set; }

        [Required(ErrorMessage = "Email không được để trống")]
        [MaxLength(50)]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required (ErrorMessage = "Email không được để trống")]
        [MaxLength(20)]
        [DisplayName("Số điện thoại")]
        public string Phone { get; set; }

        [MaxLength(50)]        
        public string Fax { get; set; }

    }
}