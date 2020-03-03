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
    [Route("api/adminData")]
    [ApiController]
    public class LoginAdminBinderController : Controller
    {
        ControllerHelper ch = new ControllerHelper();
        [HttpGet("get")]
        public IActionResult Get()
        {
            using (CVContext db = new CVContext(OptionsHelper<CVContext>.GetOptions()))
            {
                var admindatas = db.LoginAdminBinder.Include(x => x.Login).ToList();
                return ch.GetResultForGET(admindatas);
            }
        }
        [HttpGet("get/{adminName}")]
        public IActionResult Get(string adminName)
        {
            using (CVContext db = new CVContext(OptionsHelper<CVContext>.GetOptions()))
            {
                var admindatas = db.LoginAdminBinder.Include(x => x.Login).Where(y => y.Login.LoginName.ToLower().Equals(adminName.ToLower())).ToList();
                return ch.GetResultForGET(admindatas);
            }
        }
    }
}
