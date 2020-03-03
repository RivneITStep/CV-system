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
    [Route("api/persons")]
    [ApiController]
    public class PersonalDataController : Controller
    {
        ControllerHelper ch;
        public PersonalDataController()
        {
            ch = new ControllerHelper();
        }
        #region GETs
        [HttpGet("get")]
        public IActionResult Get()
        {
            using (CVContext db = new CVContext(OptionsHelper<CVContext>.GetOptions()))
            {
                var users = db.PersonalData.ToList();
                return ch.GetResultForGET(users);
            }
        }
        [HttpGet("get/{lastName}")]
        public IActionResult GetByLastName(string lastName)
        {
            using (CVContext db = new CVContext(OptionsHelper<CVContext>.GetOptions()))
            {
                var users = db.PersonalData.Where(x => x.LastName.ToLower().Equals(lastName.ToLower())).ToList();
                return ch.GetResultForGET(users);
            }
        }
        [HttpGet("get/{firstName}&{lastName}")]
        public IActionResult GetByFullName(string firstName, string lastName)
        {
            using (CVContext db = new CVContext(OptionsHelper<CVContext>.GetOptions()))
            {
                var users = db.PersonalData.Where(x => x.FirstName.ToLower().Equals(firstName.ToLower()) && x.LastName.ToLower().Equals(lastName.ToLower())).ToList();
                return ch.GetResultForGET(users);
            }
        }
        [HttpGet("get/full/{firstName}&{lastName}")]
        public IActionResult GetFullInfoByFullName(string firstName, string lastName)
        {
            using (CVContext db = new CVContext(OptionsHelper<CVContext>.GetOptions()))
            {
                FullInfoHelper fih = new FullInfoHelper();
                var query = db.PersonalData.Where(x => x.FirstName.ToLower().Equals(firstName.ToLower()) && x.LastName.ToLower().Equals(lastName.ToLower()));
                var users = fih.GetFullInfoForPersonalData(query);
                return ch.GetResultForGET(users);
            }
        }
        [HttpGet("get/full/{personId}")]
        public IActionResult GetFullInfoById(int personId)
        {
            using (CVContext db = new CVContext(OptionsHelper<CVContext>.GetOptions()))
            {
                FullInfoHelper fih = new FullInfoHelper();
                var query = db.PersonalData.Where(x => x.PersonalId == personId);
                var users = fih.GetFullInfoForPersonalData(query);
                return ch.GetResultForGET(users);
            }
        }
        #region PERSONS BY SKILL
        [HttpGet("get/skill/{skillId}")]
        public IActionResult GetPersonsBySkillId(int skillId)
        {
            using (CVContext db = new CVContext(OptionsHelper<CVContext>.GetOptions()))
            {
                var persons = db.PersonalData.Include(x => x.PersonSoftwareSkill).Where(x => x.PersonSoftwareSkill.Where(y => y.SkillId == skillId).Any()).ToList();
                return ch.GetResultForGET(persons);
            }
        }
        [HttpGet("get/skill/{skillName}")]
        public IActionResult GetPersonsBySkillName(string skillName)
        {
            using (CVContext db = new CVContext(OptionsHelper<CVContext>.GetOptions()))
            {
                var persons = db.PersonalData.Include(x => x.PersonSoftwareSkill).Where(x => x.PersonSoftwareSkill.Where(y => y.Skill.SkillName.ToLower().Equals(skillName.ToLower())).Any()).ToList();
                return ch.GetResultForGET(persons);
            }
        }
        #endregion

        #region GET CV BY LOGIN
        [HttpGet("get/getCV/{loginName}")]
        public IActionResult GetCVByLoginName(string loginName)
        {
            using (CVContext db = new CVContext(OptionsHelper<CVContext>.GetOptions()))
            {
                FullInfoHelper fih = new FullInfoHelper();
                var query = db.LoginCvBinder.Where(x => x.Login.LoginName.ToLower().Equals(loginName.ToLower()));
                var binder = fih.GetFullInfoForLoginBinder(query);
                var cv = CVBuilderHelper.GetCVData(binder);
                return ch.GetResultForGET(cv);
            }
        }
        #endregion

        #endregion

        #region POSTs
        [HttpPost("post")]
        public IActionResult Post([FromBody]PersonalData person)
        {
            if (person == null || !ModelState.IsValid)
            {
                return BadRequest();
            }
            using (CVContext db = new CVContext(OptionsHelper<CVContext>.GetOptions()))
            {
                db.PersonalData.Add(person);
                db.SaveChanges();
                return CreatedAtAction(nameof(Get), person);
            }
        }
        [HttpPost("post/range")]
        public IActionResult PostRange([FromBody]ICollection<PersonalData> persons)
        {
            if (persons == null || !ModelState.IsValid)
            {
                return BadRequest();
            }
            using (CVContext db = new CVContext(OptionsHelper<CVContext>.GetOptions()))
            {

                db.PersonalData.AddRange(persons);
                db.SaveChanges();
                return CreatedAtAction(nameof(Get), persons);
            }
        }
        #endregion

    }
}
