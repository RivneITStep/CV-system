using CV_System_API_New.DTO.CommunicationDTOs;
using CV_System_API_New.DTO.EducationDTOs;
using CV_System_API_New.DTO.ExperienceDTOs;
using CV_System_API_New.DTO.HobbyDTOs;
using CV_System_API_New.DTO.SkillDTOs;

namespace CV_System_API_New.DTO
{
    public class CVDataDTO
    {
        public virtual CommunicationDTO Communication { get; set; }
        public virtual EducationDTO Education { get; set; }
        public virtual ExperienceDTO Experience { get; set; }
        public virtual SkillDTO Skill { get; set; }
        public virtual HobbyDTO Hobby { get; set; }
        public virtual CVSystemUserDTO CVSystemUser { get; set; }
    }
}
