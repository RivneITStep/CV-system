using AutoMapper;
using LibDTO.DTO;
using LibModelsContext.Models;

namespace CV_System_API_New.MapperProfiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<Address, AddressDTO>()
                .ForMember(d => d.City, o => o.Ignore());

            CreateMap<AddressDTO, Address>()
                .ForMember(d => d.City, o => o.Ignore());
        }
    }
}
