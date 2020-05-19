using AutoMapper;
using LibDTO.DTO.SkillDTOs;
using LibModelsContext.Models.SkillInfo;

namespace CV_System_API_New.MapperProfiles.SkillMap
{
    public class SkillDataProfile : Profile
    {
        public SkillDataProfile()
        {
            CreateMap<SkillData, SkillDataDTO>()
                .ForMember(d => d.Skill, o => o.Ignore());

            CreateMap<SkillDataDTO, SkillData>()
                .ForMember(d => d.Skill, o => o.Ignore());
        }
    }
}
