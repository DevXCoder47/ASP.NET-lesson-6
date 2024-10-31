using AutoMapper;
using DriversManagement.API.DTOs;
using DriversManagement.API.Models;

namespace DriversManagement.API.AutoMapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Vehicle, VehicleDTO>()
                .ForMember(dest => dest.DriverId, opt => opt.MapFrom(src => src.Driver.Id)).ReverseMap();
        }
    }
}
