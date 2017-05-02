using System;
using System.Collections.Generic;
using System.Linq;
using PCCC.DAL;

namespace PCCC.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> All();

        IEnumerable<T> FindAll(Func<T, bool> exp);

        T Single(Func<T, bool> exp);

        //T First(Func<T, bool> exp);

        //void MarkForDeletion(T entity);

        // T CreateInstance();

        void SaveAll();

        void Insert(T entity);

        void InsertList(IEnumerable<T> listEntity);

        void Delete(T entity);

    }

    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected PCCCDataContextDataContext dataContext { get; set; }
        //chon tat ca the record in the table
        public IEnumerable<T> All()
        {
            return GetTable;
        }
        //tim kiem tat ca the record in the table have expect
        public IEnumerable<T> FindAll(Func<T, bool> exp)
        {
            return GetTable.Where<T>(exp);
        }
        //lay 1 record trong table
        public T Single(Func<T, bool> exp)
        {
            return GetTable.Single(exp);
        }
        // cai nay lam chuc nang gi? tai sao lai can?
        //public T First(Func<T, bool> exp)
        //{
        //    return GetTable.First(exp);
        //}
        // cai nay lam chuc nang gi? tai sao lai can?
        //public virtual void MarkForDeletion(T entity)
        //{
        //    dataContext.GetTable<T>().DeleteOnSubmit(entity);
        //}
        // cai nay lam chuc nang gi? tai sao lai can?
        /*pblic virtual T CreateInstance()
        {
            T entity = Activator.CreateInstance<T>();
            GetTable.InsertOnSubmit(entity);
            return entity;
        }*/
        //luu lai tat ca record
        public void SaveAll()
        {
            try
            {
                dataContext.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        //them vao voi danh sach chen vao
        public void InsertList(IEnumerable<T> listEntity)
        {
            GetTable.InsertAllOnSubmit(listEntity);
            SaveAll();
        }

        public void Insert(T entity)
        {
            GetTable.InsertOnSubmit(entity);
            SaveAll();
        }

        public void Delete(T entity)
        {
            GetTable.DeleteOnSubmit(entity);
        }
        //ket noi vs CSDL = cach goi lai class
        public Repository()
        {
            dataContext = new PCCCDataContextDataContext();
        }

        #region Properties

        private string PrimaryKeyName
        {
            get { return TableMetadata.RowType.IdentityMembers[0].Name; }
        }

        private System.Data.Linq.Table<T> GetTable
        {
            get { return dataContext.GetTable<T>(); }
        }

        private System.Data.Linq.Mapping.MetaTable TableMetadata
        {
            get { return dataContext.Mapping.GetTable(typeof(T)); }
        }

        private System.Data.Linq.Mapping.MetaType ClassMetadata
        {
            get { return dataContext.Mapping.GetMetaType(typeof(T)); }
        }

        #endregion
    }
}
