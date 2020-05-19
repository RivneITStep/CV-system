using System.Collections.Generic;

namespace LibDTO.DTO.ExperienceDTOs
{
    public class ExperienceDTO
    {
        public virtual ICollection<ExperienceDataDTO> ExperienceDatas { get; set; }
        public virtual CVDataDTO CVData { get; set; }
        public ExperienceDTO()
        {
            ExperienceDatas ??= new HashSet<ExperienceDataDTO>();
        }
    }
}
