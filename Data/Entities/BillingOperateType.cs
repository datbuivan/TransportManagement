using TransportManagement.Data.Entities.Cunstom;

namespace TransportManagement.Data.Entities
{
    public class BillingOperateType : BaseEntities  // Loại phiếu thu chi
    {
        public string Name { get; set; } = string.Empty; // Tên loại
        public string TypeObject { get; set; } = string.Empty; // Loại đối tượng
        public string GroupReceiver { get; set; } = string.Empty; //Nhóm người nhận 
        public string Receiver { get; set; } = string.Empty; // Nguời nhận
        public string GroupPayer { get; set; } = string.Empty; // Nhóm người trả
        public string Payer { get; set; } = string.Empty; // Người trả
        public virtual ICollection<BillingOperate> BillingOperate { get; set; } = new List<BillingOperate>();
    }
}
