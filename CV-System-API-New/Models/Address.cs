using CV_System_API_New.Models.ManyToManyBinders;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CV_System_API_New.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        [Required]
        public string Street { get; set; }
        public int? HouseNumber { get; set; }
        public virtual City City { get; set; }
        public virtual ZipCode ZipCode { get; set; }
        public virtual ICollection<AddressPersonalData> AddressPersonalData { get; set; }
        public Address()
        {
            AddressPersonalData = new HashSet<AddressPersonalData>();
        }
    }
}
