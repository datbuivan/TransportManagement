using TransportManagement.Data.Entities.Cunstom;

namespace TransportManagement.Data.Entities
{
    public class User : BaseEntities   // Người dùng
    {
        public string Name { get; set; } = string.Empty; //  Tên người dùng
        public string Account { get; set; } = string.Empty;   // Tài khoản
        public string Password { get; set; } = string.Empty; //Mật khẩu
        public Guid? RoleId { get; set; }
        public Role Role { get; set; } = null!;
    }
}
