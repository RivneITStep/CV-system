using AutoMapper;
using LibDTO.DTO.ManyToManyBindersDTOs;
using LibModelsContext.Models.ManyToManyBinders;

namespace CV_System_API_New.Helpers.MapperProfiles.ManyToManyBindersMap
{
    public class AddressPersonalDataMapperProfile : Profile
    {
        public AddressPersonalDataMapperProfile()
        {
            CreateMap<AddressPersonalData, AddressPersonalDataDTO>()
                .ForMember(d => d.Address, o => o.MapFrom(s => s.Address))
                .ForMember(d => d.PersonalData, o => o.MapFrom(s => s.PersonalData));

            CreateMap<AddressPersonalDataDTO, AddressPersonalData>()
                .ForMember(d => d.Address, o => o.MapFrom(s => s.Address))
                .ForMember(d => d.PersonalData, o => o.MapFrom(s => s.PersonalData));
        }
    }
}
