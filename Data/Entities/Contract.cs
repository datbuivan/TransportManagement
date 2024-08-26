using System.Runtime.InteropServices;
using TransportManagement.Data.Entities.Cunstom;

namespace TransportManagement.Data.Entities
{
    public class Contract : BaseEntities  // Hợp đồng
    {
        public string Name { get; set; } = string.Empty;   //Tên hợp đồng
        public string ContractType { get; set; } = string.Empty;   // Loại hợp đồng
        public string Payments { get; set; } = string.Empty; // Hình thức thanh toán
        public double Deposit { get; set; }    // Số tiền ký quỹ
        public string PaymentCloseDate { get; set; } = string.Empty; // Ngày chốt thanh toán
        public string PaymentDate { get; set; } = string.Empty; // Ngày cần thanh toán
        public string DebtCloseDate { get; set; } = string.Empty; // Ngày chốt công nợ 
        public double CurrentDebt { get; set; }  // Công nợ hiện tại
        public string Note { get; set; } = string.Empty; // Ghi chú
        public int Status { get; set; }  // Trạng thái
        public DateTime SignedDate { get; set; }  // Ngày kí kết
        public DateTime ExpirationDate { get; set; }   // Ngày hết hạn
        public DateTime DepositDate { get; set; }  // Ngày ký quỹ
        public Guid? CustomerId { get; set; } 
        public Customer Customer { get; set; } = null!;
        public virtual ICollection<PackageByDistance> PackageByDistanceS { get; set; } = new List<PackageByDistance>();
        public virtual ICollection<PackageByTrip> PackageByTripS { get; set; } = new List<PackageByTrip>();
        public virtual ICollection<PackageShift> PackageShifts { get; set; } = new List<PackageShift>();
        public virtual ICollection<TruckRoute> TruckRoute { get; set; } = new List<TruckRoute>();
    }
}
