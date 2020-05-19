using System.Collections.Generic;

namespace LibDTO.DTO.EducationDTOs
{
    public class EducationDTO
    {
        public virtual ICollection<EducationDataDTO> EducationDatas { get; set; }
        public virtual CVDataDTO CVData { get; set; }
        public EducationDTO()
        {
            EducationDatas ??= new HashSet<EducationDataDTO>();
        }
    }
}
