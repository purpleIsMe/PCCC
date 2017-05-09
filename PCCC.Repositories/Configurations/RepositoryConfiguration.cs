using PCCC.DAL;
using PCCC.Repositories.Implements;
using PCCC.Repositories.Infrastructure;
using PCCC.Repositories.Interfaces;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCC.Repositories.Configurations
{
    public class RepositoryConfiguration
    {

        private static Container _container;

        public static Container Container { get { return _container; } }

        public static void Configure(Container container = null)
        {
            _container = container ?? new Container();
            _container.Configure(cfg => cfg.For<DbContext>().Use<PCCCEntities>());
            _container.Configure(cfg => cfg.For<IDbFactory>().Use<DbFactory>());
            //Add another repository here
            _container.Configure(cfg => cfg.For<ICityRepository>().Use<CityRepository>());
            _container.Configure(cfg => cfg.For<IDistrictRepository>().Use<DistrictRepository>());

        }
    }
}
