using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCCC.App.UC
{
    public partial class UCMain : UserControl
    {
        public UCMain()
        {
            InitializeComponent();
        }

        private void nbiStep1_1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            // Xóa hết controls đang tồn tại trong palContent (nếu có)
            this.palContent.Controls.Clear();
            //add form step 1 vào panel
           // UCStep1 step = new UCStep1();
           // step.Top = false;

            var myControl = new PCCC.App.UC.UCStep1();  //MyProject.Modules.Masters();
            palContent.Controls.Add(myControl);
            

            //step.Show();

            

            //Form2 frmChild = new Form2();
           // frmChild.TopLevel = false;
            // Gắn vào panel
           // this.panel1.Controls.Add(frmChild);


            // Hiển thị form
          //  frmChild.Show();
        }
    }
}
