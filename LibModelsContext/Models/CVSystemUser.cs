using System.Collections.Generic;

namespace LibModelsContext.Models
{
    public class CVSystemUser
    {
        public int CVSystemUserId { get; set; }
        public virtual UserRole UserRole { get; set; }
        public virtual PersonalData PersonalData { get; set; }
        public virtual LoginData LoginData { get; set; }
        public virtual ICollection<CVData> CVDatas { get; set; }
        public CVSystemUser()
        {
            CVDatas = new HashSet<CVData>();
        }
    }
}
