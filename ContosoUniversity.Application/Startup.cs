using ContosoUniversity.Application.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

[assembly: PreApplicationStartMethod(typeof(ContosoUniversity.Application.Startup), "Start")]
namespace ContosoUniversity.Application
{
    public class Startup
    {
        public static void Start()
        {
            AutoMapperConfig.ConfigureMappings();
        }
    }
}
