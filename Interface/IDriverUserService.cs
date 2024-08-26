using TransportManagement.Data.Dtos;

namespace TransportManagement.Interface
{
    public interface IDriverUserService
    {
        Task<DriverUserDto> AddDriverUserAsync(DriverUserDto addDriverUserDto);
        Task<IEnumerable<DriverUserDto>> GetAllDriverUserAsync();
        Task<DriverUserDto> GetDriverUserByIdAsync(Guid id);
        Task EditDriverUserAsync(Guid id, DriverUserDto updateDriverUserDto);
        Task DeleteDriverUserAsync(Guid id);
    }
}
