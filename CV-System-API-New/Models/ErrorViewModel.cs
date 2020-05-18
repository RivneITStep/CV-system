using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV_System_API_New.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
