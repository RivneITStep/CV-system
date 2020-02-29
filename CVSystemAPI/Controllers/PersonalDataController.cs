using API_Real_Base_Test_Own_Context.Helpers;
using API_Real_Base_Test_Own_Context.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Real_Base_Test_Own_Context.Controllers
{
    [Route("api/getUsers")]
    [ApiController]
    public class PersonalDataController : Controller
    {
        ControllerHelper ch = new ControllerHelper();
        [HttpGet]
        public IActionResult Get()
        {
            using (CVContext db = new CVContext(OptionsHelper<CVContext>.GetOptions()))
            {
                var users = db.PersonalData.ToList();
                return ch.GetResult(users);
            }
        }
        [HttpGet("skill/{skillId}")]
        public IActionResult GetPersonsBySkillId(int skillId)
        {
            using (CVContext db = new CVContext(OptionsHelper<CVContext>.GetOptions()))
            {
                var persons = db.PersonalData.Include(x => x.PersonSoftwareSkill).Where(x => x.PersonSoftwareSkill.Where(y => y.SkillId == skillId).Any()).ToList();
                return ch.GetResult(persons);
            }
        }
        [HttpGet("skill/{skillName}")]
        public IActionResult GetPersonsBySkillName(string skillName)
        {
            using (CVContext db = new CVContext(OptionsHelper<CVContext>.GetOptions()))
            {
                var persons = db.PersonalData.Include(x => x.PersonSoftwareSkill).Where(x => x.PersonSoftwareSkill.Where(y => y.Skill.SkillName.ToLower().Equals(skillName.ToLower())).Any()).ToList();
                return ch.GetResult(persons);
            }
        }
        [HttpGet("{lastName}")]
        public IActionResult GetByLastName(string lastName)
        {
            using (CVContext db = new CVContext(OptionsHelper<CVContext>.GetOptions()))
            {
                var users = db.PersonalData.Where(x => x.LastName.ToLower().Equals(lastName.ToLower())).ToList();
                return ch.GetResult(users);
            }
        }
        [HttpGet("{firstName}&{lastName}")]
        public IActionResult GetByFullName(string firstName, string lastName)
        {
            using (CVContext db = new CVContext(OptionsHelper<CVContext>.GetOptions()))
            {
                var users = db.PersonalData.Where(x => x.FirstName.ToLower().Equals(firstName.ToLower()) && x.LastName.ToLower().Equals(lastName.ToLower())).ToList();
                return ch.GetResult(users);
            }
        }
    }
}
