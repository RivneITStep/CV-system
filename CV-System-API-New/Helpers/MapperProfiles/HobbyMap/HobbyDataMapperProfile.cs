using AutoMapper;
using CV_System_API_New.DTO.HobbyDTOs;
using CV_System_API_New.Models.HobbyInfo;

namespace CV_System_API_New.Helpers.MapperProfiles.HobbyMap
{
    public class HobbyDataMapperProfile : Profile
    {
        public HobbyDataMapperProfile()
        {
            CreateMap<HobbyData, HobbyDataDTO>()
                .ForMember(d => d.HobbyName, o => o.MapFrom(s => s.HobbyName))
                .ForMember(d => d.Hobby, o => o.Ignore());

            CreateMap<HobbyDataDTO, HobbyData>()
                .ForMember(d => d.HobbyName, o => o.MapFrom(s => s.HobbyName))
                .ForMember(d => d.Hobby, o => o.Ignore());
        }
    }
}
