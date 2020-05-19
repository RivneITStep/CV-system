using AutoMapper;
using LibDTO.DTO;
using LibModelsContext.Models;

namespace CV_System_API_New.MapperProfiles
{
    public class ZipCodeProfile : Profile
    {
        public ZipCodeProfile()
        {
            CreateMap<ZipCode, ZipCodeDTO>()
                .ForMember(d => d.Addresses, o => o.Ignore())
                .ForMember(d => d.Country, o => o.Ignore());

            CreateMap<ZipCodeDTO, ZipCode>()
                .ForMember(d => d.Addresses, o => o.Ignore())
                .ForMember(d => d.Country, o => o.Ignore());
        }
    }
}
