using System;
using System.Collections.Generic;

namespace API_Real_Base_Test_Own_Context.Models
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
