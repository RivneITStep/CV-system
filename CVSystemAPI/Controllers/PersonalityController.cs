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
    [Route("api/getPersonalities")]
    [ApiController]
    public class PersonalityController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            using (PersonalityContext db = new PersonalityContext(OptionsHelper<PersonalityContext>.GetOptions()))
            {
                var personalities = db.Personality.ToList();
                if (personalities == null)
                {
                    return NoContent();
                }
                else
                {
                    return Ok(personalities);
                }
            }
        }
    }
}
