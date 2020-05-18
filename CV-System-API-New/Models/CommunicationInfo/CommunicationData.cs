using System.ComponentModel.DataAnnotations;

namespace CV_System_API_New.Models.CommunicationInfo
{
    public class CommunicationData
    {
        public int CommunicationDataId { get; set; }
        [Required]
        public string CommunicationDataName { get; set; }
        [Required]
        public string CommunicationDataContent { get; set; }
        public virtual Communication Communication { get; set; }
    }
}
