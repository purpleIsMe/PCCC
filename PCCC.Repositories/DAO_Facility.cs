using System;
using System.Collections.Generic;
using System.Linq;
using PCCC.DAL;
using System.Windows.Forms;
namespace PCCC.Repositories
{
    class DAO_Facility: Repository<Facility>
    {
        public List<Facility> All()
        {
            var listFacility = from a in dataContext.Facilities select a;
            return listFacility.ToList();
        }
        public bool ThemDieuKhoan(int id, string name, string yeuCau, string dieuKhoan, bool kq)
        {
            try
            {
                Facility fa = new Facility();
                fa.ID = id;
                fa.Name = name;
                fa.Request = yeuCau;
                fa.Rules = dieuKhoan;
                fa.Result = kq;
                dataContext.Facilities.InsertOnSubmit(fa);
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu không hợp lệ. Xin vui lòng kiểm tra lại!");
                return false;
            }
        }
        public bool SuaDieuKhoan(int id, string name, string yeuCau, string dieuKhoan, bool kq)
        {
            try
            {
                Facility fa = dataContext.Facilities.Single(x => x.ID == id);
                fa.Name = name;
                fa.Request = yeuCau;
                fa.Rules = dieuKhoan;
                fa.Result = kq;
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu không hợp lệ. Xin vui lòng kiểm tra lại!");
                return false;
            }
        }
        public bool XoaDieuKhoan(int id)
        {
            try
            {
                Facility fa = dataContext.Facilities.Single(i => i.ID == id);
                dataContext.Facilities.DeleteOnSubmit(fa);
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
