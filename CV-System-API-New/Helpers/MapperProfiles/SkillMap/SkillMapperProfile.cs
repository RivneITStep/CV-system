using AutoMapper;
using LibDTO.DTO.SkillDTOs;
using CV_System_API_New.Models.SkillInfo;

namespace CV_System_API_New.Helpers.MapperProfiles.SkillMap
{
    public class SkillMapperProfile : Profile
    {
        public SkillMapperProfile()
        {
            CreateMap<Skill, SkillDTO>()
                .ForMember(d => d.SkillDatas, o => o.MapFrom(s => s.SkillDatas))
                .ForMember(d => d.CVData, o => o.Ignore());

            CreateMap<SkillDTO, Skill>()
                .ForMember(d => d.SkillDatas, o => o.MapFrom(s => s.SkillDatas))
                .ForMember(d => d.CVData, o => o.Ignore());
        }
    }
}
