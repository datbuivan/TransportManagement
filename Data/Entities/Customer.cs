using TransportManagement.Data.Entities.Cunstom;

namespace TransportManagement.Data.Entities
{
    public class Customer : BaseEntities    //  Khách hàng
    {
        public string Name { get; set; } = string.Empty;   //  Tên người dùng
        public string EmailCompany { get; set; } = string.Empty;   //  Email công ty
        public string TaxName { get; set; } = string.Empty;    //  Tên khai thuế
        public string TaxCode { get; set; } = string.Empty;    //  Mã khai thuế
        public string InvoicingAddress { get; set; } = string.Empty;   //  Địa chỉ xuất hoá đơn
        public string Contact { get; set; } = string.Empty;  //  Đầu mối liên hệ
        public string PhoneContact { get; set; } = string.Empty;    //SDT đầu mối
        public string EmailContact { get; set; } = string.Empty; //  Email người liên hệ 
        public string SaleCharge { get; set; } = string.Empty; //   Sale phụ trách
        public string CoordinatorCharge {  get; set; } = string.Empty; // Điều phối phụ trách
        public string Note { get; set; } = string.Empty;   //  Ghi chú
        public string BankName { get; set; } = string.Empty;   //  Tên ngân hàng
        public string AccountOwner { get; set; } = string.Empty;   // Chủ tài khoản
        public string AccountNumber { get; set; } = string.Empty;// Tài khoản ngân hàng
        public string BankAddress { get; set; } = string.Empty;    // Địa chỉ ngân hàng
        public int Status { get; set; }  // Trạng thái:  1 đang phục vụ ; 0: đang không phục vụ
        
        public DateTime CreatedDate { get; set; } // Ngày tạo thông tin
        public Guid? CustomerGroupId { get; set; } 
        public CustomerGroup CustomerGroup { get; set; } = null!;
        public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();


    }
}
