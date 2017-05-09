using PCCC.Models;
using PCCC.Repositories.Infrastructure;
using PCCC.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PCCC.Repositories.Implements
{
    class FactorRepository:BaseRepository<Factor>, IFactorRepository
    {
         public FactorRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
            //nothing to do, the aim is transmit from DbFactory to BaseRepository
        }
    }
}
