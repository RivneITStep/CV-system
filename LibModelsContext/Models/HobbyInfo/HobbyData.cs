using System.ComponentModel.DataAnnotations;

namespace LibModelsContext.Models.HobbyInfo
{
    public class HobbyData
    {
        public int HobbyDataId { get; set; }
        [Required]
        public string HobbyName { get; set; }
        public virtual Hobby Hobby { get; set; }
    }
}
