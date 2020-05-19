using System.Collections.Generic;

namespace LibDTO.DTO
{
    public class ZipCodeDTO
    {
        public string Code { get; set; }
        public virtual CountryDTO Country { get; set; }
        public virtual ICollection<AddressDTO> Addresses { get; set; }
        public ZipCodeDTO()
        {
            Addresses ??= new HashSet<AddressDTO>();
        }
    }
}
