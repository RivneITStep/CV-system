using System.Collections.Generic;

namespace LibDTO.DTO.HobbyDTOs
{
    public class HobbyDTO
    {
        public virtual ICollection<HobbyDataDTO> HobbyDatas { get; set; }
        public virtual CVDataDTO CVData { get; set; }
        public HobbyDTO()
        {
            HobbyDatas ??= new HashSet<HobbyDataDTO>();
        }
    }
}
