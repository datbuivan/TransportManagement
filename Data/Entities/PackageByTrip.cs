using System.Reflection.Metadata;
using TransportManagement.Data.Entities.Cunstom;

namespace TransportManagement.Data.Entities
{
    public class PackageByTrip : BaseEntities  // gói theo chuyến
    {
        public string Name { get; set; } = string.Empty;
        public double CostATrip { get; set; }  // chi phí một chuyển
        public DateTime ActiveTime { get; set; }    // thời gian hoạt động
        public double CostOnePoint { get; set; }    // chi phí một điểm
        public string Unit { get; set; } = string.Empty;  // đơn vị thời gian
        public double MinCost { get; set; }   // Chi phí thả điểm tối thiểu
        public DateTime ChargTime { get; set; } // thời gian tính phí
        public string FromPoint { get; set; } = string.Empty;// từ điểm
        public string ToPoint { get; set; } = string.Empty; // đến điểm
        public Guid? ContractId { get; set; }
        public Contract Contract { get; set; } = null!;
        public virtual ICollection<Area> Areas { get; set; } = new List<Area>();    
    }
}
