using AutoMapper;
using LibDTO.DTO;
using LibModelsContext.Models;

namespace CV_System_API_New.MapperProfiles
{
    public class YearRangeProfile : Profile
    {
        public YearRangeProfile()
        {
            CreateMap<YearRange, YearRangeDTO>()
                .ForMember(d => d.EducationData, o => o.Ignore())
                .ForMember(d => d.ExperienceData, o => o.Ignore());

            CreateMap<YearRangeDTO, YearRange>()
                .ForMember(d => d.EducationData, o => o.Ignore())
                .ForMember(d => d.ExperienceData, o => o.Ignore());
        }
    }
}
