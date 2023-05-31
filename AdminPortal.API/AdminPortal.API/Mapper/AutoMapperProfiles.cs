using AdminPortal.API.DTOs;
using AdminPortal.API.Models;
using AutoMapper;

namespace AdminPortal.API.Mapper;

public class AutoMapperProfiles : Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<Student, StudentDto>()
            .ReverseMap();

        CreateMap<Gender, GenderDto>()
            .ReverseMap();

        CreateMap<Address, AddressDto>()
            .ReverseMap();
    }
}