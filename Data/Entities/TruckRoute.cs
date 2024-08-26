using Microsoft.Extensions.Hosting;
using TransportManagement.Data.Entities.Cunstom;

namespace TransportManagement.Data.Entities
{
    public class TruckRoute : BaseEntities // Tuyến xe 
    {
        public string Name { get; set; } = string.Empty; // Tên tuyến xe
        public string RouteType {  get; set; } = string.Empty; // Loại tuyến
        public string ServicePack { get; set; } = string.Empty; // Gói dịch vụ
        public string Coordinator { get; set; } = string.Empty; // Điều phối
        public string PartnerId { get; set; } = string.Empty;  //   Mã đối tác
        public double Load { get; set; } // Tải trọng
        public string DriverCharge { get; set; } = string.Empty; // Tài xế phụ trách
        public string RarCarCharge { get; set; } = string.Empty; // Xe tải phụ trách
        public string AssistantDriverCharge { get; set; } = string.Empty; // Laí phụ phụ trách
        public double TotalDistance { get; set; } // Tổng quãng đường
        public double ChargeKm { get; set; } // Số km tính phí
        public DateTime ActiveTime { get; set; }    // Thời gian hoạt động
        public double Toll { get; set; }   //  Phí cầu đường
        public double OvertimeFee { get; set; } //  Phí ngoài giờ 
        public string TypeManagementCost { get; set; } = string.Empty; // Loại chi phí quản lý
        public double ManagementCostValue { get; set; } // Giá trị chi phí quản lý
        public double TotalEstimatedCost { get; set; } // Tổng chi phía tạm tính
        public DateTime DateApplication {  get; set; } // Ngày áp dụng
        public int Status {  get; set; } // Trạng thái 
        public Guid? ContractId { get; set; } 
        public Contract Contract { get; set; } = null!;
        public virtual ICollection<RoutePoint> RoutePoints { get; set; } = new List<RoutePoint>();
        public virtual ICollection<TruckTrip> TrunkTrips { get; set; } = new List<TruckTrip>();


    }
}
