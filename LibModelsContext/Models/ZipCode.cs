using LibModelsContext.Models.ManyToManyBinders;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibModelsContext.Models
{
    public class ZipCode
    {
        public int ZipCodeId { get; set; }
        [Required]
        public string Code { get; set; }
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<CityZipCode> CityZipCodes { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public ZipCode()
        {
            CityZipCodes = new HashSet<CityZipCode>();
            Addresses = new HashSet<Address>();
        }
    }
}
