using TransportManagement.Data.Entities.Cunstom;

namespace TransportManagement.Data.Entities
{
    public class PackageByDistance : BaseEntities  // Gói theo quãng đường
    {
        public string Name { get; set; } = string.Empty;  // tên gói
        public string TypeFixedCost { get; set; } = string.Empty;  // loại chi phí cố định
        public double FixedCost { get; set; }   // chi phí cố định
        public Guid? ContractId { get; set; } 
        public Contract Contract { get; set; } = null!;
        public virtual ICollection<Area> Areas { get; set; } = new List<Area>();
        public virtual ICollection<PackageDetail> PackageDetails { get; set; } = null!;

    }
}
