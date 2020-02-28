using System;
using System.Collections.Generic;

namespace API_Real_Base_Test_Own_Context.Models
{
    public partial class AdminData
    {
        public AdminData()
        {
            LoginAdminBinder = new HashSet<LoginAdminBinder>();
        }

        public int AdminId { get; set; }

        public virtual ICollection<LoginAdminBinder> LoginAdminBinder { get; set; }
    }
}
