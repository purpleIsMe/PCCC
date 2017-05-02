using PCCC.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCC.Repositories.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private PCCCEntities dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public PCCCEntities DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }

        public bool SaveChanges()
        {
            try
            {
                DbContext.SaveChanges();
                return true;
            }
            catch (OptimisticConcurrencyException ex)
            {
                //Log.Log.Entity(ex);
                return false;
            }
            catch (DbEntityValidationException ex)
            {
                //foreach (var eve in ex.EntityValidationErrors)
                //{
                //    //Log.Log.Entity(String.Format("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                //    //    eve.Entry.Entity.GetType().Name, eve.Entry.State));
                //    foreach (var ve in eve.ValidationErrors)
                //    {
                //        Log.Log.Entity(String.Format("- Property: \"{0}\", Error: \"{1}\"",
                //            ve.PropertyName, ve.ErrorMessage));
                //    }
                //}

                //Log.Log.Entity(ex);
                return false;
            }
            catch (Exception ex)
            {
                //Log.Log.Entity(ex);
                return false;
            }
        }
    }
}
