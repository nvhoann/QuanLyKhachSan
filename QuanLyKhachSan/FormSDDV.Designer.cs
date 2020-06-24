namespace QuanLyKhachSan
{
    partial class FormSDDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSDDV));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.nrSoluong = new System.Windows.Forms.NumericUpDown();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvDichvukhachhang = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThanhtoan = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbDichvu = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvSudungdichvu = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrSoluong)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichvukhachhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSudungdichvu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.btnlammoi);
            this.groupBox4.Controls.Add(this.nrSoluong);
            this.groupBox4.Controls.Add(this.txtGia);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.btnThoat);
            this.groupBox4.Controls.Add(this.btnThanhtoan);
            this.groupBox4.Controls.Add(this.btnThem);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.cbbDichvu);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtMaHD);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.dgvSudungdichvu);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(-1, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(869, 495);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sử dụng dịch vụ";
            // 
            // btnlammoi
            // 
            this.btnlammoi.Image = global::QuanLyKhachSan.Properties.Resources._1493962169_system_software_update;
            this.btnlammoi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnlammoi.Location = new System.Drawing.Point(316, 178);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(75, 54);
            this.btnlammoi.TabIndex = 16;
            this.btnlammoi.Text = "Làm Mới";
            this.btnlammoi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // nrSoluong
            // 
            this.nrSoluong.Enabled = false;
            this.nrSoluong.Location = new System.Drawing.Point(154, 112);
            this.nrSoluong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nrSoluong.Name = "nrSoluong";
            this.nrSoluong.Size = new System.Drawing.Size(75, 20);
            this.nrSoluong.TabIndex = 15;
            this.nrSoluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtGia
            // 
            this.txtGia.Enabled = false;
            this.txtGia.Location = new System.Drawing.Point(154, 86);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(132, 20);
            this.txtGia.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Giá";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvDichvukhachhang);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox5.Location = new System.Drawing.Point(3, 260);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(863, 232);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Những dịch vụ khách hàng đã sử dụng";
            // 
            // dgvDichvukhachhang
            // 
            this.dgvDichvukhachhang.AllowUserToAddRows = false;
            this.dgvDichvukhachhang.AllowUserToDeleteRows = false;
            this.dgvDichvukhachhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDichvukhachhang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDichvukhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichvukhachhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDichvukhachhang.Location = new System.Drawing.Point(3, 16);
            this.dgvDichvukhachhang.Name = "dgvDichvukhachhang";
            this.dgvDichvukhachhang.ReadOnly = true;
            this.dgvDichvukhachhang.Size = new System.Drawing.Size(857, 213);
            this.dgvDichvukhachhang.TabIndex = 11;
            // 
            // btnThoat
            // 
            this.btnThoat.Enabled = false;
            this.btnThoat.Image = global::QuanLyKhachSan.Properties.Resources._1493962109_Remove;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat.Location = new System.Drawing.Point(235, 178);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 54);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Hủy";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThanhtoan
            // 
            this.btnThanhtoan.Enabled = false;
            this.btnThanhtoan.Image = global::QuanLyKhachSan.Properties.Resources.thue;
            this.btnThanhtoan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThanhtoan.Location = new System.Drawing.Point(154, 178);
            this.btnThanhtoan.Name = "btnThanhtoan";
            this.btnThanhtoan.Size = new System.Drawing.Size(75, 54);
            this.btnThanhtoan.TabIndex = 9;
            this.btnThanhtoan.Text = "Thanh toán";
            this.btnThanhtoan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThanhtoan.UseVisualStyleBackColor = true;
            this.btnThanhtoan.Click += new System.EventHandler(this.btnThanhtoan_Click);
            // 
            // btnThem
            // 
            this.btnThem.Enabled = false;
            this.btnThem.Image = global::QuanLyKhachSan.Properties.Resources._1493961897_insert_object;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(73, 178);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 54);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Số lượng";
            // 
            // cbbDichvu
            // 
            this.cbbDichvu.Enabled = false;
            this.cbbDichvu.FormattingEnabled = true;
            this.cbbDichvu.Location = new System.Drawing.Point(154, 59);
            this.cbbDichvu.Name = "cbbDichvu";
            this.cbbDichvu.Size = new System.Drawing.Size(319, 21);
            this.cbbDichvu.TabIndex = 4;
            this.cbbDichvu.SelectedIndexChanged += new System.EventHandler(this.cbbDichvu_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Dịch vụ";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Enabled = false;
            this.txtMaHD.Location = new System.Drawing.Point(154, 33);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(132, 20);
            this.txtMaHD.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(70, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Mã hợp đồng";
            // 
            // dgvSudungdichvu
            // 
            this.dgvSudungdichvu.AllowUserToAddRows = false;
            this.dgvSudungdichvu.AllowUserToDeleteRows = false;
            this.dgvSudungdichvu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSudungdichvu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSudungdichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSudungdichvu.Location = new System.Drawing.Point(542, 12);
            this.dgvSudungdichvu.Name = "dgvSudungdichvu";
            this.dgvSudungdichvu.ReadOnly = true;
            this.dgvSudungdichvu.Size = new System.Drawing.Size(321, 242);
            this.dgvSudungdichvu.TabIndex = 0;
            this.dgvSudungdichvu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSudungdichvu_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "Trở lại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormSDDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(868, 495);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSDDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dịch Vụ";
            this.Load += new System.EventHandler(this.FormSDDV_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrSoluong)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichvukhachhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSudungdichvu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvDichvukhachhang;
        private System.Windows.Forms.Button btnThanhtoan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbDichvu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvSudungdichvu;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nrSoluong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.Button button1;
    }
}