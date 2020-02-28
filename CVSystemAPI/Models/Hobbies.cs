using System;
using System.Collections.Generic;

namespace API_Real_Base_Test_Own_Context.Models
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
