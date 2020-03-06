using CVSystemAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVSystemAPI.Helpers
{
    public static class CVBuilderHelper
    {
        public static CVData GetCVData(LoginCvBinder binder)
        {
            CVData cv = new CVData()
            {
                Addresse = binder.Personal.Address,
                Communications = binder.Personal.Communication,
                Educations = binder.Personal.Education,
                Experiences = binder.Personal.Experience,
                SocialNetworks = binder.Personal.SocialNetworks
            };
            foreach (var h in binder.Personal.PersonHobbies)
            {
                cv.Hobbies.Add(h.Hobby);
            }
            foreach (var l in binder.Personal.PersonLanguages)
            {
                cv.Languages.Add(l.Language);
            }
            return cv;
        }
    }
}
