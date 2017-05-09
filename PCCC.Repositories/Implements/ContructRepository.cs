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
    class ContructRepository:BaseRepository<Contruction>, IContructRepository
    {
        public ContructRepository(IDbFactory dbFactory): base(dbFactory)
        {
            
        }
    }
}
