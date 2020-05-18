﻿using AutoMapper;
using CV_System_API_New.DTO.SkillDTOs;
using CV_System_API_New.Models.SkillInfo;

namespace CV_System_API_New.Helpers.MapperProfiles.SkillMap
{
    public class SkillDataMapperProfile : Profile
    {
        public SkillDataMapperProfile()
        {
            CreateMap<SkillData, SkillDataDTO>()
                .ForMember(d => d.SkillDataName, o => o.MapFrom(s => s.SkillDataName))
                .ForMember(d => d.SkillLevel, o => o.MapFrom(s => s.SkillLevel))
                .ForMember(d => d.Skill, o => o.Ignore());

            CreateMap<SkillDataDTO, SkillData>()
                .ForMember(d => d.SkillDataName, o => o.MapFrom(s => s.SkillDataName))
                .ForMember(d => d.SkillLevel, o => o.MapFrom(s => s.SkillLevel))
                .ForMember(d => d.Skill, o => o.Ignore());
        }
    }
}
