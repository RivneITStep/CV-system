using System;
using System.Collections.Generic;

namespace API_Real_Base_Test_Own_Context.Models
{
    public partial class PersonTrainings
    {
        public int PersonTrainingsId { get; set; }
        public int TrainingsId { get; set; }
        public int PersonalDataId { get; set; }

        public virtual PersonalData PersonalData { get; set; }
        public virtual Trainings Trainings { get; set; }
    }
}
