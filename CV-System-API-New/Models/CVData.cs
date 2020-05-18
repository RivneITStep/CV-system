using CV_System_API_New.Models.CommunicationInfo;
using CV_System_API_New.Models.EducationInfo;
using CV_System_API_New.Models.ExperienceInfo;
using CV_System_API_New.Models.HobbyInfo;
using CV_System_API_New.Models.SkillInfo;

namespace CV_System_API_New.Models
{
    public class CVData
    {
        public int CVDataId { get; set; }
        public virtual Communication Communication { get; set; }
        public virtual Education Education { get; set; }
        public virtual Experience Experience { get; set; }
        public virtual Skill Skill { get; set; }
        public virtual Hobby Hobby { get; set; }
        public virtual CVSystemUser CVSystemUser { get; set; }
    }
}
