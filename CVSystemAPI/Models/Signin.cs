using System;
using System.Collections.Generic;

namespace CVSystemAPI.Models
{
    public partial class Signin
    {
        public Signin()
        {
            LoginAdminBinder = new HashSet<LoginAdminBinder>();
            LoginCvBinder = new HashSet<LoginCvBinder>();
            LoginHrBinder = new HashSet<LoginHrBinder>();
        }

        public int LoginId { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }

        public virtual ICollection<LoginAdminBinder> LoginAdminBinder { get; set; }
        public virtual ICollection<LoginCvBinder> LoginCvBinder { get; set; }
        public virtual ICollection<LoginHrBinder> LoginHrBinder { get; set; }
    }
}
