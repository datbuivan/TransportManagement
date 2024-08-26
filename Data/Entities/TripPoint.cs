using Microsoft.AspNetCore.Mvc.ViewFeatures;
using TransportManagement.Data.Entities.Cunstom;

namespace TransportManagement.Data.Entities
{
    public class TripPoint : BaseEntities  // Điểm chuyến xe 
    {
        public string Address { get; set; } = string.Empty; // tên địa chỉ
        public double TotalKm { get; set; } // tổng km
        public DateTime PresenceTime { get; set; } // thời gian có mặt
        public int WaitTime { get; set; } // thời gian chờ phút
        public double DistanceTravel { get; set; } // khoảng cách di chuyển km
        public int TravelTime { get; set; } // thời gian di chuyển phút
        public Guid? TruckTripId { get; set; } 
        public TruckTrip TruckTrip { get; set; } = null!;
    }
}
