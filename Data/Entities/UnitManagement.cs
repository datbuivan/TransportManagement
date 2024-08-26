using TransportManagement.Data.Entities.Cunstom;

namespace TransportManagement.Data.Entities
{
    public class UnitManagement : BaseEntities // Đơn vị cung ứng
    {
        public string Name { get; set; } = string.Empty; // Tên đơn vị
        public string Group { get; set; } = string.Empty; // Nhóm
        public string EmailCompany { get; set; } = string.Empty; // Email công ty
        public DateTime CreatedDate { get; set; } // Ngày tạo
        public string TaxName { get; set; } = string.Empty; // Tên khai thúe 
        public string TaxCode { get; set; } = string.Empty; // Mã khai thuế 
        public string InvoicingAddress { get; set; } = string.Empty; // địa chỉ xuất hoá đơn 
        public string BankName { get; set; } = string.Empty; // Tên ngân hàng
        public string AccountOwner { get; set; } = string.Empty; // Chủ tài khoản
        public string AccountNumber { get; set; } = string.Empty; // Số tài khoán
        public string BankAddress { get; set; } = string.Empty; // Địa chỉ ngân hàng
        public int Status { get; set; } // Trạng thái 
        public string BusinessLicense { get; set; } = string.Empty; // Giấy phép kinh doanh
        public string TransportBusinessLicense { get; set; } = string.Empty; // Giấy phép kinh doanh vận tải 
        public string PhoneContact { get; set; } = string.Empty; //SDT đầu mối
        public string Contact { get; set; } = string.Empty; // Đầu mối liên lạc
        public string EmailContact { get; set; } = string.Empty; // Email người liên hệ 
        public string Note { get; set; } = string.Empty; //Ghi chú
        public virtual ICollection<Truck> Trucks { get; set; } = new List<Truck>();  
        public virtual ICollection<DriverUser> DriverUsers { get; set; } = new List<DriverUser>();
        public virtual ICollection<BillingOperate> BillingOperates { get; set; } = new List<BillingOperate>();

    }
}
