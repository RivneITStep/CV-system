using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Real_Base_Test_Own_Context.Helpers;
using API_Real_Base_Test_Own_Context.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Real_Base_Test_Own_Context.Controllers
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
