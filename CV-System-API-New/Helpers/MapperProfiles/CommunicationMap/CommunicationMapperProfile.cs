using AutoMapper;
using LibDTO.DTO.CommunicationDTOs;
using LibModelsContext.Models.CommunicationInfo;

namespace CV_System_API_New.Helpers.MapperProfiles.CommunicationMap
{
    public class CommunicationMapperProfile : Profile
    {
        public CommunicationMapperProfile()
        {
            CreateMap<Communication, CommunicationDTO>()
                .ForMember(d => d.CommunicationDatas, o => o.MapFrom(s => s.CommunicationDatas))
                .ForMember(d => d.CVData, o => o.Ignore());

            CreateMap<CommunicationDTO, Communication>()
                .ForMember(d => d.CommunicationDatas, o => o.MapFrom(s => s.CommunicationDatas))
                .ForMember(d => d.CVData, o => o.Ignore());
        }
    }
}
