using CVSystemAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVSystemAPI.Helpers
{
    public class FullInfoHelper
    {
        public object GetFullInfo(IQueryable<PersonalData> personalDatas)
        {
            var res = personalDatas.Include(q => q.Address)
                    .Include(w => w.Communication)
                    .Include(e => e.Education)
                    .Include(r => r.Experience)
                    .Include(t => t.LoginCvBinder).ThenInclude(y => y.Login)
                    .Include(u => u.PersonHobbies).ThenInclude(i => i.Hobby)
                    .Include(o => o.PersonLanguages).ThenInclude(p => p.Language)
                    .Include(a => a.PersonPersonalities).ThenInclude(s => s.Personality)
                    .Include(d => d.PersonSoftwareSkill).ThenInclude(f => f.Skill)
                    .Include(g => g.PersonTrainings).ThenInclude(h => h.Trainings)
                    .Include(j => j.SocialNetworks)
                    .ToList();
            if (res.Count == 1)
            {
                var user = res[0];
                return user;
            }
            return res;
        }
        public LoginCvBinder GetFullInfoByLogin(IQueryable<LoginCvBinder> loginCvBinders)
        {
            var cv = loginCvBinders.Include(q => q.Login)
            .Include(x => x.Personal.Address)
            .Include(x => x.Personal.Communication)
            .Include(x => x.Personal.Education)
            .Include(x => x.Personal.Experience)
            .Include(x => x.Personal.PersonHobbies).ThenInclude(x => x.Hobby)
            .Include(x => x.Personal.PersonLanguages).ThenInclude(x => x.Language)
            .Include(x => x.Personal.PersonPersonalities).ThenInclude(x => x.Personality)
            .Include(x => x.Personal.PersonSoftwareSkill).ThenInclude(x => x.Skill)
            .Include(x => x.Personal.PersonTrainings).ThenInclude(x => x.Trainings)
            .Include(x => x.Personal.SocialNetworks);
            var list = cv.ToList();
            var res = list[0];
            return res;
        }
    }
}
