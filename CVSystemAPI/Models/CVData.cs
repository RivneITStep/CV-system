using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVSystemAPI.Models
{
    public class CVData
    {
        public virtual Address Addresse { get; set; }
        public virtual ICollection<Communication> Communications { get; set; }
        public virtual ICollection<Hobbies> Hobbies { get; set; }
        public virtual ICollection<Education> Educations { get; set; }
        public virtual ICollection<Experience> Experiences { get; set; }
        public virtual ICollection<Languages> Languages { get; set; }
        public virtual ICollection<SocialNetworks> SocialNetworks { get; set; }

        public CVData()
        {
            Communications = new HashSet<Communication>();
            Hobbies = new HashSet<Hobbies>();
            Educations = new HashSet<Education>();
            Experiences = new HashSet<Experience>();
            Languages = new HashSet<Languages>();
            SocialNetworks = new HashSet<SocialNetworks>();
        }
    }
}
