using System.Collections.Generic;

namespace LibDTO.DTO
{
    public class CVSystemUserDTO
    {
        public virtual UserRoleDTO UserRole { get; set; }
        public virtual PersonalDataDTO PersonalData { get; set; }
        public virtual LoginDataDTO LoginData { get; set; }
        public virtual ICollection<CVDataDTO> CVDatas { get; set; }
        public CVSystemUserDTO()
        {
            CVDatas = new HashSet<CVDataDTO>();
        }
    }
}
