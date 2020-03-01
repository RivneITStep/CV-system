using System;
using System.Collections.Generic;

namespace CVSystemAPI.Models
{
    public partial class SocialNetworks
    {
        public int SocialNetworksId { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Hangouts { get; set; }
        public string Veon { get; set; }
        public string Instagram { get; set; }
        public string Telegram { get; set; }
        public string Linkedin { get; set; }
        public string Imo { get; set; }
        public int PersonalId { get; set; }

        public virtual PersonalData Personal { get; set; }
    }
}
