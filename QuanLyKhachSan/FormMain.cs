using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class FormMain : Form
    {
        public string tentk;
        public FormMain()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) //Hàm bắt sự kiện nhập phím
        {
            switch (keyData)
            {
                case Keys.F1: //Bắt sự kiện nhập phím F1
                    FormTroGiup fmHelp = new FormTroGiup();
                    fmHelp.ShowDialog();
                    break;
                //Thêm phím tắt vào đây case2,3,.....

            }
            return base.ProcessCmdKey(ref msg, keyData);//Made by Dat_Dz
        }

      /*  public static bool bDV = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            FormTrangChu _fr = new FormTrangChu();
            inserttabpage(_fr);
            FormKhachHang fr = new FormKhachHang();
            inserttabpage(fr);
            
            FormDanhSachDatPhong fr2 = new FormDanhSachDatPhong();
            inserttabpage(fr2);
            FormSDDV fr1 = new FormSDDV();
            inserttabpage(fr1);
            FormPhong fr3 = new FormPhong();
            inserttabpage(fr3);
            lbltenandloai.Text = "Chào User : " + tentk;
            if (bDV == true)
            {
                tcbmenu.SelectedIndex = checkformExist(tcbmenu, fr1);
                bDV = false;
            }
            
        }
     
        

        public void inserttabpage(Form fr)
        {
            int index = checkformExist(tcbmenu, fr);
            if (index >= 0)
            {
                tcbmenu.TabIndex = index;
            }
            else
            {
                TabPage tb = new TabPage { Text = fr.Text };
                tb.BorderStyle = BorderStyle.FixedSingle;
                tcbmenu.TabPages.Add(tb);
                fr.TopLevel = false;
                fr.Parent = tb;
                fr.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                fr.Show();
                fr.Dock = DockStyle.Fill;
            }
        }


        public int checkformExist(TabControl tcb, Form fr)
        {
            for (int i = 0; i < tcb.TabCount; i++)
            {
                if (tcb.TabPages[i].Text == fr.Text.Trim())
                    return i;
            }
            return -1;
        }

        public void kh()
        {
            FormKhachHang fr = new FormKhachHang();
            inserttabpage(fr);
            tcbmenu.SelectedIndex = checkformExist(tcbmenu, fr);
        }

        private void btnkh_Click(object sender, EventArgs e)
        {
            FormKhachHang fr = new FormKhachHang();
            inserttabpage(fr);
            tcbmenu.SelectedIndex = checkformExist(tcbmenu, fr);

        }

        private void btndichvu_Click(object sender, EventArgs e)
        {
            FormSDDV fr = new FormSDDV();
            inserttabpage(fr);
            tcbmenu.SelectedIndex = checkformExist(tcbmenu, fr);
        }

        private void btndsdp_Click(object sender, EventArgs e)
        {
            FormDanhSachDatPhong fr = new FormDanhSachDatPhong();
            inserttabpage(fr);
            tcbmenu.SelectedIndex = checkformExist(tcbmenu, fr);
        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            FormPhong fr = new FormPhong();
            inserttabpage(fr);
            tcbmenu.SelectedIndex = checkformExist(tcbmenu, fr);
        }
        */

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            FormLogin fr = new FormLogin();
            fr.Show();
            Hide();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason.ToString().Equals("UserClosing"))
            {
                if (MessageBox.Show("Bạn có chắc muốn thoát ứng dụng?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnhelp_Click(object sender, EventArgs e)
        {
            FormTroGiup fmHelp = new FormTroGiup();
            fmHelp.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKhachHang fkh = new FormKhachHang();
            fkh.ShowDialog();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDanhSachDatPhong ds = new FormDanhSachDatPhong();
            ds.ShowDialog(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSDDV sd = new FormSDDV();
            sd.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPhong ph = new FormPhong();
            ph.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTroGiup tg = new FormTroGiup();
            tg.ShowDialog();
        }
    }
}
