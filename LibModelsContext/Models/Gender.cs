using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibModelsContext.Models
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
