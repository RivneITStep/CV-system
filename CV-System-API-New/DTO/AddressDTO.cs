using CV_System_API_New.DTO.ManyToManyBindersDTOs;
using System.Collections.Generic;

namespace CV_System_API_New.DTO
{
    public class AddressDTO
    {
        public string Street { get; set; }
        public int? HouseNumber { get; set; }
        public virtual CityDTO City { get; set; }
        public virtual ZipCodeDTO ZipCode { get; set; }
        public virtual ICollection<AddressPersonalDataDTO> AddressPersonalData { get; set; }
        public AddressDTO()
        {
            AddressPersonalData ??= new HashSet<AddressPersonalDataDTO>();
        }
    }
}
