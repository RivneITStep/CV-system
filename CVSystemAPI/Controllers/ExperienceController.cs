using CVSystemAPI.Helpers;
using CVSystemAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVSystemAPI.Controllers
{
    [Route("api/experiences")]
    [ApiController]
    public class ExperienceController : Controller
    {
        ControllerHelper ch = new ControllerHelper();
        [HttpGet("get")]
        public IActionResult Get()
        {
            using (CVContext db = new CVContext(OptionsHelper<CVContext>.GetOptions()))
            {
                var experiences = db.Experience.ToList();
                return ch.GetResultForGET(experiences);
            }
        }
    }
}
