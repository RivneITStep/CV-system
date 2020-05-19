using LibDTO.DTO.CommunicationDTOs;
using LibDTO.DTO.EducationDTOs;
using LibDTO.DTO.ExperienceDTOs;
using LibDTO.DTO.HobbyDTOs;
using LibDTO.DTO.SkillDTOs;

namespace LibDTO.DTO
{
    public class CVDataDTO
    {
        public string BriefInfo { get; set; }
        public virtual CommunicationDTO Communication { get; set; }
        public virtual EducationDTO Education { get; set; }
        public virtual ExperienceDTO Experience { get; set; }
        public virtual SkillDTO Skill { get; set; }
        public virtual HobbyDTO Hobby { get; set; }
        public virtual CVSystemUserDTO CVSystemUser { get; set; }
    }
}
