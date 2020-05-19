using AutoMapper;
using LibDTO.DTO.SkillDTOs;
using LibModelsContext.Models.SkillInfo;

namespace CV_System_API_New.MapperProfiles.SkillMap
{
    public class SkillProfile : Profile
    {
        public SkillProfile()
        {
            CreateMap<Skill, SkillDTO>()
                .ForMember(d => d.CVData, o => o.Ignore());

            CreateMap<SkillDTO, Skill>()
                .ForMember(d => d.CVData, o => o.Ignore());
        }
    }
}
