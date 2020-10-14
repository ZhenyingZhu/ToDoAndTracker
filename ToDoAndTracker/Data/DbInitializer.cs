using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAndTracker.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // zhenying: comment out to test identity.
            // test user password: "G{^p6["
            //if (context.Projects.Any())
            //{
            //    return;
            //}
        }
    }
}
