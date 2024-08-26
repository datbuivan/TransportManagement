using AutoMapper;
using TransportManagement.Data.Dtos;
using TransportManagement.Data.Entities;

namespace TransportManagement.Data.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles() { 
            CreateMap<DriverUser, DriverUserDto>().ReverseMap();
            CreateMap<Truck, TruckDto>().ReverseMap();
            CreateMap<Customer, CustomerDto>().ReverseMap();
            CreateMap<UnitManagement, UnitManagementDto>();
            CreateMap<Contract, ContractDto>().ReverseMap();
            CreateMap<BillingOperate, BillingOperateDto>().ReverseMap();
            CreateMap<TruckRouteDto, TruckRouteDto>().ReverseMap();
            CreateMap<TruckTrip,TruckTripDto>().ReverseMap();
        }
    }
}
