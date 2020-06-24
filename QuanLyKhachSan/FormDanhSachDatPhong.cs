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
    public partial class FormDanhSachDatPhong : Form
    {
        public FormDanhSachDatPhong()
        {
            InitializeComponent();
        }
        private SqlConnection conn;
        private DataTable dt = new DataTable();
        private SqlDataAdapter da = new SqlDataAdapter();
        string maHd;
        DateTime ngaydatphong;
        public void connect()
        {
            String conStr = globalParameter.str;
            try
            {

                conn = new SqlConnection(conStr);
                conn.Open();
            }
            catch (Exception)
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
            SqlCommand command = new SqlCommand("sp_DANHSACHDATPHONG", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.ExecuteNonQuery();            
            da.SelectCommand = command;
            dt.Clear();
            da.Fill(dt);
            dgvDanhsachdatphong.DataSource = dt;
        }
        public void Bindings()
        {
            lbMahd.DataBindings.Clear();
            lbMahd.DataBindings.Add("Text", dgvDanhsachdatphong.DataSource, "MaHD");
            
        }
        private void FormDanhSachDatPhong_Load(object sender, EventArgs e)
        {
            connect();
            initGrid(dgvDanhsachdatphong);
            getdata();
            disconect();
        }

        private void initGrid(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            DataGridViewColumn cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "tenphong";
            cl.HeaderText = "Phòng";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "mahd";
            cl.HeaderText = "Mã Hợp Đồng";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "tenkh";
            cl.HeaderText = "Khách Hàng";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "thoi gian dat phong";
            cl.HeaderText = "Thời Gian Đặt Phòng";
            dgv.Columns.Add(cl);
        }

        private void dgvDanhsachdatphong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            connect();
            Bindings();
            ngaydatphong = (DateTime)dgvDanhsachdatphong.CurrentRow.Cells[3].Value;
            btnXacnhan.Enabled = true;
            btnHuy.Enabled = true;
            disconect();
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            connect();
            if (ngaydatphong < DateTime.Now)
            {
                MessageBox.Show("Xác nhận không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                SqlCommand command = new SqlCommand("sp_NHANPHONG", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@MaHD", lbMahd.Text));
                command.ExecuteNonQuery();                
                MessageBox.Show("Xác nhận thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Xác nhận không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dt.Clear();
            getdata();
            btnXacnhan.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            connect();
            try
            {
                SqlCommand command = new SqlCommand("sp_HUYTHUEPHONG", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@MaHD", lbMahd.Text));
                command.ExecuteNonQuery();
                MessageBox.Show("Hủy xác nhận thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Hủy xác nhận không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dt.Clear();
            getdata();
            btnXacnhan.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect();
            getdata();
            disconect();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain fm = new FormMain();
            fm.ShowDialog();
        }
    }
}
