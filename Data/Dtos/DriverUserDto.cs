using System.ComponentModel.DataAnnotations;
using TransportManagement.Data.Entities;

namespace TransportManagement.Data.Dtos
{
    public class DriverUserDto
    {
        public string NameAccount { get; set; } = string.Empty; //  Tên tài khoản
        [Required]
        public string Name { get; set; } = string.Empty; // Tên nhân viên
        [Required]
        public string Address { get; set; } = string.Empty; // Địa chỉ 
        public DateTime? DateOfBirth { get; set; }  // Ngày sinh
        [Required]
        public string PhoneNumber { get; set; } = string.Empty; //Số điện thoại
        [Required]
        public string CMND { get; set; } = string.Empty; // Chức minh nhân dân 
        [Required]
        public string Rank { get; set; } = string.Empty; // Hạng bằng
        [Required]
        public string DriverLicense { get; set; } = string.Empty; // Số GPLX
        [Required]
        public DateTime DriverLicenseExpirationDate { get; set; } // Hạn giấy phép lái xe
        public string BankName { get; set; } = string.Empty; // Tên ngân hàng
        public string AccountOwner { get; set; } = string.Empty; // Chủ tài khoản
        public string AccountNumber { get; set; } = string.Empty; // Số tài khoản
        public string BankAddress { get; set; } = string.Empty; // Địa chỉ ngân hàng
        public string ManagementUnitName { get; set; } = string.Empty; // Tên đơn vị quản lý
        public string CoordinatorInCharge { get; set; } = string.Empty; // Điều phối phụ trách
        public string Avatar { get; set; } = string.Empty; // Ảnh đại diện
        public DateTime? StudyDate { get; set; } //Ngày học việc
        public DateTime? TrialDate { get; set; } // Ngày thử việc
        public DateTime? StartDate { get; set; } //  Ngày vào việc
        public DateTime? EndDate { get; set; } // Ngày nghỉ việc
        public string FormOfWork { get; set; } = string.Empty; // Hình thức làm việc
        public int Status { get; set; } // Trạng thái
        public string Note { get; set; } = string.Empty;
        public string TaxName { get; set; } = string.Empty; // Tên khai thuế
        public string TaxCode { get; set; } = string.Empty; //  Mã khai thuế
        public Guid? UnitManagementId { get; set; }
        public UnitManagement UnitManagement { get; set; } = null!;
        public virtual ICollection<BillingOperate> BillingOperates { get; set; } = new List<BillingOperate>();
    }
}
