using System;
using System.Collections.Generic;

namespace API_Real_Base_Test_Own_Context.Models
{
    public partial class Languages
    {
        public Languages()
        {
            PersonLanguages = new HashSet<PersonLanguages>();
        }

        public int LanguageId { get; set; }
        public string LanguageName { get; set; }

        public virtual ICollection<PersonLanguages> PersonLanguages { get; set; }
    }
}
