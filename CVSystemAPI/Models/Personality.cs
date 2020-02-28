using System;
using System.Collections.Generic;

namespace API_Real_Base_Test_Own_Context.Models
{
    public partial class Personality
    {
        public Personality()
        {
            PersonPersonalities = new HashSet<PersonPersonalities>();
        }

        public int PersonalityId { get; set; }
        public string PersonalityName { get; set; }

        public virtual ICollection<PersonPersonalities> PersonPersonalities { get; set; }
    }
}
