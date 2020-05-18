using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace CV_System_API_New.Models
{
    public class UserRole : IdentityRole<int>
    {
        public virtual ICollection<CVSystemUser> Users { get; set; }
        public UserRole()
        {
            Users = new HashSet<CVSystemUser>();
        }
    }
}
