using System;
using System.Collections.Generic;

namespace CVSystemAPI.Models
{
    public partial class Address
    {
        public int AddressId { get; set; }
        public string Street { get; set; }
        public string BuildingNumber { get; set; }
        public string Flat { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public int PersonalId { get; set; }

        public virtual PersonalData Personal { get; set; }
    }
}
