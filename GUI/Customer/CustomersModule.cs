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
    public partial class CustomersModule : Form
    {
        public bool isAddMode = false;
        BLL_Customer bllCus = new BLL_Customer();
        FrmCustomers cuss;
        public CustomersModule(FrmCustomers cus)
        {
            InitializeComponent();
            this.Load += CustomersModule_Load;
            this.btn_huy.Click += Btn_huy_Click;
            this.btn_sua.Click += Btn_sua_Click;
            btn_exit.Click += Btn_exit_Click;
            cuss = cus;
        }

        private void CustomersModule_Load(object sender, EventArgs e)
        {
            UpdateButtonState();
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_sua_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                if (MessageBox.Show("Bạn có chắc muốn sửa khách hàng này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {

                        var updateKH = new user
                        {
                            MaTaiKhoan = int.Parse(txt_MaTK.Text.Trim()),
                            TenKhachHang = txt_TenKH.Text.Trim(),
                            TenTaiKhoan = txt_TenTK.Text.Trim(),
                            MatKhau = txt_MatKhau.Text.Trim(),
                            Email = txt_Email.Text.Trim()
                        };

                        bool isEdited = bllCus.UpdateCustomer(updateKH);

                        if (isEdited)
                        {
                            MessageBox.Show("Sửa Khách Hàng Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cuss.GetData();
                            Clear();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Tên Tài Khoản/Email đã tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi sửa khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_huy_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void UpdateButtonState()
        {
            if (isAddMode)
            {
            }
            else
            {
                btn_sua.Enabled = true;
                lblTittle.Text = "SỬA THÔNG TIN KHÁCH HÀNG";
            }
        }
        public void Clear()
        {
            txt_TenKH.Clear();
            txt_TenTK.Clear();
            txt_MatKhau.Clear();
            txt_Email.Clear();
        }
        public bool CheckInput()
        {
            if (!string.IsNullOrEmpty(txt_MaTK.Text) && !string.IsNullOrEmpty(txt_TenKH.Text) && !string.IsNullOrEmpty(txt_TenTK.Text) && !string.IsNullOrEmpty(txt_MatKhau.Text) && !string.IsNullOrEmpty(txt_Email.Text))
            {
                return true;
            }
            return false;
        }
    }
}
