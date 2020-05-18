using CV_System_API_New.Models.ManyToManyBinders;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CV_System_API_New.Models
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
