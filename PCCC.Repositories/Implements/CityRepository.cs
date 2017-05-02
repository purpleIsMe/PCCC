using PCCC.Models;
using PCCC.Repositories.Infrastructure;
using PCCC.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCC.Repositories.Implements
{
    public class CityRepository : BaseRepository<City>, ICityRepository
    {
        public CityRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
            //trong đây sẽ làm gì?
            //Cái này là contruct để implement cái contruct của class kế thừa
            //Gọi là kế thừa contructor, ko để làm gì cả :)) mục đích là truyển cái dbFactory vào base 
        }

        public bool Delete(string cityName)
        {
            //e sẽ implement pt đó
            var findObjectBeforeDelete = GetSingleByCondition(x => x.Name == cityName);
            if (findObjectBeforeDelete != null)
            {
                Delete(findObjectBeforeDelete);
                return true;
            }
            return false;
            
        }
    }
}
