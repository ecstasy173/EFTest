using AutoMapper;
using EFCore.Core.Domain.Entities;
using EFCore.Core.Domain.Dto;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        // ChungTu <-> ChungTuDto
        CreateMap<ChungTu, ChungTuDto>()
            .ForMember(dest => dest.ChungTuChiTiets, opt => opt.MapFrom(src => src.ChungTuChiTiets));
        CreateMap<ChungTuDto, ChungTu>()
            .ForMember(dest => dest.ChungTuChiTiets, opt => opt.MapFrom(src => src.ChungTuChiTiets));

        // ChungTuChiTiet <-> ChungTuChiTietDto
        CreateMap<ChungTuChiTiet, ChungTuChiTietDto>().ReverseMap();
    }
}
