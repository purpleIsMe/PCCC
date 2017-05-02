using PCCC.Models;
using PCCC.Repositories.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCC.Repositories.Interfaces
{
    public interface ICityRepository : IBaseRepository<City>
    {
        //cái này cũng k làm gì luôn
        //Để viết các phương thức mở rộng của repository.
        //Vd nó đã có delete theo id và delete the 1 object. ở city e muốn delete theo tên đi thì viết như sau
        bool Delete(string cityName);
    }
}
