using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Diagnostics;
using TransportManagement.Data.Dtos;
using TransportManagement.Data.Entities;
using TransportManagement.Interface;

namespace TransportManagement.Services
{
    public class TruckService : ITruckService
    {
        private readonly IGenericRepository<Truck> _truckRepo;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public TruckService(IGenericRepository<Truck> truckRepo, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _truckRepo = truckRepo;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TruckDto>> GetAllTruckAsync()
        {
            var trucks = await _truckRepo.ListAllAsync();
            return _mapper.Map<IEnumerable<TruckDto>>(trucks);
        }

        public async Task<TruckDto> GetTruckByIdAsync(Guid id)
        {
            var truck = await _truckRepo.GetByIdAsync(id);
            if (truck == null)
            {
                return null;
            }
            return _mapper.Map<TruckDto>(truck);
        }

        public async Task<TruckDto> AddTruckAsync(TruckDto addTruckDto)
        {
            var truck = _mapper.Map<Truck>(addTruckDto);
            await _unitOfWork.Repository<Truck>().AddAsync(truck);
            await _unitOfWork.SaveChangesAsync();
            return _mapper.Map<TruckDto>(truck);
        }


        public async Task EditTruckAsync(Guid id, TruckDto updateTruckDto)
        {
            var existingTruck = await _truckRepo.GetByIdAsync(id);
            if (existingTruck == null) throw new KeyNotFoundException($"Truck with id {id} not found.");
            var truck = _mapper.Map<Truck>(existingTruck);
            await _unitOfWork.Repository<Truck>().AddAsync(truck);
            await _unitOfWork.SaveChangesAsync();
        }
        public async Task DeleteTruckAsync(Guid id)
        {
            var truck = await _truckRepo.GetByIdAsync(id);
            if (truck == null) throw new KeyNotFoundException($"Truck with id {id} not found.");
            await _unitOfWork.Repository<Truck>().DeleteAsync(truck);
            await _unitOfWork.SaveChangesAsync();
        }

        
    }
}
