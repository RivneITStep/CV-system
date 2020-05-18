using CV_System_API_New.Models.ManyToManyBinders;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CV_System_API_New.Models
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
