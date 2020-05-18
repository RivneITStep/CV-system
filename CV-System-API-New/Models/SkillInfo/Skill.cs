using System.Collections.Generic;

namespace CV_System_API_New.Models.SkillInfo
{
    public class Skill
    {
        public int SkillId { get; set; }
        public virtual ICollection<SkillData> SkillDatas { get; set; }
        public int CVDataId { get; set; }
        public virtual CVData CVData { get; set; }
        public Skill()
        {
            SkillDatas = new HashSet<SkillData>();
        }
    }
}
