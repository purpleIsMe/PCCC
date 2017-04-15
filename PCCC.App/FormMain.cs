using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCCC.App.Class;
using DevExpress.XtraSplashScreen;


namespace PCCC.App
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        TabAdd tab = new TabAdd();
        public FormMain()
        {
            InitializeComponent();
        }

        //phương thức gọi để add 1 tab vào giao diện chính với tham số là tiêu đề (title)
        //Tham số thứ 2 là UserControl  khởi tạo annoymous 
        //vd addTab("Tab", new UC_Tab_test());
        private void addTab(string title, UserControl uc)
        {
            SplashScreenManager.ShowForm(typeof(GUI.WaitLoadForm));
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabMain.TabPages)
            {
                if (tab.Text == title)
                {
                    xtraTabMain.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t != 1)
            {// Nếu chưa có TAb này thì gọi hàm Addtab xây dựng ở trên để Add Tab con vào
                tab.AddTab(xtraTabMain, "", title, uc);
            }
            SplashScreenManager.CloseForm();
        }

        //Xử lý nút close 1 tab
        private void xtraTabMain_CloseButtonClick(object sender, EventArgs e)
        {
            DevExpress.XtraTab.XtraTabControl tabControl = sender as DevExpress.XtraTab.XtraTabControl;
            DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs arg = e as DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs;
            (arg.Page as DevExpress.XtraTab.XtraTabPage).Dispose();
        }
        private void xtraTabMain_ControlAdded(object sender, ControlEventArgs e)
        {
            xtraTabMain.SelectedTabPageIndex = xtraTabMain.TabPages.Count - 1;
        }

        private void bbiTrangChu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addTab("Trang chủ", new UC.UCMain());
        }

        private void bbiTinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addTab("Quản lý tỉnh", new UC.UCCity());
        }

        private void bbiHuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addTab("Quản lý huyện", new UC.UCDistrict());
        }

    }
}
