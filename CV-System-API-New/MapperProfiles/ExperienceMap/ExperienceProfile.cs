using AutoMapper;
using LibDTO.DTO.ExperienceDTOs;
using LibModelsContext.Models.ExperienceInfo;

namespace CV_System_API_New.MapperProfiles.ExperienceMap
{
    public class ExperienceProfile : Profile
    {
        public ExperienceProfile()
        {
            CreateMap<Experience, ExperienceDTO>()
                .ForMember(d => d.CVData, o => o.Ignore());

            CreateMap<ExperienceDTO, Experience>()
                .ForMember(d => d.CVData, o => o.Ignore());
        }
    }
}
