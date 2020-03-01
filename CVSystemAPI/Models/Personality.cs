using System;
using System.Collections.Generic;

namespace CVSystemAPI.Models
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
