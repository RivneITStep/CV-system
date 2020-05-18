using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CV_System_API_New.Models
{
    public class Gender
    {
        public int GenderId { get; set; }
        [Required]
        public string GenderName { get; set; }
        public virtual ICollection<PersonalData> PersonalDatas { get; set; }
        public Gender()
        {
            PersonalDatas = new HashSet<PersonalData>();
        }
    }
}
