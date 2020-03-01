using System;
using System.Collections.Generic;

namespace CVSystemAPI.Models
{
    public partial class PersonHobbies
    {
        public int PersonHobbiesId { get; set; }
        public int HobbyId { get; set; }
        public int PersonalDataId { get; set; }

        public virtual Hobbies Hobby { get; set; }
        public virtual PersonalData PersonalData { get; set; }
    }
}
