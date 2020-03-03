using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVSystemAPI.Helpers
{
    public class ControllerHelper : Controller
    {
        public IActionResult GetResultForGET(object obj)
        {
            if (obj == null || (obj is ICollection && (obj as ICollection).Count == 0))
            {
                return NotFound();
            }
            else
            {
                return Ok(obj);
            }
        }
    }
}
