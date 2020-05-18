﻿using System.Collections.Generic;

namespace CV_System_API_New.Models.CommunicationInfo
{
    public class Communication
    {
        public int CommunicationId { get; set; }
        public virtual ICollection<CommunicationData> CommunicationDatas { get; set; }
        public int CVDataId { get; set; }
        public virtual CVData CVData { get; set; }
        public Communication()
        {
            CommunicationDatas = new HashSet<CommunicationData>();
        }
    }
}
