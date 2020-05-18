using CV_System_API_New.Models.EducationInfo;
using CV_System_API_New.Models.ExperienceInfo;

namespace CV_System_API_New.Models
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
