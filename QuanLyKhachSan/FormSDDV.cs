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
    public partial class FormSDDV : Form
    {
        public FormSDDV()
        {
            InitializeComponent();
        }
        
        private SqlConnection conn;
        private DataTable dt = new DataTable("tblSUDUNGDICHVU");
        private DataTable dt1 = new DataTable();
        private SqlDataAdapter da = new SqlDataAdapter();
        bool isCheck;
        
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

        /// <summary>
        /// Đổ dữ liệu vào datagrid những khách hàng đang thuê phòng để thêm dịch vụ
        /// </summary>
        public void getdata()
        {
            SqlCommand command = new SqlCommand("sp_CHECKKHACHDANGSUDUNGPHONG", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.ExecuteNonQuery();           
            da.SelectCommand = command;
            dt.Clear();
            da.Fill(dt);
            dgvSudungdichvu.DataSource = dt;
        }

        /// <summary>
        /// Hàm đưa dữ liệu từ csdl vào dataGrid hiển thị lên khách hàng vừa chọn để thêm dịch vụ
        /// </summary>
        public void getdata1()
        {
            SqlCommand command = new SqlCommand("sp_SUDUNGDICHVU1HOPDONG", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@MaHD", txtMaHD.Text));
            command.ExecuteNonQuery();
            da.SelectCommand = command;
            da.Fill(dt1);
            dgvDichvukhachhang.DataSource = dt1;
        }

        public void getCbb()
        {
            SqlConnection con = new SqlConnection(globalParameter.str);
            SqlCommand cm = new SqlCommand();
            DataTable data = new DataTable();

            cm.Connection = con;

            cm.CommandText = "select * from DICHVU";
            da.SelectCommand = cm;
            da.Fill(data);
            cbbDichvu.DataSource = data;
            cbbDichvu.DisplayMember = "TenDV";
            cbbDichvu.ValueMember = "MaDV";
        }

        public void Bindings()
        {
            txtMaHD.DataBindings.Clear();
            txtMaHD.DataBindings.Add("Text", dgvSudungdichvu.DataSource, "Ma HD");
        }

        public void InitGrid(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            DataGridViewColumn cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "TenKH";
            cl.HeaderText = "Tên khách hàng";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "TenPhong";
            cl.HeaderText = "Tên phòng";
            dgv.Columns.Add(cl);
        }

        public void InitGrid1(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            DataGridViewColumn cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "TenDV";
            cl.HeaderText = "Tên dịch vụ";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "Gia";
            cl.HeaderText = "Giá";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "DonViTinh";
            cl.HeaderText = "Đơn vị tính";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "SoLuong";
            cl.HeaderText = "Số lượng";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "Tong Tien";
            cl.HeaderText = "Tổng tiền";
            dgv.Columns.Add(cl);
        }

        private void FormSDDV_Load(object sender, EventArgs e)
        {
            connect();            
            InitGrid(dgvSudungdichvu);
            InitGrid1(dgvDichvukhachhang);
            getdata();
            //getCbb();
            Bindings();          
            disconect();
        }

        private void dgvSudungdichvu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            connect();
            dt1.Clear();
            getdata1();
            cbbDichvu.Enabled = true;
            nrSoluong.Enabled = true;
            btnThem.Enabled = true;
            btnThoat.Enabled = true;
            btnThanhtoan.Enabled = true;
            getCbb();
            disconect();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            isCheck = true;
            try
            {
                SqlCommand command = new SqlCommand("sp_THEMSUDUNGDICHVU", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@MaHD", txtMaHD.Text));
                command.Parameters.Add(new SqlParameter("@MaDV", cbbDichvu.SelectedValue.ToString()));
                command.Parameters.Add(new SqlParameter("@Soluong", nrSoluong.Value));
                command.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception )
            {
                MessageBox.Show("Thêm dữ liệu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(isCheck)
            {
                connect();
                dt1.Clear();
                getdata1();
                btnThem.Enabled = false;
                btnThoat.Enabled = false;
                cbbDichvu.Enabled = false;
                nrSoluong.Enabled = false;
                isCheck = false;
            }
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "")
            {
                MessageBox.Show("Không có khách thuê dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FormThanhToan frThanhtoan = new FormThanhToan(txtMaHD.Text);
            frThanhtoan.ShowDialog();
            connect();
            getdata();
            //Bindings();
            disconect();
            //FormMain fr = new FormMain();
            //fr.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            cbbDichvu.Enabled = false;
            nrSoluong.Enabled = false;
            btnThem.Enabled = false;
            btnThanhtoan.Enabled = false;
            btnThoat.Enabled = false;
        }

        private void cbbDichvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            connect();
            txtGia.Clear();
            SqlCommand command = new SqlCommand("sp_CHECKGIADICHVU", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@MaDV", cbbDichvu.SelectedValue.ToString()));
            SqlDataReader r = command.ExecuteReader();
            if(r.Read())
            {
                txtGia.Text = r["Gia"].ToString();
            }
            r.Close();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            connect();
            getdata();
            disconect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain fm = new FormMain();
            fm.ShowDialog();
        }
    }
}
