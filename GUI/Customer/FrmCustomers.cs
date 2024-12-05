using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Customer
{
    public partial class FrmCustomers : Form
    {
        BLL_Customer bllCus = new BLL_Customer();
        private List<user> userList;
        public FrmCustomers()
        {
            InitializeComponent();
            GetData();
            txt_SearchCustomer.TextChanged += Txt_SearchCustomer_TextChanged;
            dgv_Customers.SelectionChanged += Dgv_Customers_SelectionChanged;
            dgv_Customers.CellContentClick += Dgv_Customers_CellContentClick;
        }

        private void Dgv_Customers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgv_Customers.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                CustomersModule module = new CustomersModule(this);
                module.txt_MaTK.Text = dgv_Customers.Rows[e.RowIndex].Cells[0].Value.ToString();
                module.txt_TenKH.Text = dgv_Customers.Rows[e.RowIndex].Cells[1].Value.ToString();
                module.txt_TenTK.Text = dgv_Customers.Rows[e.RowIndex].Cells[2].Value.ToString();
                module.txt_Email.Text = dgv_Customers.Rows[e.RowIndex].Cells[3].Value.ToString();
                module.txt_TenKH.Focus();
                module.ShowDialog();
            }
        }

        private void Dgv_Customers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Customers.SelectedRows.Count > 0)
            {
                txt_IDUser.Text = dgv_Customers.CurrentRow.Cells[0].Value.ToString();
                txt_NameUser.Text = dgv_Customers.CurrentRow.Cells[1].Value.ToString();
                txt_NameLogin.Text = dgv_Customers.CurrentRow.Cells[2].Value.ToString();
                txt_Email.Text = dgv_Customers.CurrentRow.Cells[3].Value.ToString();

                dgv_Customers.Cursor = Cursors.Hand;
            }
            else
            {
                txt_IDUser.Clear();
                txt_NameUser.Clear();
                txt_NameLogin.Clear();
                txt_Email.Clear();
                dgv_Customers.Cursor = Cursors.Default;
            }
        }

        private void Txt_SearchCustomer_TextChanged(object sender, EventArgs e)
        {
            string searchKeyword = txt_SearchCustomer.Text.Trim();

            if (string.IsNullOrEmpty(searchKeyword))
            {
                GetData();
            }
            else
            {
                var searchresult = bllCus.SearchCustomers(searchKeyword);

                dgv_Customers.Rows.Clear();

                foreach (var cus in searchresult)
                {
                    dgv_Customers.Rows.Add(
                        cus.MaTaiKhoan,
                        cus.TenKhachHang,
                        cus.TenTaiKhoan,
                        cus.Email
                    );
                }

                dgv_Customers.Refresh();
            }
        }

        public void GetData()
        {
            try
            {
                userList = bllCus.GetCustomers(); // Lấy danh sách gốc

                dgv_Customers.Rows.Clear();

                foreach (var cus in userList)
                {
                    dgv_Customers.Rows.Add(
                        cus.MaTaiKhoan,
                        cus.TenKhachHang,
                        cus.TenTaiKhoan,
                        cus.Email
                    );
                }

                dgv_Customers.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
