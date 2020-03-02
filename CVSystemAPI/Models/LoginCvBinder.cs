using System;
using System.Collections.Generic;

namespace CVSystemAPI.Models
{
    public partial class LoginCvBinder
    {
        public int LoginCvBinderId { get; set; }
        public int PersonalId { get; set; }
        public int LoginId { get; set; }
        public virtual Signin Login { get; set; }
        public virtual PersonalData Personal { get; set; }
    }
}
