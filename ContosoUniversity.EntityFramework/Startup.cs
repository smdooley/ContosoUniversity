using ContosoUniversity.EntityFramework.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

[assembly: PreApplicationStartMethod(typeof(ContosoUniversity.EntityFramework.Startup), "Start")]
namespace ContosoUniversity.EntityFramework
{
    public class Startup
    {
        public static void Start()
        {
        }
    }
}
