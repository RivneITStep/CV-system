using System;
using System.Collections.Generic;

namespace CVSystemAPI.Models
{
    public partial class PersonSoftwareSkill
    {
        public int PersonSoftwareSkillId { get; set; }
        public int SoftwareSkillLevel { get; set; }
        public int SkillId { get; set; }
        public int PersonalDataId { get; set; }

        public virtual PersonalData PersonalData { get; set; }
        public virtual Skills Skill { get; set; }
    }
}
