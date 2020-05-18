using System.Collections.Generic;

namespace CV_System_API_New.Models.HobbyInfo
{
    public class Hobby
    {
        public int HobbyId { get; set; }
        public virtual ICollection<HobbyData> HobbyDatas { get; set; }
        public int CVDataId { get; set; }
        public virtual CVData CVData { get; set; }
        public Hobby()
        {
            HobbyDatas = new HashSet<HobbyData>();
        }
    }
}
