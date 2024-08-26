using TransportManagement.Data.Dtos;

namespace TransportManagement.Interface
{
    public interface ICustomerService
    {
        Task<CustomerDto> AddCustomerAsync(CustomerDto addCustomerDto);
        Task<IEnumerable<CustomerDto>> GetAllCustomerAsync();
        Task<CustomerDto> GetCustomerByIdAsync(Guid id);
        Task EditCustomerAsync(Guid id, CustomerDto updateCustomerDto);
        Task DeleteCustomerAsync(Guid id);
    }
}
