using CVSystemAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVSystemAPI.Helpers
{
    public class PersonFullInfoHelper
    {
        public List<PersonalData> GetFullInfo(IQueryable<PersonalData> personalDatas)
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
            return res;
        }
    }
}
