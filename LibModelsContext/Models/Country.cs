using LibModelsContext.Models.ManyToManyBinders;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibModelsContext.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        [Required]
        public string CountryName { get; set; }
        public virtual ZipCode ZipCode { get; set; }
        public virtual ICollection<CityCountry> CityCountries { get; set; }
        public Country()
        {
            CityCountries = new HashSet<CityCountry>();
        }
    }
}
