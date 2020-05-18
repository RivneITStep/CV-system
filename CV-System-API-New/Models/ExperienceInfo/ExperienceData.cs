using System.ComponentModel.DataAnnotations;

namespace CV_System_API_New.Models.ExperienceInfo
{
    public class ExperienceData
    {
        public int ExperienceDataId { get; set; }
        [Required]
        public string PlaceName { get; set; }
        public int YearRangeId { get; set; }
        public virtual YearRange YearRange { get; set; }
        public virtual Experience Experience { get; set; }
    }
}
