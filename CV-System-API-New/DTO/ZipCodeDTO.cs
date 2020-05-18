using CV_System_API_New.DTO.ManyToManyBindersDTOs;
using System.Collections.Generic;

namespace CV_System_API_New.DTO
{
    public class ZipCodeDTO
    {
        public string Code { get; set; }
        public virtual CountryDTO Country { get; set; }
        public virtual ICollection<CityZipCodeDTO> CityZipCodes { get; set; }
        public virtual ICollection<AddressDTO> Addresses { get; set; }
        public ZipCodeDTO()
        {
            CityZipCodes ??= new HashSet<CityZipCodeDTO>();
            Addresses ??= new HashSet<AddressDTO>();
        }
    }
}
