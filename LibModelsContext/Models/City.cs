using LibModelsContext.Models.ManyToManyBinders;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibModelsContext.Models
{
    public class City
    {
        public int CityId { get; set; }
        [Required]
        public string CityName { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<CityCountry> CityCountries { get; set; }
        public virtual ICollection<CityZipCode> CityZipCodes { get; set; }
        public City()
        {
            Addresses = new HashSet<Address>();
            CityCountries = new HashSet<CityCountry>();
            CityZipCodes = new HashSet<CityZipCode>();
        }
    }
}
