using AutoMapper;
using LibDTO.DTO;
using LibModelsContext.Models;

namespace CV_System_API_New.Helpers.MapperProfiles
{
    public class AddressMapperProfile : Profile
    {
        public AddressMapperProfile()
        {
            CreateMap<Address, AddressDTO>()
                .ForMember(d => d.Street, o => o.MapFrom(s => s.Street))
                .ForMember(d => d.HouseNumber, o => o.MapFrom(s => s.HouseNumber))
                .ForMember(d => d.ZipCode, o => o.MapFrom(s => s.ZipCode))
                .ForMember(d => d.AddressPersonalData, o => o.Ignore())
                .ForMember(d => d.City, o => o.Ignore());

            CreateMap<AddressDTO, Address>()
                .ForMember(d => d.Street, o => o.MapFrom(s => s.Street))
                .ForMember(d => d.HouseNumber, o => o.MapFrom(s => s.HouseNumber))
                .ForMember(d => d.ZipCode, o => o.MapFrom(s => s.ZipCode))
                .ForMember(d => d.AddressPersonalData, o => o.Ignore())
                .ForMember(d => d.City, o => o.Ignore());
        }
    }
}
