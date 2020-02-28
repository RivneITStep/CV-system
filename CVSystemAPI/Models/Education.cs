using System;
using System.Collections.Generic;

namespace API_Real_Base_Test_Own_Context.Models
{
    public partial class Education
    {
        public int EducationId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string EducationalInstitutionName { get; set; }
        public string CourseName { get; set; }
        public int PersonalId { get; set; }

        public virtual PersonalData Personal { get; set; }
    }
}
