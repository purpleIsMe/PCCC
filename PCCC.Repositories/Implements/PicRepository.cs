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
    public class PicRepository : BaseRepository<Picture>, IPicRepository
    {
        public PicRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
            
        }
    }
}
