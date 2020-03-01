﻿using CVSystemAPI.Helpers;
using CVSystemAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVSystemAPI.Controllers
{
    [Route("api/getEducations")]
    [ApiController]
    public class EducationController : Controller
    {
        ControllerHelper ch = new ControllerHelper();
        [HttpGet]
        public IActionResult Get()
        {
            using (CVContext db = new CVContext(OptionsHelper<CVContext>.GetOptions()))
            {
                var educations = db.Education.ToList();
                return ch.GetResult(educations);
            }
        }
        [HttpGet("persons/{personId}")]
        public IActionResult GetPersonsEducationByPersonsId(int personId)
        {
            using (CVContext db = new CVContext(OptionsHelper<CVContext>.GetOptions()))
            {
                var persons = db.Education.Include(x => x.Personal).Where(y => y.PersonalId == personId).ToList();
                return ch.GetResult(persons);
            }
        }
    }
}
