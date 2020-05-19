using System.Collections.Generic;

namespace LibDTO.DTO.CommunicationDTOs
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
