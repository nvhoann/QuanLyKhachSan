using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyKhachSan
{
   
    public partial class FormKhachHang : Form
    {
        public bool isChecked = false;
        public bool isClick;
        private SqlConnection conn;
        private DataTable dt = new DataTable("tblKHACHHANG");
        private SqlDataAdapter da = new SqlDataAdapter();
        public void connect()
        {
            String conStr = globalParameter.str;
            try
            {

                conn = new SqlConnection(conStr);
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("LỖI");
            }
        }
        public void disconect()
        {
            conn.Close();
            conn.Dispose();
            conn = null;
        }
        public void getdata()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "select MaKH, TenKH, case(GT) when 1 then 'Nam' else N'Nữ' end GioiTinh, NgaySinh, CMND from KHACHHANG where TenKH like '%'+@Ten+'%' or CMND like '%'+@CMND+'%'";
            command.Parameters.Add(new SqlParameter("@Ten",txtTimKiem.Text));
            command.Parameters.Add(new SqlParameter("@CMND", txtTimKiem.Text));
            da.SelectCommand = command;
            dt.Clear();
            da.Fill(dt);
            dgvKhachHang.DataSource = dt;


        }
        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            connect();
            getdata();
            getHinhThuc();
            disconect();
        }
        void Binding()
        {
            txtMaKH.DataBindings.Clear();
            txtMaKH.DataBindings.Add("Text", dgvKhachHang.DataSource, "MaKH");
            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", dgvKhachHang.DataSource, "TenKH");
            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Text", dgvKhachHang.DataSource, "NgaySinh");
            txtCMND.DataBindings.Clear();
            txtCMND.DataBindings.Add("Text", dgvKhachHang.DataSource, "CMND");
        }

        public void getHinhThuc()
        {
            SqlConnection con = new SqlConnection(globalParameter.str);
            SqlCommand cm = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable data = new DataTable();
            DataTable data1 = new DataTable();
            //DataTable data2 = new DataTable();
            //DataTable data3 = new DataTable();
            cm.Connection = con;

            cm.CommandText = "select * from HINHTHUCTHUE";
            da.SelectCommand = cm;
            da.Fill(data);
            cbHinhThuc.DataSource = data;
            cbHinhThuc.DisplayMember = "HinhThuc";
            cbHinhThuc.ValueMember = "Ma";

            SqlCommand command = new SqlCommand("sp_DANHSACHPHONGTRONG", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.ExecuteNonQuery();
            da.SelectCommand = command;
            da.Fill(data1);
            cbbDanhSachPhong.DataSource = data1;
            cbbDanhSachPhong.DisplayMember = "TenPhong";
            cbbDanhSachPhong.ValueMember = "MaPhong";
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string gt = this.dgvKhachHang.CurrentRow.Cells["GioiTinh"].Value.ToString().Trim();
            if (gt == "Nam")
            {
                rdbNam.Checked = true;

            }
            else if (gt == "Nữ")
            {
                rdbNu.Checked = true;

            }
            Binding();
        }


        private void btnDangKi_Click(object sender, EventArgs e)
        {
            connect();
            if (txtMaHD.Text==""||txtTienCoc.Text==""||txtCMND.Text==""||txtHoTen.Text==""||txtMaKH.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (dtpNhanPhong.Value.AddDays(3) > DateTime.Now)
            
            {
                try
                {
                    SqlCommand command = new SqlCommand("sp_DANGKYTHUEPHONG", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@mahd", txtMaHD.Text));
                    command.Parameters.Add(new SqlParameter("@makh", txtMaKH.Text));
                    command.Parameters.Add(new SqlParameter("@maphong", cbbDanhSachPhong.SelectedValue));
                    command.Parameters.Add(new SqlParameter("@tgnhan", dtpNhanPhong.Value));
                    command.Parameters.Add(new SqlParameter("@hinhthuc", cbHinhThuc.SelectedValue));
                    command.Parameters.Add(new SqlParameter("@tiencoc", decimal.Parse(txtTienCoc.Text)));
                    command.ExecuteNonQuery();
                    MessageBox.Show("Đăng kí thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đăng kí không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
           
            dt.Clear();
            getdata();      
            getHinhThuc();
            disconect();
            
        }

        private void dgvKhachHang_DoubleClick(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cbHinhThuc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            connect();

            getdata();
            disconect();
        }
        public bool _sua = false;
        private void tsbtnthem_Click(object sender, EventArgs e)
        {
            _sua = false;

            txtMaKH.Enabled = true;
            txtHoTen.Enabled = true;
            txtCMND.Enabled = true;
            dtpNgaySinh.Enabled = true;
            rdbNam.Enabled = true;
            rdbNu.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            btnHuy.Enabled = true;
            btnLuu.Enabled = true;

            txtMaKH.Clear();
            txtHoTen.Clear();
            txtCMND.Clear();
        }

        private void tsbtnsua_Click(object sender, EventArgs e)
        {
            _sua = true;

            txtHoTen.Enabled = true;
            txtCMND.Enabled = true;
            dtpNgaySinh.Enabled = true;
            rdbNam.Enabled = true;
            rdbNu.Enabled = true;

            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void tsbtnxoa_Click(object sender, EventArgs e)
        {
            if(txtMaKH.Text == "")
            {
                MessageBox.Show("Chưa chọn khách hàng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            connect();
            try
            {
                SqlCommand command = new SqlCommand("sp_XOAKHACHHANG", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@makh", txtMaKH.Text));
                command.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa dữ liệu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            getdata();
            disconect();
        }

        private void tsbtnluu_Click(object sender, EventArgs e)
        {
            if (_sua == false)
            {

                connect();
                try
                {
                    SqlCommand command = new SqlCommand("sp_THEMKHACHHANG", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@makh", txtMaKH.Text));
                    command.Parameters.Add(new SqlParameter("@tenkh", txtHoTen.Text));
                    command.Parameters.Add(new SqlParameter("@ngaysinh", dtpNgaySinh.Value));
                    command.Parameters.Add(new SqlParameter("@cmnd", txtCMND.Text));

                    if (rdbNam.Checked == true)
                    {
                        command.Parameters.Add(new SqlParameter("@gt", true));
                    }
                    else if (rdbNu.Checked == true)
                    {
                        command.Parameters.Add(new SqlParameter("@gt", false));
                    }
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt.Clear();
                    btnHuy.Enabled = false;
                    btnLuu.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm dữ liệu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                getdata();
                disconect();

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                dtpNgaySinh.Enabled = false;
                txtMaKH.Enabled = false;
                txtHoTen.Enabled = false;
                txtCMND.Enabled = false;
                dtpNgaySinh.Enabled = false;
                rdbNam.Enabled = false;
                rdbNu.Enabled = false;
            }
            if (_sua == true)
            {
                connect();
                try
                {
                    SqlCommand command = new SqlCommand("sp_SUAKHACHHANG", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@makh", txtMaKH.Text));
                    command.Parameters.Add(new SqlParameter("@tenkh", txtHoTen.Text));
                    command.Parameters.Add(new SqlParameter("@ngaysinh", dtpNgaySinh.Value));
                    command.Parameters.Add(new SqlParameter("@cmnd", txtCMND.Text));

                    if (rdbNam.Checked == true)
                    {
                        command.Parameters.Add(new SqlParameter("@gt", true));
                    }
                    else if (rdbNu.Checked == true)
                    {
                        command.Parameters.Add(new SqlParameter("@gt", false));
                    }
                    command.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt.Clear();
                    btnHuy.Enabled = false;
                    btnLuu.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa dữ liệu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                getdata();
                disconect();
                btnSua.Enabled = true;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                dtpNgaySinh.Enabled = false;
                txtHoTen.Enabled = false;
                txtCMND.Enabled = false;
            }
        }

        private void tsbtnhuy_Click(object sender, EventArgs e)
        {
            dgvKhachHang.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            txtMaKH.Clear();
            txtHoTen.Clear();
            txtCMND.Clear();
            dtpNgaySinh.Enabled = false;
            txtMaKH.Enabled = false;
            txtHoTen.Enabled = false;
            txtCMND.Enabled = false;

            connect();
            getdata();
            disconect();
        }

        private void txtTienCoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain fm = new FormMain();
            fm.ShowDialog();
        }
    }
}
