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
        private string s_nameStep;
        public string NameStep { get { return s_nameStep; } set { s_nameStep = value; } }

        private void nbiStep1_1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            // Xóa hết controls đang tồn tại trong palContent (nếu có)
            this.palContent.Controls.Clear();
            s_nameStep = "Step1_1";
            //add form step 1 vào panel
            var myControl = new PCCC.App.UC.UCStep1();
            palContent.Controls.Add(myControl);
            myControl.Show();
        }

        private void nbiStep1_2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            // Xóa hết controls đang tồn tại trong palContent (nếu có)
            this.palContent.Controls.Clear();
            s_nameStep = "Step1_2";
            //add form step 1 vào panel
            var myControl = new PCCC.App.UC.UCStep1();
            palContent.Controls.Add(myControl);
            myControl.Show();
        }

        private void bviStep1_3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            // Xóa hết controls đang tồn tại trong palContent (nếu có)
            this.palContent.Controls.Clear();
            s_nameStep = "Step1_3";
            //add form step 1 vào panel
            var myControl = new PCCC.App.UC.UCStep1();
            //var step3 = myControl.Controls.Find("gbStep1_3", true);
            //var step2 = myControl.Controls.Find("gbStep1_2", true);
            palContent.Controls.Add(myControl);
            myControl.Show();
        }
    }
}
