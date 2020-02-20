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
    public class LanguagesController :Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            using (LanguagesContext db = new LanguagesContext(OptionsHelper<LanguagesContext>.GetOptions()))
            {
                var languages = db.Languages.ToList();
                if(languages == null)
                {
                    return NoContent();
                }
                else
                {
                    return Ok(languages);
                }
            }
        }
    }
}
