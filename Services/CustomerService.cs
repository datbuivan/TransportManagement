using AutoMapper;
using TransportManagement.Data.Dtos;
using TransportManagement.Data.Entities;
using TransportManagement.Interface;

namespace TransportManagement.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IGenericRepository<Customer> _customerRepo;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CustomerService(IGenericRepository<Customer> customerRepo, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _customerRepo = customerRepo;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<CustomerDto> AddCustomerAsync(CustomerDto addCustomerDto)
        {
            var customer = _mapper.Map<Customer>(addCustomerDto);
            await _unitOfWork.Repository<Customer>().AddAsync(customer);
            await _unitOfWork.SaveChangesAsync();
            return _mapper.Map<CustomerDto>(customer);
        }

        public async Task DeleteCustomerAsync(Guid id)
        {
            var customer = await _customerRepo.GetByIdAsync(id);
            if (customer == null) throw new KeyNotFoundException($"Customer with id {id} not found.");
            await _unitOfWork.Repository<Customer>().DeleteAsync(customer);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task EditCustomerAsync(Guid id, CustomerDto updateCustomerDto)
        {
            var existingCustomer = await _customerRepo.GetByIdAsync(id);
            if (existingCustomer == null) throw new KeyNotFoundException($"Customer with id {id} not found.");
            var truck = _mapper.Map<Customer>(existingCustomer);
            await _unitOfWork.Repository<Customer>().AddAsync(truck);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<CustomerDto>> GetAllCustomerAsync()
        {
            var customers = await _customerRepo.ListAllAsync();
            return _mapper.Map<IEnumerable<CustomerDto>>(customers);
        }

        public async Task<CustomerDto> GetCustomerByIdAsync(Guid id)
        {
            var customers = await _customerRepo.GetByIdAsync(id);
            if (customers == null)
            {
                return null;
            }
            return _mapper.Map<CustomerDto>(customers);
        }
    }
}
