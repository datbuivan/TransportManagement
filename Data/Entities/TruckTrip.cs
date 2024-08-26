using TransportManagement.Data.Entities.Cunstom;

namespace TransportManagement.Data.Entities
{
    public class TruckTrip : BaseEntities  // Chuyến xe
    {
        public string Name { get; set; } = string.Empty;  // Tên chuyến xe 
        public string Coordinator { get; set; } = string.Empty; // Điều phối 
        public string PartnerId { get; set; } = string.Empty;  //   Mã chuyến đối tác
        public DateTime ActiveTime { get; set; }    // Ngày hoạt động 
        public string HourStart { get; set; } = string.Empty; // Giờ bắt đầu
        public string HourEnd { get; set; } = string.Empty;  // Giờ kết thúc
        public string DriverCharge { get; set; } = string.Empty; // Tài xế phụ trách
        public string RarCarCharge { get; set; } = string.Empty; // Xe tải phụ trách
        public string AssistantDriverCharge { get; set; } = string.Empty; // Laí phụ phụ trách
        public double TotalDistance { get; set; } // Tổng quãng đường
        public double ChargeKm { get; set; } // Số km tính phí
        public double ActualKm { get; set; } // Số km thực tế 
        public double Toll { get; set; }   //  Phí cầu đường
        public double OvertimeFee { get; set; } //  Phí ngoài giờ 
        public double ContainerFreightStationFee { get; set; } // Phí bốc xếp
        public double Mass { get; set; }   //  Khối lượng tính phí bốc xếp
        public double TotalCost { get; set; } //    Tổng chi phí vận hành 
        public double DriverSalary { get; set; } // Lương tài xế 
        public double AssistantDriverSalary { get; set; } // Lương lái phụ
        public double TotalOrdereceived { get; set; } // Tổng đơn hàng cần lấy 
        public double TotalOrderDelivered { get; set; } // Tổng đơn hàng cần giao
        public double TotalOrderDeliveredSuccess { get; set; } // Tổng đơn hàng giao thành công 
        public double TotalOrderRefunded { get; set; }  //  Tổng đơn hàng cần hoàn
        public double TotalOrdeCompleted { get; set; }  //  Tổng đơn hàng đã hoàn
        public double TotalNeedCOD { get; set; } // Tổng tiền cần thu hộ COD
        public double TotalCollectedCOD { get; set; } // Tổng tiền đã thu hộ COD
        public double TotalDriverPaid { get; set; } // Tổng tiền tài xế cần nộp
        public DateTime PaymentDuaDate { get; set; } // Thời hạn tài xế nộp tiền
        public int Status { get; set; } // Trạng thái tài xế nộp tiền
        public string CheckInside { get; set; } = string.Empty;
        public double UnmanagedExpense { get; set; } // Chi phí phát sinh
        public double Bonus { get; set; } // Thưởng chất lượng
        public double Fine { get; set; } // Phạt chất lượng
        public double Tolls { get; set; } // Phí cầu đường Vh
        public double OperatingFeesArise { get; set; } // Phí vận hành phát sinh
        public double DriverReward { get; set; }    //  Thưởng tài xế
        public double DriverFine { get; set; }  //  Phạt tài xế
        public double AssistantDriverReward { get; set; } // Thưởng lái phụ 
        public double AssistantDriverFine { get; set; } //  Phạt lái phụ 
        public double GasolineExpense { get; set; } //  Phí xăng dầu
        public virtual ICollection<TripPoint> TripPoints { get; set; } = new List<TripPoint>();
        public Guid? RouteId { get; set; } 
        public TruckRoute Route { get; set; } = null!;
        public Guid? DiverUserId { get; set; } 
        public DriverUser DriverUser { get; set; } = null!;
        public Guid? TrunkId { get; set; } 
        public Truck Trunk { get; set; } = null!;
        public virtual ICollection<BillingOperate> BillingOperates { get; set; } = new List<BillingOperate>();
    }
}
