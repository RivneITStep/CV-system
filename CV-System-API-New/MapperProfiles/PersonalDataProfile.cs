using AutoMapper;
using LibDTO.DTO;
using LibModelsContext.Models;

namespace CV_System_API_New.MapperProfiles
{
    public class PersonalDataProfile : Profile
    {
        public PersonalDataProfile()
        {
            CreateMap<PersonalData, PersonalDataDTO>()
                .ForMember(d => d.CVSystemUser, o => o.Ignore());

            CreateMap<PersonalDataDTO, PersonalData>()
                .ForMember(d => d.CVSystemUser, o => o.Ignore());
        }
    }
}
