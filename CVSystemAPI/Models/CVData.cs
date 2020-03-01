using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVSystemAPI.Models
{
    public class CVData
    {
        public int Id { get; set; }
        public int CommunicationId { get; set; }
        public int EducationId { get; set; }
        public int ExperienceId { get; set; }
        public int SocialNetworksId { get; set; }
        public int Login_CV_BinderId { get; set; }

        public virtual ICollection<Communication> Communications { get; set; }
        public virtual ICollection<Education> Educations { get; set; }
        public virtual ICollection<Experience> Experiences { get; set; }
        public virtual ICollection<SocialNetworks> SocialNetworks { get; set; }
        public virtual ICollection<LoginCvBinder> LoginCvBinders { get; set; }
        public CVData()
        {
            Communications = new HashSet<Communication>();
            Educations = new HashSet<Education>();
            Experiences = new HashSet<Experience>();
            SocialNetworks = new HashSet<SocialNetworks>();
            LoginCvBinders = new HashSet<LoginCvBinder>();
        }
    }
}
