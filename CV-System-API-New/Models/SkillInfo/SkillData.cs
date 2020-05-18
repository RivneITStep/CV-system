using System.ComponentModel.DataAnnotations;

namespace CV_System_API_New.Models.SkillInfo
{
    public class SkillData
    {
        public int SkillDataId { get; set; }
        [Required]
        public string SkillDataName { get; set; }
        [Required]
        public string SkillLevel { get; set; }
        public virtual Skill Skill { get; set; }
    }
}
