using CVSystemAPI.Helpers;
using CVSystemAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CVSystemAPI.Controllers
{
    [Route("api/loginCVbinder")]
    [ApiController]
    public class LoginCvBinderController : Controller
    {
        ControllerHelper ch;
        public LoginCvBinderController()
        {
            ch = new ControllerHelper();
        }
        #region GETS
        [HttpGet("get")]
        public IActionResult Get()
        {
            using (CVContext db = new CVContext(OptionsHelper<CVContext>.GetOptions()))
            {
                var loginCVbinders = db.LoginCvBinder.ToList();
                return ch.GetResultForGET(loginCVbinders);
            }
        }
        #endregion

        #region POSTS
        [HttpPost("post/register/{signInId}")]
        public IActionResult PostRegister(int signInId, [FromBody] PersonalData person)
        {
            if (person == null || !ModelState.IsValid || signInId < 0) // if any is invalid - return BadRequest
            {
                return BadRequest($"Object Person is null. Or ModelState({ModelState.IsValid}) is invalid. Or signInId is invalid({signInId})");
            }
            using (CVContext db = new CVContext(OptionsHelper<CVContext>.GetOptions()))
            {
                var login = db.Signin.FirstOrDefault(x => x.LoginId.Equals(signInId)); //get login from db
                if (login != null) // go on if exists
                {
                    var p = db.PersonalData.FirstOrDefault(x => x.PersonalId.Equals(person.PersonalId)); //get person from db
                    if (p == null) // go on if none
                    {
                        db.PersonalData.Add(person); // add this new person to db
                        db.SaveChanges();
                        db.LoginCvBinder.Add(new LoginCvBinder() { Login = login, Personal = person }); // add new loginCVbinder object to db
                        db.SaveChanges();
                        var lcvb = db.LoginCvBinder.FirstOrDefault(x => x.LoginId.Equals(signInId) && x.PersonalId.Equals(person.PersonalId));
                        return CreatedAtAction(nameof(Get), lcvb); // return positive result
                    }
                    else
                    {
                        return BadRequest($"Person already exists in base!");
                    }
                }
                else
                {
                    return BadRequest($"Login with ID={signInId} not found");
                }
            }
        }
        [HttpPut("put/updatePersonalData/{signInId}")]
        public IActionResult PutRegister(int signInId, [FromBody] PersonalData person)
        {
            if (person == null || !ModelState.IsValid || signInId < 0) // if any is invalid - return BadRequest
            {
                return BadRequest($"Object Person is null. Or ModelState({ModelState.IsValid}) is invalid. Or signInId is invalid({signInId})");
            }
            using (CVContext db = new CVContext(OptionsHelper<CVContext>.GetOptions()))
            {
                var login = db.Signin.FirstOrDefault(x => x.LoginId.Equals(signInId)); //get login from db
                if (login != null) // go on if exists
                {
                    var p = db.PersonalData.FirstOrDefault(x => x.PersonalId.Equals(person.PersonalId)); //get person from db
                    if (p == null) // if none - BadRequest
                    {
                        return BadRequest($"Person does not exist in base!");
                    }
                    else
                    {
                        var l = db.LoginCvBinder.FirstOrDefault(x => x.LoginId.Equals(signInId));
                        db.Entry(l).State = EntityState.Detached;
                        l.Personal = UpdateHelper<PersonalData>.UpdateEntity(l.Personal, person);
                        db.Entry(l).State = EntityState.Modified;
                        db.SaveChanges();
                        var lcvb = db.LoginCvBinder.FirstOrDefault(x => x.LoginId.Equals(signInId) && x.PersonalId.Equals(person.PersonalId));
                        return CreatedAtAction(nameof(Get), lcvb); // return positive result
                    }
                }
                else
                {
                    return BadRequest($"Login with ID={signInId} not found");
                }
            }
        }
        #endregion
    }
}
