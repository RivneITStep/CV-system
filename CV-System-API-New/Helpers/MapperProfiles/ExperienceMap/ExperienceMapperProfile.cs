using AutoMapper;
using CV_System_API_New.DTO.ExperienceDTOs;
using CV_System_API_New.Models.ExperienceInfo;

namespace CV_System_API_New.Helpers.MapperProfiles.ExperienceMap
{
    public class ExperienceMapperProfile : Profile
    {
        public ExperienceMapperProfile()
        {
            CreateMap<Experience, ExperienceDTO>()
                .ForMember(d => d.ExperienceDatas, o => o.MapFrom(s => s.ExperienceDatas))
                .ForMember(d => d.CVData, o => o.Ignore());

            CreateMap<ExperienceDTO, Experience>()
                .ForMember(d => d.ExperienceDatas, o => o.MapFrom(s => s.ExperienceDatas))
                .ForMember(d => d.CVData, o => o.Ignore());
        }
    }
}
