using AutoMapper;
using System;
using System.Linq;
using System.Reflection;

namespace CV_System_API_New.Helpers
{
    public static class MapperProfilesHelper
    {
        static Type[] mapperProfiles;
        static MapperProfilesHelper()
        {
            var parentProfile = typeof(Profile);
            var assembly = Assembly.GetExecutingAssembly();
            var allTypes = assembly.GetTypes();
            mapperProfiles = allTypes.Where(x => x.IsSubclassOf(parentProfile)).ToArray();
        }
        public static Type[] MapperProfiles { get => mapperProfiles; }
    }
}
