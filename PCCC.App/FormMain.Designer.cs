namespace PCCC.App
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiTrangChu = new DevExpress.XtraBars.BarButtonItem();
            this.bbiTinh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiHuyen = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCongThuc = new DevExpress.XtraBars.BarButtonItem();
            this.bbiHS = new DevExpress.XtraBars.BarButtonItem();
            this.bbiHinhAnh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiChiTietHS = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.xtraTabMain = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabMain)).BeginInit();
            this.SuspendLayout();
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.Name = "applicationMenu1";
            this.applicationMenu1.Ribbon = this.ribbonControl1;
            this.applicationMenu1.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationButtonDropDownControl = this.applicationMenu1;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiTrangChu,
            this.bbiTinh,
            this.bbiHuyen,
            this.bbiCongThuc,
            this.bbiHS,
            this.bbiHinhAnh,
            this.bbiChiTietHS});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.Size = new System.Drawing.Size(971, 143);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above;
            // 
            // bbiTrangChu
            // 
            this.bbiTrangChu.Caption = "Trang chủ";
            this.bbiTrangChu.Id = 1;
            this.bbiTrangChu.LargeGlyph = global::PCCC.App.Properties.Resources.home_32x32;
            this.bbiTrangChu.Name = "bbiTrangChu";
            this.bbiTrangChu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiTrangChu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiTrangChu_ItemClick);
            // 
            // bbiTinh
            // 
            this.bbiTinh.Caption = "Tỉnh";
            this.bbiTinh.Id = 2;
            this.bbiTinh.LargeGlyph = global::PCCC.App.Properties.Resources.city;
            this.bbiTinh.Name = "bbiTinh";
            this.bbiTinh.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiTinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiTinh_ItemClick);
            // 
            // bbiHuyen
            // 
            this.bbiHuyen.Caption = "Huyện";
            this.bbiHuyen.Id = 3;
            this.bbiHuyen.LargeGlyph = global::PCCC.App.Properties.Resources.district;
            this.bbiHuyen.Name = "bbiHuyen";
            this.bbiHuyen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiHuyen_ItemClick);
            // 
            // bbiCongThuc
            // 
            this.bbiCongThuc.Caption = "Công thức";
            this.bbiCongThuc.Glyph = global::PCCC.App.Properties.Resources.autosum_16x16;
            this.bbiCongThuc.Id = 4;
            this.bbiCongThuc.LargeGlyph = global::PCCC.App.Properties.Resources.autosum_32x32;
            this.bbiCongThuc.Name = "bbiCongThuc";
            // 
            // bbiHS
            // 
            this.bbiHS.Caption = "Hệ số";
            this.bbiHS.Glyph = global::PCCC.App.Properties.Resources.showformulas_16x16;
            this.bbiHS.Id = 5;
            this.bbiHS.LargeGlyph = global::PCCC.App.Properties.Resources.showformulas_32x32;
            this.bbiHS.Name = "bbiHS";
            this.bbiHS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiHS_ItemClick);
            // 
            // bbiHinhAnh
            // 
            this.bbiHinhAnh.Caption = "Hình ảnh";
            this.bbiHinhAnh.Glyph = global::PCCC.App.Properties.Resources.image_16x16;
            this.bbiHinhAnh.Id = 6;
            this.bbiHinhAnh.LargeGlyph = global::PCCC.App.Properties.Resources.image_32x32;
            this.bbiHinhAnh.Name = "bbiHinhAnh";
            // 
            // bbiChiTietHS
            // 
            this.bbiChiTietHS.Caption = "Chi tiết hệ số";
            this.bbiChiTietHS.Glyph = global::PCCC.App.Properties.Resources.addcalculatedfield_16x16;
            this.bbiChiTietHS.Id = 8;
            this.bbiChiTietHS.LargeGlyph = global::PCCC.App.Properties.Resources.addcalculatedfield_32x32;
            this.bbiChiTietHS.Name = "bbiChiTietHS";
            this.bbiChiTietHS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiChiTietHS_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Trang chủ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiTrangChu);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Trang chủ";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Quản lý";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.Glyph = global::PCCC.App.Properties.Resources.home_32x32;
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiTinh);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiHuyen);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Quản lý tỉnh, huyện";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiCongThuc);
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiHS);
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiChiTietHS);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Công thức và hệ số";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.ItemLinks.Add(this.bbiHinhAnh);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            this.ribbonPageGroup4.Text = "Hình ảnh";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Hướng dẫn";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 668);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(971, 31);
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "navBarGroup1";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // xtraTabMain
            // 
            this.xtraTabMain.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader;
            this.xtraTabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabMain.Location = new System.Drawing.Point(0, 143);
            this.xtraTabMain.Name = "xtraTabMain";
            this.xtraTabMain.Size = new System.Drawing.Size(971, 525);
            this.xtraTabMain.TabIndex = 6;
            this.xtraTabMain.CloseButtonClick += new System.EventHandler(this.xtraTabMain_CloseButtonClick);
            this.xtraTabMain.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.xtraTabMain_ControlAdded);
            // 
            // FormMain
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Highlight;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 699);
            this.Controls.Add(this.xtraTabMain);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.MinimumSize = new System.Drawing.Size(830, 700);
            this.Name = "FormMain";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem bbiTrangChu;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiTinh;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem bbiHuyen;
        private DevExpress.XtraBars.BarButtonItem bbiCongThuc;
        private DevExpress.XtraBars.BarButtonItem bbiHS;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem bbiHinhAnh;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem bbiChiTietHS;
        private DevExpress.XtraTab.XtraTabControl xtraTabMain;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;

    }
}