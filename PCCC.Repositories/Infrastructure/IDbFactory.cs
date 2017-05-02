using PCCC.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCC.Repositories.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        PCCCEntities Init();
    }
}
