using PCCC.Repositories.Configurations;
using PCCC.Services.Configurations;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCC.FormTest.Configurations
{
    public class StructureMapConfiguration
    {
        private static Container _container;

        public static Container Container { get { return _container; } }

        public static void Configure(Container container = null)
        {
            // create container
            _container = container ?? new Container();

            RepositoryConfiguration.Configure(_container);
            ServiceConfiguration.Configure(_container);

        }
    }
}
