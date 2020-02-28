using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Real_Base_Test_Own_Context.Helpers
{
    static public class ConnectionStringHelper
    {
        static public string ExternalString
        {
            get
            {
                return "Server=194.44.93.225;Initial Catalog=Account1_CV;Trusted_Connection=True;Integrated Security=False;User ID=lukashchuk;Password=1";
            }
        }
        static public string InternalString
        {
            get
            {
                return "Server=10.7.101.197;Initial Catalog=Account1_CV;Trusted_Connection=True;Integrated Security=False;User ID=lukashchuk;Password=1";
            }
        }
    }
}
