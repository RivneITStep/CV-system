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
    [Route("api/getSkills")]
    [ApiController]
    public class SkillsController
    {
        [HttpGet]
        public ActionResult<IEnumerable<Skills>> Get()
        {
            using (SkillsContext db = new SkillsContext(OptionsHelper<SkillsContext>.GetOptions()))
            {
                var skills = db.Skills.ToList();
                return skills;
            }
        }
    }
}
