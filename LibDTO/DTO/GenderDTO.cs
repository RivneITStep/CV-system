using System.Collections.Generic;

namespace LibDTO.DTO
{
    public class GenderDTO
    {
        public string GenderName { get; set; }
        public virtual ICollection<PersonalDataDTO> PersonalDatas { get; set; }
        public GenderDTO()
        {
            PersonalDatas ??= new HashSet<PersonalDataDTO>();
        }
    }
}
