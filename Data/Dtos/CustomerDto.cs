using System.ComponentModel.DataAnnotations;
using TransportManagement.Data.Entities;

namespace TransportManagement.Data.Dtos
{
    public class CustomerDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;   //  Tên người dùng
        [Required]
        public string EmailCompany { get; set; } = string.Empty;   //  Email công ty
        [Required]
        public string TaxName { get; set; } = string.Empty;    //  Tên khai thuế
        [Required]
        public string TaxCode { get; set; } = string.Empty;    //  Mã khai thuế
        [Required]
        public string InvoicingAddress { get; set; } = string.Empty;   //  Địa chỉ xuất hoá đơn
        [Required]
        public string Contact { get; set; } = string.Empty;  //  Đầu mối liên hệ
        [Required]
        public string PhoneContact { get; set; } = string.Empty;    //SDT đầu mối
        public string BankName { get; set; } = string.Empty;   //  Tên ngân hàng
        public string AccountOwner { get; set; } = string.Empty;   // Chủ tài khoản
        public string AccountNumber { get; set; } = string.Empty;// Tài khoản ngân hàng
        public string BankAddress { get; set; } = string.Empty;    // Địa chỉ ngân hàng
        public int Status { get; set; }  // Trạng thái
        public DateTime CreatedDate { get; set; } // Ngày tạo thông tin
        public Guid? CustomerGroupId { get; set; }
        public CustomerGroup CustomerGroup { get; set; } = null!;
        public string EmailContact { get; set; } = string.Empty; //  Email người liên hệ 
        public string SaleCharge { get; set; } = string.Empty; //   Sale phụ trách
        public string CoordinatorCharge { get; set; } = string.Empty; // Điều phối phụ trách
        public string Note { get; set; } = string.Empty;   //  Ghi chú


    }
}
