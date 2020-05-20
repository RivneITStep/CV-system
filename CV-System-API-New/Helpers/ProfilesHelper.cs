using AutoMapper;
using System;
using System.Linq;
using System.Reflection;

namespace CV_System_API_New.Helpers
{
    public static class ProfilesHelper
    {
        static Type[] profiles;
        static ProfilesHelper()
        {
            var parent = typeof(Profile);
            var a = Assembly.GetExecutingAssembly();
            var types = a.GetTypes();
            profiles = types.Where(x => x.IsSubclassOf(parent)).ToArray();
        }
        public static Type[] Profiles { get => profiles; }
    }
}
