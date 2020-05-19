using LibModelsContext.Models.EducationInfo;
using LibModelsContext.Models.ExperienceInfo;

namespace LibModelsContext.Models
{
    public class YearRange
    {
        public int YearRangeId { get; set; }
        public int? StartYear { get; set; }
        public int? EndYear { get; set; }
        public virtual ExperienceData ExperienceData { get; set; }
        public virtual EducationData EducationData { get; set; }
    }
}
