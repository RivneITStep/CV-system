using System.Collections.Generic;

namespace LibDTO.DTO
{
    public class CityDTO
    {
        public string CityName { get; set; }
        public virtual ICollection<AddressDTO> Addresses { get; set; }
        public CityDTO()
        {
            Addresses ??= new HashSet<AddressDTO>();
        }
    }
}
