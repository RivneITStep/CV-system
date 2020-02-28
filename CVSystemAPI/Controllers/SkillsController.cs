using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Real_Base_Test_Own_Context.Helpers;
using API_Real_Base_Test_Own_Context.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        [HttpGet("person/{personId}")]
        public IActionResult GetSkillsByPersonId(int personId)
        {
            using (CVContext db = new CVContext(OptionsHelper<CVContext>.GetOptions()))
            {
                var skills = db.Skills.Include(s => s.PersonSoftwareSkill).Where(x => x.PersonSoftwareSkill.Where(x => x.PersonalDataId == personId).Any()).ToList();
                return ch.GetResult(skills);
            }
        }
        [HttpGet("person/{firstName}&{lastName}")]
        public IActionResult GetSkillsByPersonFullName(string firstName, string lastName)
        {
            using (CVContext db = new CVContext(OptionsHelper<CVContext>.GetOptions()))
            {
                var skills = db.Skills.Include(s => s.PersonSoftwareSkill).Where(
                    x => x.PersonSoftwareSkill.Where(
                    x => x.PersonalData.FirstName.ToLower().Equals(firstName.ToLower()) && x.PersonalData.LastName.ToLower().Equals(lastName.ToLower()))
                    .Any()).ToList();
                return ch.GetResult(skills);
            }
        }
    }
}
