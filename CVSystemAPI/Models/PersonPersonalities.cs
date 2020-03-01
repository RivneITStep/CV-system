using System;
using System.Collections.Generic;

namespace CVSystemAPI.Models
{
    public partial class PersonPersonalities
    {
        public int PersonPersonalitiesId { get; set; }
        public int PersonalityId { get; set; }
        public int PersonalDataId { get; set; }

        public virtual PersonalData PersonalData { get; set; }
        public virtual Personality Personality { get; set; }
    }
}
