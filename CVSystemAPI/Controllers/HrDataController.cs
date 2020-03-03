using CVSystemAPI.Helpers;
using CVSystemAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVSystemAPI.Controllers
{
    [Route("api/HRDatas")]
    [ApiController]
    public class HrDataController : Controller
    {
        ControllerHelper ch = new ControllerHelper();
        [HttpGet("get")]
        public IActionResult Get()
        {
            using (CVContext db = new CVContext(OptionsHelper<CVContext>.GetOptions()))
            {
                var hrdatas = db.HrData.ToList();
                return ch.GetResultForGET(hrdatas);
            }
        }
    }
}
