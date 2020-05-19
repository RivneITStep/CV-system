using AutoMapper;
using LibDTO.DTO;
using LibModelsContext.Models;

namespace CV_System_API_New.MapperProfiles
{
    public class CVDataProfile : Profile
    {
        public CVDataProfile()
        {
            CreateMap<CVData, CVDataDTO>()
                .ForMember(d => d.CVSystemUser, o => o.Ignore());

            CreateMap<CVDataDTO, CVData>()
                .ForMember(d => d.CVSystemUser, o => o.Ignore());
        }
    }
}
