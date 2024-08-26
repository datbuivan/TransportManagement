using System.Reflection.Metadata;
using TransportManagement.Data.Entities.Cunstom;

namespace TransportManagement.Data.Entities
{
    public class PackageShift : BaseEntities    // Gói theo ca
    {
        public string Name { get; set; } = string.Empty;  // tên gói
        public string AssessKm { get; set; } = string.Empty; // định mức km
        public double? ExcessCosts { get; set; }    // phí vượt mức
        public DateTime ActiveTime { get; set; }    // thời gian hoạt động
        public string UnitTime { get; set; } = string.Empty;  // đơn vị thời gian
        public double TotalOperatingExpenses { get; set; } // tổng chi phí hoạt động
        public DateTime ChargeTime { get; set; }    // thời gian tính phí
        public Guid? ContractId { get; set; } 
        public Contract Contract { get; set; } = null!;
        public virtual ICollection<Area> Areas { get; set; } = new List<Area>();

    }
}
