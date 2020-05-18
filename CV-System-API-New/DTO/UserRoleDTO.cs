using System.Collections.Generic;

namespace CV_System_API_New.DTO
{
    public class UserRoleDTO
    {
        public virtual ICollection<CVSystemUserDTO> Users { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }
        public UserRoleDTO()
        {
            Users ??= new HashSet<CVSystemUserDTO>();
        }
    }
}
