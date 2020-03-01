using System;
using System.Collections.Generic;

namespace CVSystemAPI.Models
{
    public partial class Communication
    {
        public int CommunicationId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Skype { get; set; }
        public string Viber { get; set; }
        public string WhatsApp { get; set; }
        public int PersonalId { get; set; }

        public virtual PersonalData Personal { get; set; }
        public virtual ICollection<CVData> CVDatas { get; set; }
        public Communication()
        {
            CVDatas = new HashSet<CVData>();
        }
    }
}
