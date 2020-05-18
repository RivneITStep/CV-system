﻿using System.Collections.Generic;

namespace CV_System_API_New.DTO.HobbyDTOs
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
