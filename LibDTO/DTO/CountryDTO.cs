using LibDTO.DTO.ManyToManyBindersDTOs;
using System.Collections.Generic;

namespace LibDTO.DTO
{
    public class CountryDTO
    {
        public string CountryName { get; set; }
        public virtual ZipCodeDTO ZipCode { get; set; }
        public virtual ICollection<CityCountryDTO> CityCountries { get; set; }
        public CountryDTO()
        {
            CityCountries ??= new HashSet<CityCountryDTO>();
        }
    }
}
