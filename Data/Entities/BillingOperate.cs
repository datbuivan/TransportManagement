using TransportManagement.Data.Entities.Cunstom;

namespace TransportManagement.Data.Entities
{
    public class BillingOperate : BaseEntities  // Phiếu thu chi
    {
        public string Name { get; set; } = string.Empty;//Tên phiếu 
        public string CouponType { get; set; } = string.Empty;// Loại phiếu
        public string Category { get; set; } = string.Empty;// Hạng mục
        public string ChargeObject { get; set; } = string.Empty;// Đối tượng tính phí
        public string CostName { get; set; } = string.Empty;// Tên chi phí
        public string Explanation {  get; set; } = string.Empty; // Giải trình
        public string Source { get; set; } = string.Empty;// Nguồn tạo 
        public string Creator { get; set; } = string.Empty;// Người tạo
        public string Reviser { get; set; } = string.Empty;// Người duyệt
        public string PaymentFinalizer { get; set; } = string.Empty;// Người chốt thanh toán
        public string PaymentConfirmer { get; set; } = string.Empty;// Người xác nhận thanh toán
        public string Document { get; set; } = string.Empty;//Chứng từ
        public double ActualPayment { get; set; } // Hình thức thanh toán
        public int Status { get; set; } // Trạng thái
        public string CostGroup { get; set; } = string.Empty;// Nhóm chi phí
        public string ObjectCode { get; set; } = string.Empty;// Mã đối tượng
        public double Cost { get; set; } // Chi phí cần trả
        public string ChargedTime { get; set; } = string.Empty;// Thời gian tính phí
        public DateTime CreatedDate { get; set; } // Ngày tạo
        public DateTime ApprovalDate { get; set; } // Ngày duyệt
        public string PaymentCloseDate { get; set; } = string.Empty; // Ngày chốt thanh toán
        public string PaymentDate { get; set; } = string.Empty; // Ngày thanh toán
        public string Payments { get; set; } = string.Empty; // Hình thức thanh toán
        public double DebtArise { get; set; }  // Công nợ phát sinh 
        public Guid? TripId { get; set; } 
        public TruckTrip Trip { get; set; } = null!; 
        public Guid? BillingOperateTypeId { get; set; } 
        public BillingOperateType BillingOperateType { get; set; } = null!;
        public Guid? TruckId { get; set; } 
        public Truck Truck { get; set; } = null!;
        public Guid? UnitManagementId { get; set; } 
        public UnitManagement UnitManagement { get; set; } = null!;
        public Guid? DriverUserId {  get; set; }
        public DriverUser DriverUser { get; set; } = null!;

    }
}
