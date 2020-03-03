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
    [Route("api/addresses")]
    [ApiController]
    public class AddressController : Controller
    {
        ControllerHelper ch = new ControllerHelper();
        [HttpGet("get")]
        public IActionResult Get()
        {
            using (CVContext db = new CVContext(OptionsHelper<CVContext>.GetOptions()))
            {
                var addresses = db.Address.ToList();
                return ch.GetResultForGET(addresses);
            }
        }
        [HttpGet("get/persons/{cityName}")]
        public IActionResult GetPersonsByCityName(string cityName)
        {
            using (CVContext db = new CVContext(OptionsHelper<CVContext>.GetOptions()))
            {
                var persons = db.Address.Include(x => x.Personal).Where(x => x.City.ToLower().Equals(cityName.ToLower())).Select(x=>x.Personal).ToList();
                return ch.GetResultForGET(persons);
            }
        }
    }
}
