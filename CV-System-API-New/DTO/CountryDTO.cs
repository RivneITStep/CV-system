using CV_System_API_New.DTO.ManyToManyBindersDTOs;
using System.Collections.Generic;

namespace CV_System_API_New.DTO
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
