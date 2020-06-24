namespace QuanLyKhachSan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnkh = new System.Windows.Forms.ToolStripMenuItem();
            this.btndichvu = new System.Windows.Forms.ToolStripMenuItem();
            this.btndsdp = new System.Windows.Forms.ToolStripMenuItem();
            this.btnthanhtoan = new System.Windows.Forms.ToolStripMenuItem();
            this.btnhelp = new System.Windows.Forms.ToolStripButton();
            this.btndangxuat = new System.Windows.Forms.ToolStripButton();
            this.lbltenandloai = new System.Windows.Forms.ToolStripLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.btnhelp,
            this.btndangxuat,
            this.lbltenandloai});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(884, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnkh,
            this.btndichvu,
            this.btndsdp,
            this.btnthanhtoan});
            this.toolStripDropDownButton1.Image = global::QuanLyKhachSan.Properties.Resources._1493874144_menu;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(67, 22);
            this.toolStripDropDownButton1.Text = "Menu";
            // 
            // btnkh
            // 
            this.btnkh.Image = global::QuanLyKhachSan.Properties.Resources._1493872786_User_group;
            this.btnkh.Name = "btnkh";
            this.btnkh.Size = new System.Drawing.Size(189, 22);
            this.btnkh.Text = "Khách Hàng";
           // this.btnkh.Click += new System.EventHandler(this.btnkh_Click);
            // 
            // btndichvu
            // 
            this.btndichvu.Image = global::QuanLyKhachSan.Properties.Resources.dichvu;
            this.btndichvu.Name = "btndichvu";
            this.btndichvu.Size = new System.Drawing.Size(189, 22);
            this.btndichvu.Text = "Dịch Vụ";
          //  this.btndichvu.Click += new System.EventHandler(this.btndichvu_Click);
            // 
            // btndsdp
            // 
            this.btndsdp.Image = global::QuanLyKhachSan.Properties.Resources.vatdung;
            this.btndsdp.Name = "btndsdp";
            this.btndsdp.Size = new System.Drawing.Size(189, 22);
            this.btndsdp.Text = "Danh Sách Đặt Phòng";
         //   this.btndsdp.Click += new System.EventHandler(this.btndsdp_Click);
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.Image = global::QuanLyKhachSan.Properties.Resources.phong;
            this.btnthanhtoan.Name = "btnthanhtoan";
            this.btnthanhtoan.Size = new System.Drawing.Size(189, 22);
            this.btnthanhtoan.Text = "Phòng";
           // this.btnthanhtoan.Click += new System.EventHandler(this.btnthanhtoan_Click);
            // 
            // btnhelp
            // 
            this.btnhelp.Image = global::QuanLyKhachSan.Properties.Resources._1493873182_help_browser;
            this.btnhelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnhelp.Name = "btnhelp";
            this.btnhelp.Size = new System.Drawing.Size(72, 22);
            this.btnhelp.Text = "&Trợ Giúp";
            this.btnhelp.Click += new System.EventHandler(this.btnhelp_Click);
            // 
            // btndangxuat
            // 
            this.btndangxuat.Image = global::QuanLyKhachSan.Properties.Resources._1493874057_logout;
            this.btndangxuat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btndangxuat.Name = "btndangxuat";
            this.btndangxuat.Size = new System.Drawing.Size(82, 22);
            this.btndangxuat.Text = "&Đăng Xuất";
            this.btndangxuat.Click += new System.EventHandler(this.btndangxuat_Click);
            // 
            // lbltenandloai
            // 
            this.lbltenandloai.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lbltenandloai.Name = "lbltenandloai";
            this.lbltenandloai.Size = new System.Drawing.Size(99, 22);
            this.lbltenandloai.Text = "Chào User Name ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Khách hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Danh sách đặt phòng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(414, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Dịch vụ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(558, 82);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Phòng";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(696, 82);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Trợ giúp";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
 //           this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripButton btnhelp;
        private System.Windows.Forms.ToolStripButton btndangxuat;
        private System.Windows.Forms.ToolStripLabel lbltenandloai;
        private System.Windows.Forms.ToolStripMenuItem btnkh;
        private System.Windows.Forms.ToolStripMenuItem btndichvu;
        private System.Windows.Forms.ToolStripMenuItem btndsdp;
        private System.Windows.Forms.ToolStripMenuItem btnthanhtoan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

