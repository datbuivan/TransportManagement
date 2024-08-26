using System.ComponentModel.DataAnnotations;

namespace TransportManagement.Data.Dtos
{
    public class TruckDto
    {
        [Required]
        public string LicensPlate { get; set; } = string.Empty; // Biển số xe 
        [Required]
        public double Load { get; set; } // Trọng tải
        [Required]
        public string Brand { get; set; } = string.Empty; //Hãng
        [Required]
        public string ChassisNumber { get; set; } = string.Empty;  //Số khung
        [Required]
        public string MachineNumber { get; set; } = string.Empty; //Số máy
        [Required]
        public double Length { get; set; } //Dài
        [Required]
        public double Weight { get; set; } //Rộng
        [Required]
        public double Height { get; set; } // Cao
        [Required]
        public double Volume { get; set; }  //Thể tích
        [Required]
        public DateTime Badge { get; set; } // Phù hiệu
        [Required]
        public DateTime Registry { get; set; } // Đăng kiểm
        [Required]
        public DateTime BHTNDS { get; set; } // Bảo hiểm TNDS
        [Required]
        public DateTime BHVCX { get; set; } // Bảo hiểm VCX
        [Required]
        public DateTime CardVertDate { get; set; } // Hạn cà vẹt 
        [Required]
        public int DocumentStatus { get; set; } // Trạng thái giấy tờ 
        [Required]
        public int MaintenanceStatus { get; set; } // Trạng thái bảo dưỡng
        [Required]
        public Guid UnitManagementId { get; set; }   // Tên đơn vị quản lý
        [Required]
        public string TypeActive { get; set; } = string.Empty; // Hình thức hoạt động
        public DateTime PurchaseDate { get; set; }  // Ngày mua, thuê xe 
        public double CostBuyCar { get; set; }  // Chi phí mua xe 
        public string CarDealerships { get; set; } = string.Empty;  // Đại lý bán xe    
        public int YearOfManufacture { get; set; }  //Năm sản xuất
    }
}
