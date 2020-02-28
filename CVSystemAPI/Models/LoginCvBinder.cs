using System;
using System.Collections.Generic;

namespace API_Real_Base_Test_Own_Context.Models
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
