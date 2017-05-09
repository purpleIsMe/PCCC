using PCCC.Models;
using PCCC.Repositories.Infrastructure;
using PCCC.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PCCC.Repositories.Implements
{
    class FormulaRepository:BaseRepository<Formula>, IFormulaRepository 
    {
        public FormulaRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
            
        }
    }
}
