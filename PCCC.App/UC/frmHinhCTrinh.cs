using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCCC.App.UC
{
    public partial class frmHinhCTrinh : Form
    {
        public frmHinhCTrinh()
        {
            InitializeComponent();
        }
        
        private void picbox1_Click(object sender, EventArgs e)
        {
            string img = picbox1.Name;
            //hinh.SetPic(img);
        }

        private void picbox2_Click(object sender, EventArgs e)
        {
            string img = picbox2.Name;
            //hinh.SetPic(img);
        }

        private void picbox3_Click(object sender, EventArgs e)
        {
            string img = picbox3.Name;
            //hinh.SetPic(img);
        }

        private void picbox4_Click(object sender, EventArgs e)
        {
            string img = picbox4.Name;
            //hinh.SetPic(img);
        }
    }
}
