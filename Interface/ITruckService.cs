using TransportManagement.Data.Dtos;
using TransportManagement.Data.Entities;

namespace TransportManagement.Interface
{
    public interface ITruckService
    {
        Task<TruckDto> AddTruckAsync(TruckDto addTruckDto);
        Task<IEnumerable<TruckDto>> GetAllTruckAsync();
        Task<TruckDto> GetTruckByIdAsync(Guid id);
        Task EditTruckAsync(Guid id, TruckDto updateTruckDto);
        Task DeleteTruckAsync(Guid id);
    }
}
