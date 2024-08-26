using System.Reflection.Metadata;
using TransportManagement.Data.Entities.Cunstom;

namespace TransportManagement.Data.Entities
{
    public class DriverUser : BaseEntities // Tài xế
    {
        public string UserName { get; set; } = string.Empty; //  Tên tài khoản
        public string EmployeeCode { get; set; } = string.Empty; // Mã nhân viên
        public string Name { get; set; } = string.Empty; // Tên nhân viên
        public string Address { get; set; } = string.Empty; // Địa chỉ 
        public DateTime DateOfBirth { get; set; }  // Ngày sinh
        public string PhoneNumber { get; set; } = string.Empty; //Số điện thoại
        public string CMND { get; set; } = string.Empty; // Chức minh nhân dân 
        public string Rank { get; set; } = string.Empty; // Hạng bằng
        public string DriverLicense { get; set; } = string.Empty; // Số GPLX
        public string BankName { get; set; } = string.Empty; // Tên ngân hàng
        public string AccountOwner { get; set; } = string.Empty; // Chủ tài khoản
        public string AccountNumber { get; set; } = string.Empty; // Số tài khoản
        public string BankAddress { get; set; } = string.Empty; // Địa chỉ ngân hàng
        public string ManagementUnitName { get; set; } = string.Empty; // Tên đơn vị quản lý
        public string CoordinatorInCharge { get; set; } = string.Empty; // Điều phối phụ trách
        public string Avatar {  get; set; } = string.Empty; // Ảnh đại diện
        public DateTime StudyDate { get; set; } //Ngày học việc
        public DateTime TrialDate { get; set; } // Ngày thử việc
        public DateTime StartDate { get; set; } //  Ngày vào việc
        public DateTime EndDate { get; set; } // Ngày nghỉ việc
        public string FormOfWork { get; set; } = string.Empty; // Hình thức làm việc
        public int Status { get; set; } // Trạng thái
        public DateTime DriverLicenseExpirationDate { get; set; } // Hạn giấy phép lái xe
        public string Note {  get; set; } = string.Empty;
        public string TaxName { get; set; } = string.Empty; // Tên khai thuế
        public string TaxCode { get; set; } = string.Empty; //  Mã khai thuế
        public virtual ICollection<TruckTrip> TruckTrips { get; set; } = new List<TruckTrip>();
        public Guid? UnitManagementId { get; set; } 
        public UnitManagement UnitManagement { get; set; } = null!;
        public virtual ICollection<BillingOperate> BillingOperates { get; set; } = new List<BillingOperate>();
        
    }
}
