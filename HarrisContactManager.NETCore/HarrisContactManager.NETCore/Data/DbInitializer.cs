using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarrisContactManager.NETCore.Data
{
    public class DbInitializer
    {
        public static void Initailize(HarrisDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
