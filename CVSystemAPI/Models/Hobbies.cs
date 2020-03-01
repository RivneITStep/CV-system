using System;
using System.Collections.Generic;

namespace CVSystemAPI.Models
{
    public partial class Hobbies
    {
        public Hobbies()
        {
            PersonHobbies = new HashSet<PersonHobbies>();
        }

        public int HobbyId { get; set; }
        public string HobbyName { get; set; }

        public virtual ICollection<PersonHobbies> PersonHobbies { get; set; }
    }
}
