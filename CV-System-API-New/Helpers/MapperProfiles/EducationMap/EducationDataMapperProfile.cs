using AutoMapper;
using LibDTO.DTO.EducationDTOs;
using LibModelsContext.Models.EducationInfo;

namespace CV_System_API_New.Helpers.MapperProfiles.EducationMap
{
    public class EducationDataMapperProfile : Profile
    {
        public EducationDataMapperProfile()
        {
            CreateMap<EducationData, EducationDataDTO>()
                .ForMember(d => d.EducationalInstitution, o => o.MapFrom(s => s.EducationalInstitution))
                .ForMember(d => d.Specialization, o => o.MapFrom(s => s.Specialization))
                .ForMember(d => d.YearRange, o => o.MapFrom(s => s.YearRange))
                .ForMember(d => d.Education, o => o.Ignore());

            CreateMap<EducationDataDTO, EducationData>()
                .ForMember(d => d.EducationalInstitution, o => o.MapFrom(s => s.EducationalInstitution))
                .ForMember(d => d.Specialization, o => o.MapFrom(s => s.Specialization))
                .ForMember(d => d.YearRange, o => o.MapFrom(s => s.YearRange))
                .ForMember(d => d.Education, o => o.Ignore());
        }
    }
}
