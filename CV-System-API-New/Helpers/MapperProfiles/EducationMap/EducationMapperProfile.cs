using AutoMapper;
using LibDTO.DTO.EducationDTOs;
using CV_System_API_New.Models.EducationInfo;

namespace CV_System_API_New.Helpers.MapperProfiles.EducationMap
{
    public class EducationMapperProfile : Profile
    {
        public EducationMapperProfile()
        {
            CreateMap<Education, EducationDTO>()
                .ForMember(d => d.EducationDatas, o => o.MapFrom(s => s.EducationDatas))
                .ForMember(d => d.CVData, o => o.Ignore());

            CreateMap<EducationDTO, Education>()
                .ForMember(d => d.EducationDatas, o => o.MapFrom(s => s.EducationDatas))
                .ForMember(d => d.CVData, o => o.Ignore());
        }
    }
}
