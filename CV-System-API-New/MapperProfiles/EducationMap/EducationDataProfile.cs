using AutoMapper;
using LibDTO.DTO.EducationDTOs;
using LibModelsContext.Models.EducationInfo;

namespace CV_System_API_New.MapperProfiles.EducationMap
{
    public class EducationDataProfile : Profile
    {
        public EducationDataProfile()
        {
            CreateMap<EducationData, EducationDataDTO>()
                .ForMember(d => d.Education, o => o.Ignore());

            CreateMap<EducationDataDTO, EducationData>()
                .ForMember(d => d.Education, o => o.Ignore());
        }
    }
}
