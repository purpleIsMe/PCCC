namespace PCCC.App.UC
{
    partial class frmHinhCTrinh
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
            this.picbox4 = new System.Windows.Forms.PictureBox();
            this.picbox3 = new System.Windows.Forms.PictureBox();
            this.picbox2 = new System.Windows.Forms.PictureBox();
            this.picbox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picbox4
            // 
            this.picbox4.Location = new System.Drawing.Point(609, 12);
            this.picbox4.Name = "picbox4";
            this.picbox4.Size = new System.Drawing.Size(174, 193);
            this.picbox4.TabIndex = 0;
            this.picbox4.TabStop = false;
            this.picbox4.Click += new System.EventHandler(this.picbox4_Click);
            // 
            // picbox3
            // 
            this.picbox3.Location = new System.Drawing.Point(407, 12);
            this.picbox3.Name = "picbox3";
            this.picbox3.Size = new System.Drawing.Size(174, 193);
            this.picbox3.TabIndex = 0;
            this.picbox3.TabStop = false;
            this.picbox3.Click += new System.EventHandler(this.picbox3_Click);
            // 
            // picbox2
            // 
            this.picbox2.Location = new System.Drawing.Point(209, 12);
            this.picbox2.Name = "picbox2";
            this.picbox2.Size = new System.Drawing.Size(174, 193);
            this.picbox2.TabIndex = 0;
            this.picbox2.TabStop = false;
            this.picbox2.Click += new System.EventHandler(this.picbox2_Click);
            // 
            // picbox1
            // 
            this.picbox1.Location = new System.Drawing.Point(12, 12);
            this.picbox1.Name = "picbox1";
            this.picbox1.Size = new System.Drawing.Size(174, 193);
            this.picbox1.TabIndex = 0;
            this.picbox1.TabStop = false;
            this.picbox1.Click += new System.EventHandler(this.picbox1_Click);
            // 
            // frmHinhCTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 218);
            this.Controls.Add(this.picbox4);
            this.Controls.Add(this.picbox3);
            this.Controls.Add(this.picbox2);
            this.Controls.Add(this.picbox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmHinhCTrinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xin mời bạn chọn kiểu công trình";
            ((System.ComponentModel.ISupportInitialize)(this.picbox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox1;
        private System.Windows.Forms.PictureBox picbox2;
        private System.Windows.Forms.PictureBox picbox3;
        private System.Windows.Forms.PictureBox picbox4;
    }
}