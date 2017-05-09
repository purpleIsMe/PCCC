using PCCC.Repositories.Infrastructure;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCC.Services.Configurations
{
    public class ServiceConfiguration
    {
        private static Container _container;

        public static Container Container { get { return _container; } }

        public static void Configure(Container container = null)
        {
            _container = container ?? new Container();
           _container.Configure(cfg => cfg.For<IUnitOfWork>().Use<UnitOfWork>());

            //Add another service here
            _container.Configure(cfg => cfg.For<ICityService>().Use<CityService>());
           

        }
    }
}
