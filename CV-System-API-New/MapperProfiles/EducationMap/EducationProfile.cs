using AutoMapper;
using LibDTO.DTO.EducationDTOs;
using LibModelsContext.Models.EducationInfo;

namespace CV_System_API_New.MapperProfiles.EducationMap
{
    public class EducationProfile : Profile
    {
        public EducationProfile()
        {
            CreateMap<Education, EducationDTO>()
                .ForMember(d => d.CVData, o => o.Ignore());

            CreateMap<EducationDTO, Education>()
                .ForMember(d => d.CVData, o => o.Ignore());
        }
    }
}
