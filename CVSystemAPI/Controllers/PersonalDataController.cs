using API_Real_Base_Test_Own_Context.Contexts;
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
        [HttpGet]
        public IActionResult Get()
        {
            using (PersonalDataContext db = new PersonalDataContext(OptionsHelper<PersonalDataContext>.GetOptions()))
            {
                var users = db.Personal_Data.ToList();
                if (users == null)
                {
                    return NoContent();
                }
                else
                {
                    return Ok(users);
                }
            }
        }
    }
}
