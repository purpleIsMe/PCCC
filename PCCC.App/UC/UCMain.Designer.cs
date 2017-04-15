namespace PCCC.App.UC
{
    partial class UCMain
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.nbgStep1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbgStep234 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbgStep5 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbgStep6 = new DevExpress.XtraNavBar.NavBarGroup();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.navBarControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(830, 600);
            this.splitContainerControl1.SplitterPosition = 231;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.nbgStep1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.nbgStep1,
            this.nbgStep234,
            this.nbgStep5,
            this.nbgStep6});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.Size = new System.Drawing.Size(231, 600);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinNavigationPaneViewInfoRegistrator("Office 2010 Blue");
            // 
            // nbgStep1
            // 
            this.nbgStep1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.nbgStep1.Appearance.Options.UseFont = true;
            this.nbgStep1.Caption = "Xác định xây dựng hệ thống chống sét";
            this.nbgStep1.Expanded = true;
            this.nbgStep1.Name = "nbgStep1";
            // 
            // nbgStep234
            // 
            this.nbgStep234.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.nbgStep234.Appearance.Options.UseFont = true;
            this.nbgStep234.Caption = "Kiểm tra hệ thống chống sét";
            this.nbgStep234.Name = "nbgStep234";
            // 
            // nbgStep5
            // 
            this.nbgStep5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.nbgStep5.Appearance.Options.UseFont = true;
            this.nbgStep5.Caption = "Kiểm tra vùng bảo vệ hệ thống";
            this.nbgStep5.Name = "nbgStep5";
            // 
            // nbgStep6
            // 
            this.nbgStep6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.nbgStep6.Appearance.Options.UseFont = true;
            this.nbgStep6.Caption = "Kiểm tra hệ thống nổi đất";
            this.nbgStep6.Name = "nbgStep6";
            // 
            // UCMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "UCMain";
            this.Size = new System.Drawing.Size(830, 600);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup nbgStep1;
        private DevExpress.XtraNavBar.NavBarGroup nbgStep234;
        private DevExpress.XtraNavBar.NavBarGroup nbgStep5;
        private DevExpress.XtraNavBar.NavBarGroup nbgStep6;

    }
}
