using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class FormPhong : Form
    {
        private SqlConnection conn;
        private DataTable dt = new DataTable();
        private DataTable dt1 = new DataTable();
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
        private void initGrid(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            DataGridViewColumn cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "MaPhong";
            cl.HeaderText = "Mã Phòng";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "TenPhong";
            cl.HeaderText = "Tên phòng";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "Loaiphong";
            cl.HeaderText = "Loại phòng";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "Tinhtrang";
            cl.HeaderText = "Tình trạng";
            dgv.Columns.Add(cl);
        }
        private void initGrid1(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            DataGridViewColumn cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "TenVD";
            cl.HeaderText = "Tên vật dụng";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "DonViTinh";
            cl.HeaderText = "Đơn vị tính";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "GiaMua";
            cl.HeaderText = "Giá mua";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "SoLuong";
            cl.HeaderText = "Số lượng";
            dgv.Columns.Add(cl);
        }
        private void binding()
        {
            txtMaP.DataBindings.Clear();
            txtMaP.DataBindings.Add("Text", dataGPhong.DataSource, "MaPhong");
            txtTenP.DataBindings.Clear();
            txtTenP.DataBindings.Add("Text", dataGPhong.DataSource, "TenPhong");
            txtLoaiP.DataBindings.Clear();
            txtLoaiP.DataBindings.Add("Text", dataGPhong.DataSource, "LoaiPhong");
        }
        private void binding1()
        {
            cmbVatdung.DataBindings.Clear();
            cmbVatdung.DataBindings.Add("Text", dataGVatDung.DataSource, "TenVD");
            txtDVTinh.DataBindings.Clear();
            txtDVTinh.DataBindings.Add("Text", dataGVatDung.DataSource, "DonViTinh");
            txtGia.DataBindings.Clear();
            txtGia.DataBindings.Add("Text", dataGVatDung.DataSource, "Giamua");
            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", dataGVatDung.DataSource, "Soluong");

        }
        public void getPhong()
        {
            SqlConnection con = new SqlConnection(globalParameter.str);
            SqlCommand cm = new SqlCommand();
            DataTable data = new DataTable();
            DataTable data1 = new DataTable();
            cm.Connection = con;

            cm.CommandText = "select * from PHONG ";
            da.SelectCommand = cm;
            da.Fill(data);
            cmbPhong.DataSource = data;
            cmbPhong.DisplayMember = "TenPhong";
            cmbPhong.ValueMember = "MaPhong";

            cm.CommandText = "select * from VATDUNG ";
            da.SelectCommand = cm;
            da.Fill(data1);
            cmbVatdung.DataSource = data1;
            cmbVatdung.DisplayMember = "TenVD";
            cmbVatdung.ValueMember = "MaVD";
        }
        public void getHtPhong()
        {
            try
            {
                SqlCommand command = new SqlCommand("SP_HIENTHI_PHONG", conn);
                command.CommandType = CommandType.StoredProcedure;
                da.SelectCommand = command;
                da.Fill(dt);
                dataGPhong.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi ở danh sách phòng !", " Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public void getHtVatDung()
        {
            try
            {
                dt1.Clear();
                // cmbVatdung.Enabled = false;
                SqlCommand command = new SqlCommand("SP_HIENTHI_VATDUNG", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@maphong", cmbPhong.SelectedValue));
                da.SelectCommand = command;
                da.Fill(dt1);
                dataGVatDung.DataSource = dt1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi ở danh sách vật dụng !", " Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public void disconect()
        {
            conn.Close();
            conn.Dispose();
            conn = null;
        }
        public FormPhong()
        {
            InitializeComponent();
        }

        private void FormPhong_Load(object sender, EventArgs e)
        {
            connect();
            initGrid(dataGPhong);
            initGrid1(dataGVatDung);
            getHtPhong();
            getPhong();
            //  disconect();
            getHtVatDung();
            binding();
            binding1();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            connect();
            getHtVatDung();

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            txtTenP.Enabled = true;
            txtLoaiP.Enabled = true;
            checkBDung.Enabled = true;
            txtMaP.Enabled = false;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            connect();
            try
            {

                // this.Dispose();
                // disconect();

                DialogResult dg = MessageBox.Show("Bạn muốn sửa thông tin phòng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    SqlCommand command = new SqlCommand("SP_SUA_PHONG", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@maphong", txtMaP.Text));
                    command.Parameters.Add(new SqlParameter("@tenphong", txtTenP.Text));
                    command.Parameters.Add(new SqlParameter("@loaiphong", txtLoaiP.Text));
                    if (checkBDung.Checked == true)
                    {
                        command.Parameters.Add(new SqlParameter("@tinhtrang", true));
                    }
                    else
                        command.Parameters.Add(new SqlParameter("@tinhtrang", false));
                    command.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    dt.Clear();
                    getHtPhong();
                }
                else
                {
                    txtTenP.Enabled = false;
                    txtLoaiP.Enabled = false;
                    checkBDung.Enabled = false;
                    txtMaP.Enabled = false;
                    btnSua.Enabled = true;
                    btnCapNhat.Enabled = false;
                    btnHuy.Enabled = false;
                }
                DialogResult dg1 = MessageBox.Show("Bạn muốn tiếp tục cập nhật phòng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg1 == DialogResult.No)
                {
                    txtTenP.Enabled = false;
                    txtLoaiP.Enabled = false;
                    checkBDung.Enabled = false;
                    txtMaP.Enabled = false;
                    btnSua.Enabled = true;
                    btnCapNhat.Enabled = false;
                    btnHuy.Enabled = false;
                }

            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra, thử lại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }
        private void dataGPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGPhong.CurrentRow.Cells[3].Value.ToString() == "True")
            {
                checkBDung.Checked = true;
            }
            else
            {
                checkBDung.Checked = false;
            }
            binding();
        }

        private void btnXoavdp_Click(object sender, EventArgs e) // Xóa vật dụng ở trong 1 phòng
        {
            if (cmbVatdung.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi!", "Thông báo!!!");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này?", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                connect();
                try
                {

                    SqlCommand command = new SqlCommand("SP_XOA_VATDUNG_PHONG", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@maphong", cmbPhong.SelectedValue));
                    command.Parameters.Add(new SqlParameter("@mavatdung", cmbVatdung.SelectedValue));
                    command.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt1.Clear();
                    getHtVatDung();
                    //  disconect();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa dữ liệu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThemvd_Click(object sender, EventArgs e)
        {
            // cmbVatdung.Clear();
            // txtTenVD.Clear();
            txtDVTinh.Clear();
            txtGia.Clear();
            txtSoLuong.Clear();
            txtSoLuong.Enabled = true;
            cmbPhong.Enabled = false;
            //  txtTenVD.Enabled = false;
            txtDVTinh.Enabled = false;
            txtGia.Enabled = false;
            btnThemvd.Enabled = false;
            btnSuavd.Enabled = false;
            btnCN.Enabled = false;
            btnXoavdp.Enabled = false;
            btnLuuvd.Enabled = true;
            btnThoatvd.Enabled = true;
        }

        private void btnLuuvd_Click(object sender, EventArgs e)
        {
            connect();
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Số lượng sản phẩm không phù hợp! Xem lại!", "Thông báo", MessageBoxButtons.OKCancel);
                return;
            }
            
            

            
            try
            {
                // this.Dispose();
                // disconect();
                if (int.Parse(txtSoLuong.Text.ToString())<=0)
                {
                    MessageBox.Show("Số lượng sản phẩm không phù hợp! Xem lại!", "Thông báo", MessageBoxButtons.OKCancel);
                    return;
                }
                DialogResult dg = MessageBox.Show("Bạn muốn thêm vật dụng trong phòng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {

                    SqlCommand command = new SqlCommand("SP_THEM_VATDUNGTRONGPHONG", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@madodung", cmbVatdung.SelectedValue));
                    command.Parameters.Add(new SqlParameter("@soluong", int.Parse(txtSoLuong.Text)));
                    command.Parameters.Add(new SqlParameter("@maphong", cmbPhong.SelectedValue));
                    command.ExecuteNonQuery();
                    dt1.Clear();
                    getHtVatDung();
                    binding1();
                    MessageBox.Show("Thêm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtSoLuong.Clear();
                }
                else
                {
                    cmbPhong.Enabled = false;
                    // txtTenVD.Enabled = false;
                    txtDVTinh.Enabled = false;
                    txtGia.Enabled = false;
                    txtSoLuong.Enabled = false;
                    btnThemvd.Enabled = true;
                    btnSuavd.Enabled = true;
                    btnXoavdp.Enabled = true;
                    btnCN.Enabled = false;
                    btnXoavdp.Enabled = true;
                    btnLuuvd.Enabled = false;
                    btnThoatvd.Enabled = false;
                }
                DialogResult dg1 = MessageBox.Show("Bạn muốn tiếp tục thêm", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg1 == DialogResult.No)
                {
                    cmbPhong.Enabled = false;
                    //  txtTenVD.Enabled = false;
                    txtDVTinh.Enabled = false;
                    txtGia.Enabled = false;
                    txtSoLuong.Enabled = false;
                    btnThemvd.Enabled = true;
                    btnSuavd.Enabled = true;
                    btnXoavdp.Enabled = true;
                    btnCN.Enabled = false;
                    btnXoavdp.Enabled = true;
                    btnLuuvd.Enabled = false;
                    btnThoatvd.Enabled = false;
                    disconect();
                }


            }
            catch
            {
                MessageBox.Show("Sản phẩm đã tồn tại, thử lại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }



        }

        private void btnSuavd_Click(object sender, EventArgs e)
        {
            cmbPhong.Enabled = false;
            cmbVatdung.Enabled = false;
            txtSoLuong.Enabled = true;
            //   txtTenVD.Enabled = true;
            txtDVTinh.Enabled = true;
            txtGia.Enabled = true;
            btnThemvd.Enabled = false;
            btnLuuvd.Enabled = false;
            btnSuavd.Enabled = false;
            btnXoavdp.Enabled = false;
            btnCN.Enabled = true;
            btnThoatvd.Enabled = true;
        }

        private void btnCN_Click(object sender, EventArgs e)
        {
            connect();
            //try
            //{

            // this.Dispose();
            // disconect();
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Số lượng sản phẩm không phù hợp! Xem lại!", "Thông báo", MessageBoxButtons.OKCancel);
                return;
            }

            DialogResult dg = MessageBox.Show("Bạn muốn sửa thông tin vật dụng trong phòng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                SqlCommand command = new SqlCommand("SP_SUA_VATDUNG_PHONG", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@mavatdung", cmbVatdung.SelectedValue));
                command.Parameters.Add(new SqlParameter("@maphong", cmbPhong.SelectedValue));
                command.Parameters.Add(new SqlParameter("@soluong", int.Parse(txtSoLuong.Text)));
                //   command.Parameters.Add(new SqlParameter("@tenvatdung", txtTenVD.Text));
                command.Parameters.Add(new SqlParameter("@donvitinh", txtDVTinh.Text));
                command.Parameters.Add(new SqlParameter("@giamua", decimal.Parse(txtGia.Text)));
                command.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                dt1.Clear();
                getHtVatDung();
            }
            else
            {
                cmbVatdung.Enabled = true;
                cmbPhong.Enabled = true;
                //  txtTenVD.Enabled = false;
                txtDVTinh.Enabled = false;
                txtGia.Enabled = false;
                txtSoLuong.Enabled = false;
                btnThemvd.Enabled = true;
                btnSuavd.Enabled = true;
                btnXoavdp.Enabled = true;
                btnCN.Enabled = false;
                btnXoavdp.Enabled = true;
                btnLuuvd.Enabled = false;
                btnThoatvd.Enabled = false;
            }
            DialogResult dg1 = MessageBox.Show("Bạn muốn tiếp tục cập nhật", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg1 == DialogResult.No)
            {
                cmbVatdung.Enabled = true;
                cmbPhong.Enabled = true;
                //  txtTenVD.Enabled = false;
                txtDVTinh.Enabled = false;
                txtGia.Enabled = false;
                txtSoLuong.Enabled = false;
                btnThemvd.Enabled = true;
                btnSuavd.Enabled = true;
                btnXoavdp.Enabled = true;
                btnCN.Enabled = false;
                btnXoavdp.Enabled = true;
                btnLuuvd.Enabled = false;
                btnThoatvd.Enabled = false;
            }

            //}
            //catch
            //{
            //    MessageBox.Show("Có lỗi xảy ra, thử lại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //}

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            txtTenP.Enabled = false;
            txtLoaiP.Enabled = false;
            checkBDung.Enabled = false;
            txtMaP.Enabled = false;
            btnSua.Enabled = true;
            btnCapNhat.Enabled = false;
            btnHuy.Enabled = false;

        }

        private void btnThoatvd_Click(object sender, EventArgs e)
        {
            txtSoLuong.Clear();
            txtGia.Clear();
            txtDVTinh.Clear();
            cmbPhong.Enabled = true;
            cmbVatdung.Enabled = true;
            //  txtTenVD.Enabled = false;
            txtDVTinh.Enabled = false;
            txtGia.Enabled = false;
            txtSoLuong.Enabled = false;
            btnThemvd.Enabled = true;
            btnSuavd.Enabled = true;
            btnXoavdp.Enabled = true;
            btnCN.Enabled = false;
            btnXoavdp.Enabled = true;
            btnLuuvd.Enabled = false;
            btnThoatvd.Enabled = false;
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar)&&!Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain fm = new FormMain();
            fm.ShowDialog();
        }
    }
}
