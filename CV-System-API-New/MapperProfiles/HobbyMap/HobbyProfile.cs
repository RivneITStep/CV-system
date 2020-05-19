using AutoMapper;
using LibDTO.DTO.HobbyDTOs;
using LibModelsContext.Models.HobbyInfo;

namespace CV_System_API_New.MapperProfiles.HobbyMap
{
    public class HobbyProfile : Profile
    {
        public HobbyProfile()
        {
            CreateMap<Hobby, HobbyDTO>()
                .ForMember(d => d.CVData, o => o.Ignore());

            CreateMap<HobbyDTO, Hobby>()
                .ForMember(d => d.CVData, o => o.Ignore());
        }
    }
}
