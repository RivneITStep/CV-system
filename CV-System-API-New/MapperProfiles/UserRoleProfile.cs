using AutoMapper;
using LibDTO.DTO;
using LibModelsContext.Models;

namespace CV_System_API_New.MapperProfiles
{
    public class UserRoleProfile : Profile
    {
        public UserRoleProfile()
        {
            CreateMap<UserRole, UserRoleDTO>()
                .ForMember(d => d.Users, o => o.Ignore());

            CreateMap<UserRoleDTO, UserRole>()
                .ForMember(d => d.Users, o => o.Ignore());
        }
    }
}
