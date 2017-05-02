using PCCC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCC.Services
{
    public interface ICityService
    {
        IEnumerable<City> GetAllCity();

        bool InsertCity(City city);

        bool InsertDistrict(District district);

        bool UpdateCity(City city);

        bool UpdateDistrict(District district);
    }
}
