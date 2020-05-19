using Microsoft.AspNetCore.Identity;

namespace LibModelsContext.Models
{
    public class LoginData : IdentityUser<int>
    {
        public int CVSystemUserId { get; set; }
        public virtual CVSystemUser CVSystemUser { get; set; }
    }
}
