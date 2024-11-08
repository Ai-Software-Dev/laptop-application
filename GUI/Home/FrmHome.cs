using Component;
using DTO;
using GUI.Category;
using GUI.Login;
using GUI.Product;
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
namespace GUI.Home
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        static FrmHome _obj;
        public static FrmHome Instance
        {
            get { if (_obj == null) { _obj = new FrmHome(); } return _obj; }

        }
        public void AddControls(Form f)
        {
            CenterPanel_Main.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            CenterPanel_Main.Controls.Add(f);
            f.Show();
        }

        private void btn_category_Click(object sender, EventArgs e)
        {
            AddControls(new FrmCategory());
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            AddControls(new FrmProduct());
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn đăng xuất", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                this.Close();
                FrmLogin frm = new FrmLogin();
                frm.Show();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
