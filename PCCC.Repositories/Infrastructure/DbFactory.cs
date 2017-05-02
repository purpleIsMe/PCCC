using PCCC.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCC.Repositories.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private PCCCEntities dbContext;

        public PCCCEntities Init()
        {
            return dbContext ?? (dbContext = new PCCCEntities());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}
