using System.Collections.Generic;

namespace CV_System_API_New.DTO.SkillDTOs
{
    public class SkillDTO
    {
        public virtual ICollection<SkillDataDTO> SkillDatas { get; set; }
        public virtual CVDataDTO CVData { get; set; }
        public SkillDTO()
        {
            SkillDatas ??= new HashSet<SkillDataDTO>();
        }
    }
}
