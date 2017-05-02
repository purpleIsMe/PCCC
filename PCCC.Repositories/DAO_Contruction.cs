using System;
using System.Collections.Generic;
using System.Linq;
using PCCC.DAL;
using System.Windows.Forms;

namespace PCCC.Repositories
{
    class DAO_Contruction: Repository<Contruction>
    {
        public List<Contruction> All()
        {
            var listCon = from a in dataContext.Contructions select a;
            return listCon.ToList();
        }
        public bool ThemCT(int id, string sign, int idFormula, double val, string detail, int idPic)
        {
            try
            {
                Contruction con = new Contruction();
                con.ID = id;
                con.SignCon = sign;
                con.IDFormula = idFormula;
                con.Value = val;
                con.Detail = detail;
                dataContext.Contructions.InsertOnSubmit(con);
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu không hợp lệ. Xin vui lòng kiểm tra lại!");
                return false;
            }
        }
        public bool SuaCT(int id, string sign, int idFormula, double val, string detail, int idPic)
        {
            try
            {
                Contruction con = dataContext.Contructions.Single(x => x.ID == id);
                con.SignCon = sign;
                con.IDFỏmula = idFormula;
                con.Value = val;
                con.Detail = detail;
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu không hợp lệ. Xin vui lòng kiểm tra lại!");
                return false;
            }
        }
        public bool XoaCT(int id)
        {
            try
            {
                Contruction con = dataContext.Contructions.Single(i => i.ID == id);
                dataContext.Contructions.DeleteOnSubmit(con);
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
