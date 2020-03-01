using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CVSystemAPI.Helpers;
using CVSystemAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CVSystemAPI.Controllers
{
    [Route("api/getPersonalities")]
    [ApiController]
    public class PersonalityController : Controller
    {
        ControllerHelper ch = new ControllerHelper();
        [HttpGet]
        public IActionResult Get()
        {
            using (CVContext db = new CVContext(OptionsHelper<CVContext>.GetOptions()))
            {
                var personalities = db.Personality.ToList();
                return ch.GetResult(personalities);
            }
        }
    }
}
