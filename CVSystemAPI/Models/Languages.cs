using System;
using System.Collections.Generic;

namespace CVSystemAPI.Models
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
