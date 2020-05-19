using LibModelsContext.Models.ManyToManyBinders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibModelsContext.Models
{
    public class PersonalData
    {
        public int PersonalDataId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string SecondName { get; set; }
        [Required]
        public string MiddleName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        public virtual ICollection<AddressPersonalData> AddressPersonalData { get; set; }
        public int CVSystemUserId { get; set; }
        public virtual CVSystemUser CVSystemUser { get; set; }
        public virtual Gender Gender { get; set; }
        public PersonalData()
        {
            AddressPersonalData = new HashSet<AddressPersonalData>();
        }
    }
}
