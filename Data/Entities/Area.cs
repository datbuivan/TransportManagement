using TransportManagement.Data.Entities.Cunstom;

namespace TransportManagement.Data.Entities
{
    public class Area : BaseEntities // Khu vực
    {
        public string Name { get; set; } = string.Empty;   //Tên Khu Vực
        public Guid PackageByDistanceId { get; set; } 
        public Guid PackageByTripId { get; set; } 
        public Guid? PackageByShiftId { get; set; } 
        public PackageByDistance PackageByDistance { get; set; } = null!;
        public PackageByTrip PackageByTrip { get; set; } = null!;
        public PackageShift PackageShift { get; set; } = null!;

    }
}
