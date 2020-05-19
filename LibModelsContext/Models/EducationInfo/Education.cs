using System.Collections.Generic;

namespace LibModelsContext.Models.EducationInfo
{
    public class Education
    {
        public int EducationId { get; set; }
        public virtual ICollection<EducationData> EducationDatas { get; set; }
        public int CVDataId { get; set; }
        public virtual CVData CVData { get; set; }
        public Education()
        {
            EducationDatas = new HashSet<EducationData>();
        }
    }
}
