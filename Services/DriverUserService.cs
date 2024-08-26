using AutoMapper;
using TransportManagement.Data.Dtos;
using TransportManagement.Data.Entities;
using TransportManagement.Interface;

namespace TransportManagement.Services
{
    public class DriverUserService : IDriverUserService
    {
        private readonly IGenericRepository<DriverUser> _driverUserRepo;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public DriverUserService(IGenericRepository<DriverUser> driverUserRepo, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _driverUserRepo = driverUserRepo;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<DriverUserDto> AddDriverUserAsync(DriverUserDto addDriverUserDto)
        {
            var driverUser = _mapper.Map<Customer>(addDriverUserDto);
            await _unitOfWork.Repository<Customer>().AddAsync(driverUser);
            await _unitOfWork.SaveChangesAsync();
            return _mapper.Map<DriverUserDto>(driverUser);
        }

        public async Task DeleteDriverUserAsync(Guid id)
        {
            var driverUser = await _driverUserRepo.GetByIdAsync(id);
            if (driverUser == null) throw new KeyNotFoundException($"Driver User with id {id} not found.");
            await _unitOfWork.Repository<DriverUser>().DeleteAsync(driverUser);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task EditDriverUserAsync(Guid id, DriverUserDto updateDriverUserDto)
        {
            var existingCustomer = await _driverUserRepo.GetByIdAsync(id);
            if (existingCustomer == null) throw new KeyNotFoundException($"Customer with id {id} not found.");
            var truck = _mapper.Map<Customer>(existingCustomer);
            await _unitOfWork.Repository<Customer>().AddAsync(truck);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<DriverUserDto>> GetAllDriverUserAsync()
        {
            var driverUsers = await _driverUserRepo.ListAllAsync();
            return _mapper.Map<IEnumerable<DriverUserDto>>(driverUsers);
        }

        public async Task<DriverUserDto> GetDriverUserByIdAsync(Guid id)
        {
            var driverUser = await _driverUserRepo.GetByIdAsync(id);
            if (driverUser == null)
            {
                return null;
            }
            return _mapper.Map<DriverUserDto>(driverUser);
        }
    }
}
