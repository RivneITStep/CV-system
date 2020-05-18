using System.Collections.Generic;

namespace CV_System_API_New.DTO.CommunicationDTOs
{
    public class CommunicationDTO
    {
        public virtual ICollection<CommunicationDataDTO> CommunicationDatas { get; set; }
        public virtual CVDataDTO CVData { get; set; }
        public CommunicationDTO()
        {
            CommunicationDatas ??= new HashSet<CommunicationDataDTO>();
        }
    }
}
