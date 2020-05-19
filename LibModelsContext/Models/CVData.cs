using LibModelsContext.Models.CommunicationInfo;
using LibModelsContext.Models.EducationInfo;
using LibModelsContext.Models.ExperienceInfo;
using LibModelsContext.Models.HobbyInfo;
using LibModelsContext.Models.SkillInfo;
using System.ComponentModel.DataAnnotations;

namespace LibModelsContext.Models
{
    public class CVData
    {
        public int CVDataId { get; set; }
        [MaxLength(500)]
        public string BriefInfo { get; set; }
        public virtual Communication Communication { get; set; }
        public virtual Education Education { get; set; }
        public virtual Experience Experience { get; set; }
        public virtual Skill Skill { get; set; }
        public virtual Hobby Hobby { get; set; }
        public virtual CVSystemUser CVSystemUser { get; set; }
    }
}
