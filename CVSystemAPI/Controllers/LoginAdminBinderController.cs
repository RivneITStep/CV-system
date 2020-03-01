using API_Real_Base_Test_Own_Context.Helpers;
using API_Real_Base_Test_Own_Context.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVSystemAPI.Controllers
{
    [Route("api/getAdminData")]
    [ApiController]
    public class LoginAdminBinderController : Controller
    {
        ControllerHelper ch = new ControllerHelper();
        [HttpGet]
        public IActionResult Get()
        {
            using (CVContext db = new CVContext(OptionsHelper<CVContext>.GetOptions()))
            {
                var admindatas = db.LoginAdminBinder.Include(x => x.Login).ToList();
                return ch.GetResult(admindatas);
            }
        }
        [HttpGet("{adminName}")]
        public IActionResult Get(string adminName)
        {
            using (CVContext db = new CVContext(OptionsHelper<CVContext>.GetOptions()))
            {
                var admindatas = db.LoginAdminBinder.Include(x => x.Login).Where(y => y.Login.LoginName.ToLower().Equals(adminName.ToLower())).ToList();
                return ch.GetResult(admindatas);
            }
        }
    }
}
