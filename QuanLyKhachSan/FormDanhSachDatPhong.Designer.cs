namespace QuanLyKhachSan
{
    partial class FormDanhSachDatPhong
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbMahd = new System.Windows.Forms.Label();
            this.dgvDanhsachdatphong = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXacnhan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachdatphong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lbMahd);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnXacnhan);
            this.groupBox1.Controls.Add(this.dgvDanhsachdatphong);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(868, 495);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách đặt phòng";
            // 
            // lbMahd
            // 
            this.lbMahd.AutoSize = true;
            this.lbMahd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbMahd.Location = new System.Drawing.Point(19, 314);
            this.lbMahd.Name = "lbMahd";
            this.lbMahd.Size = new System.Drawing.Size(0, 13);
            this.lbMahd.TabIndex = 5;
            // 
            // dgvDanhsachdatphong
            // 
            this.dgvDanhsachdatphong.AllowUserToAddRows = false;
            this.dgvDanhsachdatphong.AllowUserToDeleteRows = false;
            this.dgvDanhsachdatphong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhsachdatphong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDanhsachdatphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhsachdatphong.Location = new System.Drawing.Point(12, 30);
            this.dgvDanhsachdatphong.Name = "dgvDanhsachdatphong";
            this.dgvDanhsachdatphong.ReadOnly = true;
            this.dgvDanhsachdatphong.Size = new System.Drawing.Size(844, 364);
            this.dgvDanhsachdatphong.TabIndex = 0;
            this.dgvDanhsachdatphong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhsachdatphong_CellContentClick);
            // 
            // button2
            // 
            this.button2.Image = global::QuanLyKhachSan.Properties.Resources.Back_64;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(606, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 72);
            this.button2.TabIndex = 7;
            this.button2.Text = "Trở lại";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::QuanLyKhachSan.Properties.Resources._1493962169_system_software_update;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(214, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 72);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cập Nhật";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Enabled = false;
            this.btnHuy.Image = global::QuanLyKhachSan.Properties.Resources._1493962109_Remove;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHuy.Location = new System.Drawing.Point(465, 411);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(99, 72);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy xác nhận";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXacnhan
            // 
            this.btnXacnhan.Enabled = false;
            this.btnXacnhan.Image = global::QuanLyKhachSan.Properties.Resources._1493962463_document_save_as;
            this.btnXacnhan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXacnhan.Location = new System.Drawing.Point(337, 411);
            this.btnXacnhan.Name = "btnXacnhan";
            this.btnXacnhan.Size = new System.Drawing.Size(95, 72);
            this.btnXacnhan.TabIndex = 1;
            this.btnXacnhan.Text = "Xác nhận";
            this.btnXacnhan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXacnhan.UseVisualStyleBackColor = true;
            this.btnXacnhan.Click += new System.EventHandler(this.btnXacnhan_Click);
            // 
            // FormDanhSachDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(868, 495);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDanhSachDatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Đặt Phòng";
            this.Load += new System.EventHandler(this.FormDanhSachDatPhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachdatphong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDanhsachdatphong;
        private System.Windows.Forms.Button btnXacnhan;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lbMahd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}