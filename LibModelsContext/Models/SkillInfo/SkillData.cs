using System.ComponentModel.DataAnnotations;

namespace LibModelsContext.Models.SkillInfo
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
