using System;
using System.Collections.Generic;

namespace CVSystemAPI.Models
{
    public partial class Skills
    {
        public Skills()
        {
            PersonSoftwareSkill = new HashSet<PersonSoftwareSkill>();
        }

        public int SkillsId { get; set; }
        public string SkillName { get; set; }

        public virtual ICollection<PersonSoftwareSkill> PersonSoftwareSkill { get; set; }
    }
}
