using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CVSystemAPI.Helpers;
using CVSystemAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CVSystemAPI.Controllers
{
    [Route("api/getLanguages")]
    [ApiController]
    public class LanguagesController :Controller
    {
        ControllerHelper ch = new ControllerHelper();
        [HttpGet]
        public IActionResult Get()
        {
            using (CVContext db = new CVContext(OptionsHelper<CVContext>.GetOptions()))
            {
                var languages = db.Languages.ToList();
                return ch.GetResult(languages);
            }
        }
    }
}
