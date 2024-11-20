using Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using GUI.Home;

namespace GUI.Login
{
    public partial class FrmLogin : Form
    {
        BLL_Login bl = new BLL_Login();
        public FrmLogin()
        {
            InitializeComponent();
            this.btnDangNhap.Click += BtnDangNhap_Click;
            this.btnThoat.Click += BtnThoat_Click;
        }


        private void BtnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thoát?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(r == DialogResult.Yes)
            {
                this.Close();
            }    
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            string name = txtTenDN.Text;
            string pass = txtPass.Text;
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Vui lòng điền tên đăng nhập và mật khẩu.", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (bl.Login(name, pass))
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                FrmHome frm = new FrmHome();
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Thông báo");
            }
        }
    }
}
