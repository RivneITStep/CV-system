using System;

namespace LibDTO.DTO
{
    public class PersonalDataDTO
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public virtual CVSystemUserDTO CVSystemUser { get; set; }
        public virtual GenderDTO Gender { get; set; }
    }
}
