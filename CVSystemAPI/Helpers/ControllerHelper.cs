using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Real_Base_Test_Own_Context.Helpers
{
    public class ControllerHelper : Controller
    {
        public IActionResult GetResult(object obj)
        {
            if (obj == null || (obj is ICollection && (obj as ICollection).Count == 0))
            {
                return NoContent();
            }
            else
            {
                return Ok(obj);
            }
        }
    }
}
