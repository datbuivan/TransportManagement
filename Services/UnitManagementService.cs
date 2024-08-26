using AutoMapper;
using TransportManagement.Data.Dtos;
using TransportManagement.Data.Entities;
using TransportManagement.Interface;

namespace TransportManagement.Services
{
    public class UnitManagementService : IUnitManagementService
    {
        private readonly IGenericRepository<UnitManagement> _unitManagementRepo;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public UnitManagementService(IGenericRepository<UnitManagement> unitManagementRepo, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitManagementRepo = unitManagementRepo;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UnitManagementDto>> GetAllUnitManagementAsync()
        {
            var unitManagements = await _unitManagementRepo.ListAllAsync();
            return _mapper.Map<IEnumerable<UnitManagementDto>>(unitManagements);
        }

        public async Task<UnitManagementDto> GetUnitManagementByIdAsync(Guid id)
        {
            var unitManagement = await _unitManagementRepo.GetByIdAsync(id);
            if (unitManagement == null)
            {
                return null;
            }
            return _mapper.Map<UnitManagementDto>(unitManagement);
        }

        public async Task<UnitManagementDto> AddUnitManagementAsync(UnitManagementDto addUnitManagementDto)
        {
            var unitManagement = _mapper.Map<UnitManagement>(addUnitManagementDto);
            await _unitOfWork.Repository<UnitManagement>().AddAsync(unitManagement);
            await _unitOfWork.SaveChangesAsync();
            return _mapper.Map<UnitManagementDto>(unitManagement);
        }


        public async Task EditUnitManagementAsync(Guid id, UnitManagementDto updateUnitManagementDto)
        {
            var existingUnitManagement = await _unitManagementRepo.GetByIdAsync(id);
            if (existingUnitManagement == null) throw new KeyNotFoundException($"UnitManagement with id {id} not found.");
            var unitManagement = _mapper.Map<UnitManagement>(existingUnitManagement);
            await _unitOfWork.Repository<UnitManagement>().AddAsync(unitManagement);
            await _unitOfWork.SaveChangesAsync();
        }
        public async Task DeleteUnitManagementAsync(Guid id)
        {
            var unitManagement = await _unitManagementRepo.GetByIdAsync(id);
            if (unitManagement == null) throw new KeyNotFoundException($"UnitManagement with id {id} not found.");
            await _unitOfWork.Repository<UnitManagement>().DeleteAsync(unitManagement);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
