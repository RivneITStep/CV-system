using AutoMapper;
using LibDTO.DTO;
using LibModelsContext.Models;

namespace CV_System_API_New.MapperProfiles
{
    public class GenderProfile : Profile
    {
        public GenderProfile()
        {
            CreateMap<Gender, GenderDTO>()
                .ForMember(d => d.PersonalDatas, o => o.Ignore());

            CreateMap<GenderDTO, Gender>()
                .ForMember(d => d.PersonalDatas, o => o.Ignore());
        }
    }
}
