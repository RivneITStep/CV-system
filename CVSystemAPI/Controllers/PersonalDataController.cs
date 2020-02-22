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
                //if (users == null)
                {
                    return NoContent(); //тест
                }
                else
                {
                    return Ok(users);
                }
            }
        }
        [HttpGet("{secondName}")]
        public IActionResult Get(string secondName)
        {
            using (PersonalDataContext db = new PersonalDataContext(OptionsHelper<PersonalDataContext>.GetOptions()))
            {
                var users = db.Personal_Data.ToList();
                if (users == null)
                {
                    return NoContent();
                }
                var found = users.FindAll(x => x.LastName.ToLower().Equals(secondName.ToLower()));
                if (found == null)
                {
                    return NotFound();
                }
                else if (found.Count == 1)
                {
                    var person = found[0];
                    return Ok(person);
                }
                return Ok(found);
            }
        }
        [HttpGet("{firstName}&{secondName}")]
        public IActionResult Get(string firstName, string secondName)
        {
            using (PersonalDataContext db = new PersonalDataContext(OptionsHelper<PersonalDataContext>.GetOptions()))
            {
                var users = db.Personal_Data.ToList();
                if (users == null)
                {
                    return NoContent();
                }
                var found = users.FindAll(x => x.LastName.ToLower().Equals(secondName.ToLower()) && x.FirstName.ToLower().Equals(firstName.ToLower()));
                if (found == null)
                {
                    return NotFound();
                }
                else if (found.Count == 1)
                {
                    var person = found[0];
                    return Ok(person);
                }
                return Ok(found);
            }
        }
    }
}
