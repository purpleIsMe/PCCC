using PCCC.Models;
using PCCC.Repositories.Infrastructure;
using PCCC.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PCCC.Repositories.Implements
{
    public class FacilityRepository : BaseRepository<Facility>, IFacilityRepository
    {
         public FacilityRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
            
        }
    }
}
