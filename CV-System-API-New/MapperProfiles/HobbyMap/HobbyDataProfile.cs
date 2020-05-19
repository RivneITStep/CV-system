using AutoMapper;
using LibDTO.DTO.HobbyDTOs;
using LibModelsContext.Models.HobbyInfo;

namespace CV_System_API_New.MapperProfiles.HobbyMap
{
    public class HobbyDataProfile : Profile
    {
        public HobbyDataProfile()
        {
            CreateMap<HobbyData, HobbyDataDTO>()
                .ForMember(d => d.Hobby, o => o.Ignore());

            CreateMap<HobbyDataDTO, HobbyData>()
                .ForMember(d => d.Hobby, o => o.Ignore());
        }
    }
}
