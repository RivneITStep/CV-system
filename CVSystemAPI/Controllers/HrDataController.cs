﻿using API_Real_Base_Test_Own_Context.Helpers;
using API_Real_Base_Test_Own_Context.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVSystemAPI.Controllers
{
    [Route("api/getHRDatas")]
    [ApiController]
    public class HrDataController : Controller
    {
        ControllerHelper ch = new ControllerHelper();
        [HttpGet]
        public IActionResult Get()
        {
            using (CVContext db = new CVContext(OptionsHelper<CVContext>.GetOptions()))
            {
                var hrdatas = db.HrData.ToList();
                return ch.GetResult(hrdatas);
            }
        }
    }
}
