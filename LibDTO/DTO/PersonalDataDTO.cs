using LibDTO.DTO.ManyToManyBindersDTOs;
using System;
using System.Collections.Generic;

namespace LibDTO.DTO
{
    public class PersonalDataDTO
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public virtual ICollection<AddressPersonalDataDTO> AddressPersonalData { get; set; }
        public virtual CVSystemUserDTO CVSystemUser { get; set; }
        public virtual GenderDTO Gender { get; set; }
        public PersonalDataDTO()
        {
            AddressPersonalData ??= new HashSet<AddressPersonalDataDTO>();
        }
    }
}
