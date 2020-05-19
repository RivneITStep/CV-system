using AutoMapper;
using LibDTO.DTO.CommunicationDTOs;
using LibModelsContext.Models.CommunicationInfo;

namespace CV_System_API_New.MapperProfiles.CommunicationMap
{
    public class CommunicationProfile : Profile
    {
        public CommunicationProfile()
        {
            CreateMap<Communication, CommunicationDTO>()
                .ForMember(d => d.CVData, o => o.Ignore());

            CreateMap<CommunicationDTO, Communication>()
                .ForMember(d => d.CVData, o => o.Ignore());
        }
    }
}
