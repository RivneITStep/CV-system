using System;
using System.Collections.Generic;

namespace API_Real_Base_Test_Own_Context.Models
{
    public partial class PersonLanguages
    {
        public int PersonLanguagesId { get; set; }
        public int LanguageLevel { get; set; }
        public int LanguageId { get; set; }
        public int PersonalDataId { get; set; }

        public virtual Languages Language { get; set; }
        public virtual PersonalData PersonalData { get; set; }
    }
}
