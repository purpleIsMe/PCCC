using PCCC.FormTest.Configurations;
using PCCC.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCCC.FormTest
{
    public partial class Form1 : Form
    {
        private readonly ICityService _cityService;
        public Form1()
        {
            InitializeComponent();
            _cityService = StructureMapConfiguration.Container.GetInstance<ICityService>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = _cityService.testMethod();
        }
    }
}
