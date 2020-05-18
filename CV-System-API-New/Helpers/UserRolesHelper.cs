using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV_System_API_New.Helpers
{
    public static class UserRolesHelper
    {
        enum UserRoles
        {
            Administrator,
            HumanResourceManager,
            NormalUser,
            UnregisteredUser
        }
        public static string Administrator { get => UserRoles.Administrator.ToString(); }
        public static string HumanResourceManager { get => UserRoles.HumanResourceManager.ToString(); }
        public static string NormalUser { get => UserRoles.NormalUser.ToString(); }
        public static string UnregisteredUser { get => UserRoles.UnregisteredUser.ToString(); }
    }
}
