using TransportManagement.Data.Entities.Cunstom;

namespace TransportManagement.Data.Entities
{
    public class Role : BaseEntities   //  Vai trò
    {
        public string Name { get; set; } = string.Empty; //  Tên vai trò 
        public virtual ICollection<User> Users { get; } = new List<User>();
    }
}
