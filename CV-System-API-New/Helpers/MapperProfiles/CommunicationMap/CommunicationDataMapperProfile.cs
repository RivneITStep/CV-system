using AutoMapper;
using CV_System_API_New.DTO.CommunicationDTOs;
using CV_System_API_New.Models.CommunicationInfo;

namespace CV_System_API_New.Helpers.MapperProfiles.CommunicationMap
{
    public class CommunicationDataMapperProfile : Profile
    {
        public CommunicationDataMapperProfile()
        {
            CreateMap<CommunicationData, CommunicationDataDTO>()
                .ForMember(d => d.CommunicationDataName, o => o.MapFrom(s => s.CommunicationDataName))
                .ForMember(d => d.CommunicationDataContent, o => o.MapFrom(s => s.CommunicationDataContent))
                .ForMember(d => d.Communication, o => o.Ignore());

            CreateMap<CommunicationDataDTO, CommunicationData>()
                .ForMember(d => d.CommunicationDataName, o => o.MapFrom(s => s.CommunicationDataName))
                .ForMember(d => d.CommunicationDataContent, o => o.MapFrom(s => s.CommunicationDataContent))
                .ForMember(d => d.Communication, o => o.Ignore());
        }
    }
}
