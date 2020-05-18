using CV_System_API_New.DTO.EducationDTOs;
using CV_System_API_New.DTO.ExperienceDTOs;

namespace CV_System_API_New.DTO
{
    public class YearRangeDTO
    {
        public int? StartYear { get; set; }
        public int? EndYear { get; set; }
        public virtual ExperienceDataDTO ExperienceData { get; set; }
        public virtual EducationDataDTO EducationData { get; set; }
    }
}
