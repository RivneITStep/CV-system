using CVSystemAPI.Helpers;
using CVSystemAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVSystemAPI.Controllers
{
    [Route("api/getUsers")]
    [ApiController]
    public class PersonalDataController : Controller
    {
        ControllerHelper ch;
        public PersonalDataController()
        {
            ch = new ControllerHelper();
        }
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
        [HttpGet("full/{firstName}&{lastName}")]
        public IActionResult GetFullInfoByFullName(string firstName, string lastName)
        {
            using (CVContext db = new CVContext(OptionsHelper<CVContext>.GetOptions()))
            {
                FullInfoHelper fih = new FullInfoHelper();
                var query = db.PersonalData.Where(x => x.FirstName.ToLower().Equals(firstName.ToLower()) && x.LastName.ToLower().Equals(lastName.ToLower()));
                var users = fih.GetFullInfoForPersonalData(query);
                return ch.GetResult(users);
            }
        }
        [HttpGet("full/{personId}")]
        public IActionResult GetFullInfoById(int personId)
        {
            using (CVContext db = new CVContext(OptionsHelper<CVContext>.GetOptions()))
            {
                FullInfoHelper fih = new FullInfoHelper();
                var query = db.PersonalData.Where(x => x.PersonalId == personId);
                var users = fih.GetFullInfoForPersonalData(query);
                return ch.GetResult(users);
            }
        }
        [HttpGet("getCV/{loginName}")]
        public IActionResult GetCVByLoginName(string loginName)
        {
            using (CVContext db = new CVContext(OptionsHelper<CVContext>.GetOptions()))
            {
                FullInfoHelper fih = new FullInfoHelper();
                var query = db.LoginCvBinder.Where(x => x.Login.LoginName.ToLower().Equals(loginName.ToLower()));
                var binder = fih.GetFullInfoForLoginBinder(query);
                var cv = CVBuilderHelper.GetCVData(binder);
                return ch.GetResult(cv);
            }
        }
    }
}
