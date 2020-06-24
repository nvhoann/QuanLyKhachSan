namespace QuanLyKhachSan
{
    partial class FormKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhachHang));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtTienCoc = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbDanhSachPhong = new System.Windows.Forms.ComboBox();
            this.cbHinhThuc = new System.Windows.Forms.ComboBox();
            this.dtpNhanPhong = new System.Windows.Forms.DateTimePicker();
            this.grListCustomer = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDangKi = new System.Windows.Forms.Button();
            this.grInfo = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnHuy = new System.Windows.Forms.ToolStripButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.grListCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.grInfo.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtTienCoc);
            this.groupBox4.Controls.Add(this.txtMaHD);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.cbbDanhSachPhong);
            this.groupBox4.Controls.Add(this.cbHinhThuc);
            this.groupBox4.Controls.Add(this.dtpNhanPhong);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(868, 117);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Đặt phòng";
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.Location = new System.Drawing.Point(551, 45);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.Size = new System.Drawing.Size(237, 20);
            this.txtTienCoc.TabIndex = 12;
            this.txtTienCoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTienCoc_KeyPress);
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(155, 17);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(237, 20);
            this.txtMaHD.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(469, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Đặt cọc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Mã HĐ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(453, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Danh sách phòng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Thời gian thuê";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hình thức ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cbbDanhSachPhong
            // 
            this.cbbDanhSachPhong.FormattingEnabled = true;
            this.cbbDanhSachPhong.Location = new System.Drawing.Point(551, 16);
            this.cbbDanhSachPhong.Name = "cbbDanhSachPhong";
            this.cbbDanhSachPhong.Size = new System.Drawing.Size(236, 21);
            this.cbbDanhSachPhong.TabIndex = 3;
            // 
            // cbHinhThuc
            // 
            this.cbHinhThuc.FormattingEnabled = true;
            this.cbHinhThuc.Location = new System.Drawing.Point(155, 45);
            this.cbHinhThuc.Name = "cbHinhThuc";
            this.cbHinhThuc.Size = new System.Drawing.Size(237, 21);
            this.cbHinhThuc.TabIndex = 1;
            this.cbHinhThuc.SelectedIndexChanged += new System.EventHandler(this.cbHinhThuc_SelectedIndexChanged);
            // 
            // dtpNhanPhong
            // 
            this.dtpNhanPhong.Location = new System.Drawing.Point(155, 77);
            this.dtpNhanPhong.Name = "dtpNhanPhong";
            this.dtpNhanPhong.Size = new System.Drawing.Size(237, 20);
            this.dtpNhanPhong.TabIndex = 0;
            // 
            // grListCustomer
            // 
            this.grListCustomer.Controls.Add(this.txtTimKiem);
            this.grListCustomer.Controls.Add(this.dgvKhachHang);
            this.grListCustomer.Controls.Add(this.label11);
            this.grListCustomer.Controls.Add(this.btnDangKi);
            this.grListCustomer.Location = new System.Drawing.Point(0, 123);
            this.grListCustomer.Name = "grListCustomer";
            this.grListCustomer.Size = new System.Drawing.Size(868, 178);
            this.grListCustomer.TabIndex = 11;
            this.grListCustomer.TabStop = false;
            this.grListCustomer.Text = "Danh sách khách hàng";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(157, 29);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(235, 20);
            this.txtTimKiem.TabIndex = 14;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToAddRows = false;
            this.dgvKhachHang.AllowUserToDeleteRows = false;
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Location = new System.Drawing.Point(6, 70);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.Size = new System.Drawing.Size(862, 88);
            this.dgvKhachHang.TabIndex = 0;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            this.dgvKhachHang.DoubleClick += new System.EventHandler(this.dgvKhachHang_DoubleClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(62, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Tìm kiếm KH :";
            // 
            // btnDangKi
            // 
            this.btnDangKi.Image = global::QuanLyKhachSan.Properties.Resources._1494101394_list_add_user;
            this.btnDangKi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangKi.Location = new System.Drawing.Point(579, 13);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(88, 51);
            this.btnDangKi.TabIndex = 4;
            this.btnDangKi.Text = "Đăng kí";
            this.btnDangKi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangKi.UseVisualStyleBackColor = true;
            this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
            // 
            // grInfo
            // 
            this.grInfo.Controls.Add(this.button2);
            this.grInfo.Controls.Add(this.toolStrip1);
            this.grInfo.Controls.Add(this.label5);
            this.grInfo.Controls.Add(this.dtpNgaySinh);
            this.grInfo.Controls.Add(this.rdbNu);
            this.grInfo.Controls.Add(this.rdbNam);
            this.grInfo.Controls.Add(this.txtCMND);
            this.grInfo.Controls.Add(this.label4);
            this.grInfo.Controls.Add(this.label3);
            this.grInfo.Controls.Add(this.label2);
            this.grInfo.Controls.Add(this.txtHoTen);
            this.grInfo.Controls.Add(this.label1);
            this.grInfo.Controls.Add(this.txtMaKH);
            this.grInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grInfo.Location = new System.Drawing.Point(0, 305);
            this.grInfo.Name = "grInfo";
            this.grInfo.Size = new System.Drawing.Size(868, 190);
            this.grInfo.TabIndex = 9;
            this.grInfo.TabStop = false;
            this.grInfo.Text = "Thông tin khách hàng";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
            this.btnHuy});
            this.toolStrip1.Location = new System.Drawing.Point(3, 18);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(862, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QuanLyKhachSan.Properties.Resources._1493961897_insert_object;
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(58, 22);
            this.btnThem.Text = "&Thêm";
            this.btnThem.Click += new System.EventHandler(this.tsbtnthem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QuanLyKhachSan.Properties.Resources._1493961976_edit_file;
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(46, 22);
            this.btnSua.Text = "&Sửa";
            this.btnSua.Click += new System.EventHandler(this.tsbtnsua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLyKhachSan.Properties.Resources._1493962064_edit_delete;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(47, 22);
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.Click += new System.EventHandler(this.tsbtnxoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Image = global::QuanLyKhachSan.Properties.Resources._1493962463_document_save_as;
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(47, 22);
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.Click += new System.EventHandler(this.tsbtnluu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Enabled = false;
            this.btnHuy.Image = global::QuanLyKhachSan.Properties.Resources._1493962109_Remove;
            this.btnHuy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(49, 22);
            this.btnHuy.Text = "&Hủy";
            this.btnHuy.Click += new System.EventHandler(this.tsbtnhuy_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mã KH";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Enabled = false;
            this.dtpNgaySinh.Location = new System.Drawing.Point(137, 135);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(237, 22);
            this.dtpNgaySinh.TabIndex = 11;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Enabled = false;
            this.rdbNu.Location = new System.Drawing.Point(636, 80);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(43, 20);
            this.rdbNu.TabIndex = 10;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Enabled = false;
            this.rdbNam.Location = new System.Drawing.Point(490, 80);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(55, 20);
            this.rdbNam.TabIndex = 9;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // txtCMND
            // 
            this.txtCMND.Enabled = false;
            this.txtCMND.Location = new System.Drawing.Point(472, 108);
            this.txtCMND.Multiline = true;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(237, 21);
            this.txtCMND.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "CMND";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày sinh";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Enabled = false;
            this.txtHoTen.Location = new System.Drawing.Point(137, 108);
            this.txtHoTen.Multiline = true;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(237, 21);
            this.txtHoTen.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ tên";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Enabled = false;
            this.txtMaKH.Location = new System.Drawing.Point(137, 76);
            this.txtMaKH.Multiline = true;
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(237, 23);
            this.txtMaKH.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(764, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 47);
            this.button2.TabIndex = 14;
            this.button2.Text = "Trở lại";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(868, 495);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grListCustomer);
            this.Controls.Add(this.grInfo);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách Hàng";
            this.Load += new System.EventHandler(this.FormKhachHang_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grListCustomer.ResumeLayout(false);
            this.grListCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.grInfo.ResumeLayout(false);
            this.grInfo.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDangKi;
        private System.Windows.Forms.ComboBox cbbDanhSachPhong;
        private System.Windows.Forms.ComboBox cbHinhThuc;
        private System.Windows.Forms.DateTimePicker dtpNhanPhong;
        private System.Windows.Forms.GroupBox grListCustomer;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.GroupBox grInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTienCoc;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnHuy;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}