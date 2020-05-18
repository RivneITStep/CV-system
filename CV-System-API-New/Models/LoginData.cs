using Microsoft.AspNetCore.Identity;

namespace CV_System_API_New.Models
{
    public class LoginData : IdentityUser<int>
    {
        public int CVSystemUserId { get; set; }
        public virtual CVSystemUser CVSystemUser { get; set; }
    }
}
