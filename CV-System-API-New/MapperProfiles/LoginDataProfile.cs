using AutoMapper;
using LibDTO.DTO;
using LibModelsContext.Models;

namespace CV_System_API_New.MapperProfiles
{
    public class LoginDataProfile : Profile
    {
        public LoginDataProfile()
        {
            CreateMap<LoginData, LoginDataDTO>()
                .ForMember(d => d.CVSystemUser, o => o.MapFrom(s => s.CVSystemUser))
                .ForMember(d => d.Email, o => o.MapFrom(s => s.Email))
                .ForMember(d => d.UserName, o => o.MapFrom(s => s.UserName));

            CreateMap<LoginDataDTO, LoginData>()
                .ForMember(d => d.CVSystemUser, o => o.MapFrom(s => s.CVSystemUser))
                .ForMember(d => d.Email, o => o.MapFrom(s => s.Email))
                .ForMember(d => d.PasswordHash, o => o.MapFrom(s => s.PasswordHash));
        }
    }
}
