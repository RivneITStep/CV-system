using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Real_Base_Test_Own_Context.Helpers
{
    static public class OptionsHelper<TContext> where TContext: DbContext
    {
        static public DbContextOptions<TContext> GetOptions()
        {
            var builder = new DbContextOptionsBuilder<TContext>();
            var options = builder.UseSqlServer(ConnectionStringHelper.ExternalString).Options;
            return options;
        }
    }
}
