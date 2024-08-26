using TransportManagement.Data.Entities.Cunstom;

namespace TransportManagement.Data.Entities
{
    public class CustomerGroup : BaseEntities
    {
        public string Name { get; set; } = string.Empty;
        public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
    }
}
