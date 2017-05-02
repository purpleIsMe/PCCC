using PCCC.ConsoleTest.Configurations;
using PCCC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCC.ConsoleTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            var cityService = StructureMapConfiguration.Container.GetInstance<ICityService>();

            Console.WriteLine(cityService.testMethod());
            Console.ReadKey();
        }
    }
}
