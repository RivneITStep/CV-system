using LibDTO.DTO.ManyToManyBindersDTOs;
using System.Collections.Generic;

namespace LibDTO.DTO
{
    public class CityDTO
    {
        public string CityName { get; set; }
        public virtual ICollection<AddressDTO> Addresses { get; set; }
        public virtual ICollection<CityCountryDTO> CityCountries { get; set; }
        public virtual ICollection<CityZipCodeDTO> CityZipCodes { get; set; }
        public CityDTO()
        {
            Addresses ??= new HashSet<AddressDTO>();
            CityCountries ??= new HashSet<CityCountryDTO>();
            CityZipCodes ??= new HashSet<CityZipCodeDTO>();
        }
    }
}
