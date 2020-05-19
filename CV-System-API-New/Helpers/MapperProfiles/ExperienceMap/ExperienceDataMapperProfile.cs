using AutoMapper;
using LibDTO.DTO.ExperienceDTOs;
using LibModelsContext.Models.ExperienceInfo;

namespace CV_System_API_New.Helpers.MapperProfiles.ExperienceMap
{
    public class ExperienceDataMapperProfile : Profile
    {
        public ExperienceDataMapperProfile()
        {
            CreateMap<ExperienceData, ExperienceDataDTO>()
                .ForMember(d => d.PlaceName, o => o.MapFrom(s => s.PlaceName))
                .ForMember(d => d.YearRange, o => o.MapFrom(s => s.YearRange))
                .ForMember(d => d.Experience, o => o.Ignore());

            CreateMap<ExperienceDataDTO, ExperienceData>()
                .ForMember(d => d.PlaceName, o => o.MapFrom(s => s.PlaceName))
                .ForMember(d => d.YearRange, o => o.MapFrom(s => s.YearRange))
                .ForMember(d => d.Experience, o => o.Ignore());
        }
    }
}
