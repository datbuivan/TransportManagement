using TransportManagement.Data.Entities.Cunstom;

namespace TransportManagement.Data.Entities
{
    public class Truck : BaseEntities  // Xe tải
    {
        public string LicensPlate { get; set; } = string.Empty; // Biển số xe 
        public double Load { get; set; } // Trọng tải
        public string Type { get; set; } // Loaị xe (mới cũ)
        public string Brand { get; set; } = string.Empty; //Hãng
        public string ChassisNumber { get; set; } = string.Empty;  //Số khung
        public string MachineNumber { get; set; } = string.Empty; //Số máy
        public double Length { get; set; } //Dài
        public double Weight { get; set; } //Rộng
        public double Height { get; set; } // Cao
        public double Volume { get; set; }  //Thể tích
        public DateTime Registry { get; set; } // Đăng kiểm
        public DateTime BHTNDS { get; set; } // Bảo hiểm TNDS
        public DateTime BHVCX { get; set; } // Bảo hiểm VCX
        public DateTime CardVertDate { get; set; } // Hạn cà vẹt 
        public DateTime Badge { get; set; } // Phù hiệu
        public int MaintenanceStatus { get; set; } // Trạng thái bảo dưỡng
        public int DocumentStatus { get; set; } // Trạng thái giấy tờ 
        public string TypeActive { get; set; } = string.Empty; // Hình thức hoạt động
        public double CostBuyCar { get; set; }  // Chi phí mua xe 
        public string CarDealerships { get; set; } = string.Empty;  // Đại lý bán xe  
        public DateTime PurchaseDate { get; set; }  // Ngày mua, thuê xe 
        public int YearOfManufacture { get; set; }  //Năm sản xuất
        public ICollection<TruckTrip> Trips { get; set; } = new List<TruckTrip>();
        public Guid? UnitManagementId { get; set; } 
        public UnitManagement UnitManagement { get; set; } = null!;
        public virtual ICollection<BillingOperate> BillingOperates { get; set;} = new List<BillingOperate>();

    }
}
