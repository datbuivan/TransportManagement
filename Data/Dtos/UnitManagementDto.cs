using System.ComponentModel.DataAnnotations;
using TransportManagement.Data.Entities;

namespace TransportManagement.Data.Dtos
{
    public class UnitManagementDto
    {
        [Required]
        public string Name { get; set; } = string.Empty; // Tên đơn vị
        [Required]
        public string Group { get; set; } = string.Empty; // Nhóm
        [Required]
        public string EmailCompany { get; set; } = string.Empty; // Email công ty
        public DateTime CreatedDate { get; set; } // Ngày tạo
        [Required]
        public string TaxName { get; set; } = string.Empty; // Tên khai thuế
        [Required]
        public string TaxCode { get; set; } = string.Empty; // Mã khai thuế 
        public string InvoicingAddress { get; set; } = string.Empty; // địa chỉ xuất hoá đơn 
        [Required]
        public string BankName { get; set; } = string.Empty; // Tên ngân hàng
        [Required]
        public string AccountOwner { get; set; } = string.Empty; // Chủ tài khoản
        [Required]
        public string AccountNumber { get; set; } = string.Empty; // Số tài khoán
        public string BankAddress { get; set; } = string.Empty; // Chi nhánh ngân hàng
        [Required]
        public int Status { get; set; } // Trạng thái 
        [Required]
        public string BusinessLicense { get; set; } = string.Empty; // Giấy phép kinh doanh
        [Required]
        public string TransportBusinessLicense { get; set; } = string.Empty; // Giấy phép kinh doanh vận tải 
        [Required]
        public string PhoneContact { get; set; } = string.Empty; //SDT đầu mối
        [Required]
        public string Contact { get; set; } = string.Empty; // Đầu mối liên hệ
        [Required]
        public string EmailContact { get; set; } = string.Empty; // Email người liên hệ 
        public string Note { get; set; } = string.Empty; //Ghi chú
    }
}
