using System;
using System.Collections.Generic;
using System.Linq;
using PCCC.DAL;
using System.Windows.Forms;

namespace PCCC.Repositories
{
    class DAO_DetailFactor: Repository<DetailFactor>
    {
        public List<DetailFactor> All()
        {
            var listDetailFactor = from a in dataContext.DetailFactors select a;
            return listDetailFactor.ToList();
        }
        public bool ThemHeSo(int id, int idFac, double val, string sign, string detail, bool sta)
        {
            try
            {
                DetailFactor de = new DetailFactor();
                de.ID = id;
                de.IDFactor = idFac;
                de.Value = val;
                de.SignFactor = sign;
                de.Detail = detail;
                de.Statuses = sta;
                dataContext.DetailFactors.InsertOnSubmit(de);
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu không hợp lệ. Xin vui lòng kiểm tra lại!");
                return false;
            }
        }
        public bool SuaHeSo(int id, int idFac, double val, string sign, string detail, bool sta)
        {
            try
            {
                DetailFactor de = dataContext.DetailFactors.Single(x => x.ID == id);
                de.IDFactor = idFac;
                de.Value = val;
                de.SignFactor = sign;
                de.Detail = detail;
                de.Statuses = sta;
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu không hợp lệ. Xin vui lòng kiểm tra lại!");
                return false;
            }
        }
        public bool XoaHeSo(int id)
        {
            try
            {
                DetailFactor de = dataContext.DetailFactors.Single(i => i.ID == id);
                dataContext.DetailFactors.DeleteOnSubmit(de);
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu không hợp lệ. Xin vui lòng kiểm tra lại!");
                return false;
            }
        }
    }
}
