using System;
using System.Collections.Generic;

namespace CVSystemAPI.Models
{
    public partial class PersonalData
    {
        public PersonalData()
        {
            Address = new HashSet<Address>();
            Communication = new HashSet<Communication>();
            Education = new HashSet<Education>();
            Experience = new HashSet<Experience>();
            HrData = new HashSet<HrData>();
            LoginCvBinder = new HashSet<LoginCvBinder>();
            PersonHobbies = new HashSet<PersonHobbies>();
            PersonLanguages = new HashSet<PersonLanguages>();
            PersonPersonalities = new HashSet<PersonPersonalities>();
            PersonSoftwareSkill = new HashSet<PersonSoftwareSkill>();
            PersonTrainings = new HashSet<PersonTrainings>();
            SocialNetworks = new HashSet<SocialNetworks>();
        }

        public int PersonalId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<Communication> Communication { get; set; }
        public virtual ICollection<Education> Education { get; set; }
        public virtual ICollection<Experience> Experience { get; set; }
        public virtual ICollection<HrData> HrData { get; set; }
        public virtual ICollection<LoginCvBinder> LoginCvBinder { get; set; }
        public virtual ICollection<PersonHobbies> PersonHobbies { get; set; }
        public virtual ICollection<PersonLanguages> PersonLanguages { get; set; }
        public virtual ICollection<PersonPersonalities> PersonPersonalities { get; set; }
        public virtual ICollection<PersonSoftwareSkill> PersonSoftwareSkill { get; set; }
        public virtual ICollection<PersonTrainings> PersonTrainings { get; set; }
        public virtual ICollection<SocialNetworks> SocialNetworks { get; set; }
    }
}
