using System;
using System.Collections.Generic;

namespace API_Real_Base_Test_Own_Context.Models
{
    public partial class Experience
    {
        public int ExperienceId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Position { get; set; }
        public string CompanyName { get; set; }
        public int PersonalId { get; set; }

        public virtual PersonalData Personal { get; set; }
    }
}
