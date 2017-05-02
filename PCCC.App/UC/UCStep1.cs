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
    public partial class UCStep1 : UserControl
    {
        public UCStep1()
        {
            InitializeComponent();
            ChooseGroup();
        }

        private void pbxNha_Click(object sender, EventArgs e)
        {
            frmHinhCTrinh ct = new frmHinhCTrinh();
            ct.ShowDialog();

            
        }
        public void ChooseGroup()
        {
            UCMain main = new UCMain();
            MessageBox.Show(main.NameStep);
            if(main.NameStep == "Step1_1")
            {
                gbStep1_1.ForeColor = Color.Red;
                MessageBox.Show("đã vào được");
            }
            if (main.NameStep == "Step1_2")
            {
                gbStep1_2.ForeColor = Color.Red;
            }
            if (main.NameStep == "Step1_3")
            {
                gbStep1_3.ForeColor = Color.Red;
            }
        }
    }
}
