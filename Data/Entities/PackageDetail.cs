using TransportManagement.Data.Entities.Cunstom;

namespace TransportManagement.Data.Entities
{
    public class PackageDetail : BaseEntities // Chi tiết gói
    {
        public double Cost { get; set; }    //tên gói
        public double FromKM { get; set; }  // từ km
        public double ToKM { get; set; }    // đến km
        public Guid? PackageDistanceId { get; set; } 
        public PackageByDistance PackageByDistance { get; set; } = null!;
    }
}
