using System;
using System.Collections.Generic;

namespace API_Real_Base_Test_Own_Context.Models
{
    public partial class LoginHrBinder
    {
        public int LoginHrBinderId { get; set; }
        public int HrId { get; set; }
        public int LoginId { get; set; }

        public virtual HrData Hr { get; set; }
        public virtual Signin Login { get; set; }
    }
}
