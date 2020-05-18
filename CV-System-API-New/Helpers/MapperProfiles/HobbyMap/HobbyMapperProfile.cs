using AutoMapper;
using CV_System_API_New.DTO.HobbyDTOs;
using CV_System_API_New.Models.HobbyInfo;

namespace CV_System_API_New.Helpers.MapperProfiles.HobbyMap
{
    public class HobbyMapperProfile : Profile
    {
        public HobbyMapperProfile()
        {
            CreateMap<Hobby, HobbyDTO>()
                .ForMember(d => d.HobbyDatas, o => o.MapFrom(s => s.HobbyDatas))
                .ForMember(d => d.CVData, o => o.Ignore());

            CreateMap<HobbyDTO, Hobby>()
                .ForMember(d => d.HobbyDatas, o => o.MapFrom(s => s.HobbyDatas))
                .ForMember(d => d.CVData, o => o.Ignore());
        }
    }
}
