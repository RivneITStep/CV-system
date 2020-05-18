using AutoMapper;
using CV_System_API_New.DTO.ManyToManyBindersDTOs;
using CV_System_API_New.Models.ManyToManyBinders;

namespace CV_System_API_New.Helpers.MapperProfiles.ManyToManyBindersMap
{
    public class CityZipCodeMapperProfile : Profile
    {
        public CityZipCodeMapperProfile()
        {
            CreateMap<CityZipCode, CityZipCodeDTO>()
                .ForMember(d => d.City, o => o.MapFrom(s => s.City))
                .ForMember(d => d.ZipCode, o => o.MapFrom(s => s.ZipCode));

            CreateMap<CityZipCodeDTO, CityZipCode>()
                .ForMember(d => d.City, o => o.MapFrom(s => s.City))
                .ForMember(d => d.ZipCode, o => o.MapFrom(s => s.ZipCode));
        }
    }
}
