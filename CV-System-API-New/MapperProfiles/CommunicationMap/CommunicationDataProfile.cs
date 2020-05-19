using AutoMapper;
using LibDTO.DTO.CommunicationDTOs;
using LibModelsContext.Models.CommunicationInfo;

namespace CV_System_API_New.MapperProfiles.CommunicationMap
{
    public class CommunicationDataProfile : Profile
    {
        public CommunicationDataProfile()
        {
            CreateMap<CommunicationData, CommunicationDataDTO>()
                .ForMember(d => d.Communication, o => o.Ignore());

            CreateMap<CommunicationDataDTO, CommunicationData>()
                .ForMember(d => d.Communication, o => o.Ignore());
        }
    }
}
