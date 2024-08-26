using TransportManagement.Data.Dtos;

namespace TransportManagement.Interface
{
    public interface IUnitManagementService
    {
        Task<UnitManagementDto> AddUnitManagementAsync(UnitManagementDto addUnitManagementDto);
        Task<IEnumerable<UnitManagementDto>> GetAllUnitManagementAsync();
        Task<UnitManagementDto> GetUnitManagementByIdAsync(Guid id);
        Task EditUnitManagementAsync(Guid id, UnitManagementDto updateUnitManagementDto);
        Task DeleteUnitManagementAsync(Guid id);
    }
}
