using LibDTO.DTO.EducationDTOs;
using LibDTO.DTO.ExperienceDTOs;

namespace LibDTO.DTO
{
    public class YearRangeDTO
    {
        public int? StartYear { get; set; }
        public int? EndYear { get; set; }
        public virtual ExperienceDataDTO ExperienceData { get; set; }
        public virtual EducationDataDTO EducationData { get; set; }
    }
}
