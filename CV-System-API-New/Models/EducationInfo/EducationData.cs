using System.ComponentModel.DataAnnotations;

namespace CV_System_API_New.Models.EducationInfo
{
    public class EducationData
    {
        public int EducationDataId { get; set; }
        [Required]
        public string EducationalInstitution { get; set; }
        [Required]
        public string Specialization { get; set; }
        public int YearRangeId { get; set; }
        public virtual YearRange YearRange { get; set; }
        public virtual Education Education { get; set; }
    }
}
