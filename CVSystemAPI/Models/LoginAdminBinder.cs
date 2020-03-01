using System;
using System.Collections.Generic;

namespace CVSystemAPI.Models
{
    public partial class LoginAdminBinder
    {
        public int LoginAdminBinderId { get; set; }
        public int LoginId { get; set; }

        public virtual Signin Login { get; set; }
    }
}
