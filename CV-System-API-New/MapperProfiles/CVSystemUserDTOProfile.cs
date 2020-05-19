using AutoMapper;
using LibDTO.DTO;
using LibModelsContext.Models;

namespace CV_System_API_New.MapperProfiles
{
    public class CVSystemUserDTOProfile : Profile
    {
        public CVSystemUserDTOProfile()
        {
            CreateMap<CVSystemUser, CVSystemUserDTO>()
                .ForMember(d => d.LoginData, o => o.Ignore());

            CreateMap<CVSystemUserDTO, CVSystemUser>()
                .ForMember(d => d.LoginData, o => o.Ignore());
        }
    }
}
