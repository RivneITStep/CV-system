using System.Collections.Generic;

namespace CV_System_API_New.DTO.EducationDTOs
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
