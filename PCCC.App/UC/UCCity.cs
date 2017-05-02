using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PCCC.Services;

namespace PCCC.App.UC
{
    public partial class UCCity : UserControl
    {
        public UCCity()
        {
            InitializeComponent();
            gridControl();
        }
        public void gridControl()
        {
            
            //var list = new BUS_City().LayDSTP().Select(i => new
            //{
            //    ID = i.ID,
            //    nameCity = i.Name,
            //    codeCity = i.CCity
            //});
            //gctCity.DataSource = list;
        }
        private bool CatchError()
        {
            if (txtMaTP.Text==""||txtTenTP.Text=="")
            {
                MessageBox.Show("Xin hãy điền đầy đủ thông tin","Thông báo");
                return false;
            }
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CatchError())
            {
                
            }
        }

    }
}
