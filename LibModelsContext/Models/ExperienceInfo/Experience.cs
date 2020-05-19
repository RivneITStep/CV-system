using System.Collections.Generic;

namespace LibModelsContext.Models.ExperienceInfo
{
    public class Experience
    {
        public int ExperienceId { get; set; }
        public virtual ICollection<ExperienceData> ExperienceDatas { get; set; }
        public int CVDataId { get; set; }
        public virtual CVData CVData { get; set; }
        public Experience()
        {
            ExperienceDatas = new HashSet<ExperienceData>();
        }
    }
}
