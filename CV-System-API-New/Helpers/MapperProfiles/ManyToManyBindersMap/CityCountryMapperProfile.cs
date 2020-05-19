using AutoMapper;
using LibDTO.DTO.ManyToManyBindersDTOs;
using LibModelsContext.Models.ManyToManyBinders;

namespace CV_System_API_New.Helpers.MapperProfiles.ManyToManyBindersMap
{
    public class CityCountryMapperProfile : Profile
    {
        public CityCountryMapperProfile()
        {
            CreateMap<CityCountry, CityCountryDTO>()
                .ForMember(d => d.City, o => o.MapFrom(s => s.City))
                .ForMember(d => d.Country, o => o.MapFrom(s => s.Country));

            CreateMap<CityCountryDTO, CityCountry>()
                .ForMember(d => d.City, o => o.MapFrom(s => s.City))
                .ForMember(d => d.Country, o => o.MapFrom(s => s.Country));
        }
    }
}
