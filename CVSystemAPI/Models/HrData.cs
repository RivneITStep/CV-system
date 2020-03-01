using System;
using System.Collections.Generic;

namespace CVSystemAPI.Models
{
    public partial class HrData
    {
        public HrData()
        {
            LoginHrBinder = new HashSet<LoginHrBinder>();
        }

        public int HrId { get; set; }
        public int Favorites { get; set; }

        public virtual PersonalData FavoritesNavigation { get; set; }
        public virtual ICollection<LoginHrBinder> LoginHrBinder { get; set; }
    }
}
