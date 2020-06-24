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
    public partial class FormThanhToan : Form
    {
        private SqlConnection conn;
        private DataTable dt = new DataTable("tblThanhToan");
        private SqlDataAdapter da = new SqlDataAdapter();
        public FormThanhToan(string mahd)
        {
            
            InitializeComponent();
            txtMa.Text = mahd;
        }

        public void connect()
        {
            try
            {
                conn = new SqlConnection(globalParameter.str);
                conn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi.");
            }
        }
        public void disconnect()
        {
            conn.Close();
            conn.Dispose();
            conn = null;
        }
        private void initGritPhong(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            DataGridViewColumn cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "TenPhong";
            cl.HeaderText = "Tên Phòng";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "TGNhan";
            cl.HeaderText = "Thời gian nhận";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "TGTra";
            cl.HeaderText = "Thời gian trả";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "HinhThuc";
            cl.HeaderText = "Hình thức thuê";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "Gia";
            cl.HeaderText = "Giá tiền";
            dgv.Columns.Add(cl);
        }
        private void initGritDichVu(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            DataGridViewColumn cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "TenDV";
            cl.HeaderText = "Tên Dịch Vụ";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "SoLuong";
            cl.HeaderText = "Số lượng sử dụng";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "Gia";
            cl.HeaderText = "Giá tiền/lần";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "TongTien";
            cl.HeaderText = "Tổng tiền";
            dgv.Columns.Add(cl);
        }
        public void getdata()
        {
            connect();
            SqlCommand command = new SqlCommand("SP_THONGTINKHACHTHUEPHONG", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@mahopdong", txtMa.Text));
            SqlDataReader r = command.ExecuteReader();
            if (r.Read())
            {
                txtHoTen.Text = r["TenKH"].ToString();
                txtCMND.Text = r["CMND"].ToString();
                dtpNgaySinh.Text = r["NgaySinh"].ToString();
                if (r["GioiTinh"].ToString() == "True")
                {
                    rdbNam.Checked = true;
                }
                else
                {
                    rdbNu.Checked = true;
                }
            }
            r.Close();
        }
        public void getdataPhong()
        {
            SqlCommand command = new SqlCommand("SP_THONGTINTHUEPHONG", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@mahopdong", txtMa.Text));
            SqlDataReader r = command.ExecuteReader();
            if (r.Read())
            {
                dtpTGNhan.Text = r["TGNhan"].ToString();
                dtpTGTra.Text = DateTime.Now.ToString();
                txtHTT.Text = r["HinhThucThue"].ToString();
                txtGiaTien.Text = r["Gia"].ToString();
                lblTenPhong.Text += r["TenPhong"].ToString();
                txtTienPhong.Text = r["tienphong"].ToString();//r["TienPhong"].ToString();
                lblTienDatCoc.Text = r["TienDatCoc"].ToString();
            }
            r.Close();
        }
        public void getdataDichVu()
        {
            SqlCommand command = new SqlCommand("SP_THONGTINSUDUNGDICHVU", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@mahopdong", txtMa.Text));
            var ret = command.Parameters.Add("@tongtiendichvu", SqlDbType.Decimal);
            ret.Direction = ParameterDirection.ReturnValue;
            command.ExecuteNonQuery();
            da.SelectCommand = command;
            da.Fill(dt);
            dgvDichVu.DataSource = dt;
            txtTienDichVu.Text = ret.Value.ToString();//r["TienDichVu"].ToString();
        }
        private void FormThanhToan_Load(object sender, EventArgs e)
        {
            connect();
            getdata();
            //initGritPhong(dgvPhong);
            initGritDichVu(dgvDichVu);
            getdataPhong();
            getdataDichVu();
            
            lblTongTien.Text = (decimal.Parse(txtTienPhong.Text) + decimal.Parse(txtTienDichVu.Text)).ToString();
            lblThanhToan.Text = (decimal.Parse(lblTongTien.Text) - decimal.Parse(lblTienDatCoc.Text)).ToString();
            disconnect();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            connect();
            try
            {
                SqlCommand command = new SqlCommand("Sp_TRAPHONG", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@mahd", txtMa.Text));
                command.ExecuteNonQuery();
                MessageBox.Show("Trả phòng thành công ! Cảm ơn quý khách đã sử dụng dịch vụ của chúng tôi !");
                this.Hide();
             //   FormMain.bDV = true;
                //FormMain fr = new FormMain();
                //fr.Show();
                //Hide();
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi.");
            }
        }

        private void FormThanhToan_FormClosed(object sender, FormClosedEventArgs e)
        {
            //FormMain.bDV = true;
            //FormMain fr = new FormMain();
            //fr.Show();
        }

    }
}
