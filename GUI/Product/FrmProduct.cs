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
namespace GUI.Product
{
    public partial class FrmProduct : Form
    {
        BLL_Category category = new BLL_Category();
        BLL_Product product = new BLL_Product();
        public FrmProduct()
        {
            InitializeComponent();
            LoadCombobox();
            LoadData();

        }
        public void LoadCombobox()
        {
            List<hang> hang = category.GetHangs();
            cmbCategory.DataSource = hang;
            cmbCategory.DisplayMember = "TenHang";
            cmbCategory.ValueMember = "MaHang";
        }
        public void LoadData()
        {
            List<sanpham> sanphams = product.GetSanphams();
            dgvProduct.DataSource = sanphams;
        }
    }
}
