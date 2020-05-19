using AutoMapper;
using LibDTO.DTO.ExperienceDTOs;
using LibModelsContext.Models.ExperienceInfo;

namespace CV_System_API_New.MapperProfiles.ExperienceMap
{
    public class ExperienceDataProfile : Profile
    {
        public ExperienceDataProfile()
        {
            CreateMap<ExperienceData, ExperienceDataDTO>()
                .ForMember(d => d.Experience, o => o.Ignore());

            CreateMap<ExperienceDataDTO, ExperienceData>()
                .ForMember(d => d.Experience, o => o.Ignore());
        }
    }
}
