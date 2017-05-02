using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using PCCC.ConsoleTest.Configurations;

[assembly: OwinStartup(typeof(PCCC.ConsoleTest.Startup))]

namespace PCCC.ConsoleTest
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            StructureMapConfiguration.Configure();
        }
    }
}
