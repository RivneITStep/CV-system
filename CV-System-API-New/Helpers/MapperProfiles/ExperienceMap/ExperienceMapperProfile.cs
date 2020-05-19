using AutoMapper;
using LibDTO.DTO.ExperienceDTOs;
using LibModelsContext.Models.ExperienceInfo;

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
