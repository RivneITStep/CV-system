using System;
using System.Collections.Generic;

namespace API_Real_Base_Test_Own_Context.Models
{
    public partial class LoginAdminBinder
    {
        public int LoginAdminBinderId { get; set; }
        public int AdminId { get; set; }
        public int LoginId { get; set; }

        public virtual AdminData Admin { get; set; }
        public virtual Signin Login { get; set; }
    }
}
