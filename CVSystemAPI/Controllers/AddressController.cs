using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CVSystemAPI.Helpers;
using CVSystemAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace CVSystemAPI.Controllers
{
    [Route("api/getAddresses")]
    [ApiController]
    public class AddressController : Controller
    {
        ControllerHelper ch = new ControllerHelper();
        [HttpGet]
        public IActionResult Get()
        {
            using (CVContext db = new CVContext(OptionsHelper<CVContext>.GetOptions()))
            {
                var addresses = db.Address.ToList();
                return ch.GetResult(addresses);
            }
        }
        [HttpGet("getPersons/{cityName}")]
        public IActionResult GetPersonsByCityName(string cityName)
        {
            using (CVContext db = new CVContext(OptionsHelper<CVContext>.GetOptions()))
            {
                var persons = db.Address.Include(x => x.Personal).Where(x => x.City.ToLower().Equals(cityName.ToLower())).Select(x=>x.Personal).ToList();
                return ch.GetResult(persons);
            }
        }
    }
}
