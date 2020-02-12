using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Real_Base_Test_Own_Context.Contexts;
using API_Real_Base_Test_Own_Context.Helpers;
using API_Real_Base_Test_Own_Context.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Real_Base_Test_Own_Context.Controllers
{
    [Route("api/getLanguages")]
    [ApiController]
    public class LanguagesController
    {
        [HttpGet]
        public ActionResult<IEnumerable<Languages>> Get()
        {
            using (LanguagesContext db = new LanguagesContext(OptionsHelper<LanguagesContext>.GetOptions()))
            {
                var languages = db.Languages.ToList();
                return languages;
            }
        }
    }
}
