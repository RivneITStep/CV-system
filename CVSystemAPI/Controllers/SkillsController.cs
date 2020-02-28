using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Real_Base_Test_Own_Context.Helpers;
using API_Real_Base_Test_Own_Context.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Real_Base_Test_Own_Context.Controllers
{
    [Route("api/getSkills")]
    [ApiController]
    public class SkillsController : Controller
    {
        ControllerHelper ch = new ControllerHelper();

        [HttpGet]
        public IActionResult Get()
        {
            using (CVContext db = new CVContext(OptionsHelper<CVContext>.GetOptions()))
            {
                var skills = db.Skills.ToList();
                return ch.GetResult(skills);
            }
        }
    }
}
