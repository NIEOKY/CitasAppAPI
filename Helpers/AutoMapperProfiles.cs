using CitasAppAPI.DTOs;
using CitasAppAPI.Entities;
using CitasAppAPI.Extensions;
using AutoMapper;

namespace CitasAppAPI.Helpers;

public class AutoMapperProfiles : Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<User, MemberDto>()
            .ForMember(dest => dest.PhotoUrl,
                opt => opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url))
            // .ForMember(dest => dest.Age,
            //     opt => opt.MapFrom(src => src.DameLaEdad()));
            .ForMember(dest => dest.Age,
                opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge()));
        CreateMap<Photo, PhotoDto>();
    }
}