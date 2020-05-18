using System.ComponentModel.DataAnnotations;

namespace CV_System_API_New.Models.HobbyInfo
{
    public class HobbyData
    {
        public int HobbyDataId { get; set; }
        [Required]
        public string HobbyName { get; set; }
        public virtual Hobby Hobby { get; set; }
    }
}
