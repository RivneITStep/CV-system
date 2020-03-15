using CVSystemAPI.Helpers;
using CVSystemAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVSystemAPI.Controllers
{
    [Route("api/signin")]
    [ApiController]
    public class SigninContoller : Controller
    {
        ControllerHelper ch;
        public SigninContoller()
        {
            ch = new ControllerHelper();
        }
        #region GETS
        [HttpGet("get")]
        public IActionResult Get()
        {
            using (CVContext db = new CVContext(OptionsHelper<CVContext>.GetOptions()))
            {
                var signIns = db.Signin.ToList();
                return ch.GetResultForGET(signIns);
            }
        }
        #endregion

        #region POSTS
        [HttpPost("post/register/{signIn}")]
        public IActionResult PostRegister(Signin signIn)
        {
            if (signIn == null || !ModelState.IsValid) // if any is invalid - return BadRequest
            {
                return BadRequest($"Object signIn is null. Or ModelState({ModelState.IsValid}) is invalid");
            }
            using (CVContext db = new CVContext(OptionsHelper<CVContext>.GetOptions()))
            {
                var s = db.Signin.FirstOrDefault(x => x.LoginId.Equals(signIn.LoginId));
                if (s == null)
                {
                    db.Signin.Add(signIn);
                    db.SaveChanges();
                    var sAdded = db.Signin.FirstOrDefault(x => x.LoginId.Equals(signIn.LoginId));
                    return CreatedAtAction(nameof(Get), sAdded);
                }
                else
                {
                    return BadRequest("Such SignIn object already exists in the base!");
                }
            }
        }
        #endregion
    }
}
