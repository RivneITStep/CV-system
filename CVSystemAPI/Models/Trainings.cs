using System;
using System.Collections.Generic;

namespace API_Real_Base_Test_Own_Context.Models
{
    public partial class Trainings
    {
        public Trainings()
        {
            PersonTrainings = new HashSet<PersonTrainings>();
        }

        public int TrainingId { get; set; }
        public string TrainingName { get; set; }

        public virtual ICollection<PersonTrainings> PersonTrainings { get; set; }
    }
}
