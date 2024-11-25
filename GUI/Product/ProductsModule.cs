using BLL;
using DTO;
using CloudService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Product
{
    public partial class ProductsModule : Form
    {
        public bool isAddMode = false;
        BLL_Product bllPro = new BLL_Product();
        BLL_Category bllCate = new BLL_Category();
        FrmProducts pros;
        public string currentImg;
        public ProductsModule(FrmProducts pro)
        {
            InitializeComponent();
            cbb_Hang.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Load += ProductsModule_Load;
            this.btn_huy.Click += Btn_huy_Click;
            this.btn_sua.Click += Btn_sua_Click;
            this.btn_them.Click += Btn_them_Click;
            btn_Browse.Click += Btn_Browse_Click;
            btn_exit.Click += Btn_exit_Click;
            txt_SoLuong.KeyPress += Txt_SoLuong_KeyPress;
            txt_GiaBan.KeyPress += Txt_GiaBan_KeyPress;
            pros = pro;

        }

        private void Txt_GiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_Browse_Click(object sender, EventArgs e)
        {
            // Chọn ảnh từ file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pic_Logo.Image = Image.FromFile(openFileDialog.FileName);
                pic_Logo.ImageLocation = openFileDialog.FileName;
            }
        }

        private void Btn_them_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                if (MessageBox.Show("Bạn có chắc muốn thêm sản phẩm này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string logoUrl = string.Empty;
                    string publicId = string.Empty;
                    string folder = "IMG_PTPM/Products"; // Thư mục lưu hình ảnh trên Cloudinary

                    try
                    {
                        // Lấy URL hình ảnh từ Cloudinary
                        CloudIService cloudService = new CloudIService();
                        logoUrl = cloudService.UploadImageProduct(pic_Logo.ImageLocation);

                        // Lấy publicId từ URL trả về
                        publicId = logoUrl.Substring(logoUrl.LastIndexOf('/') + 1).Split('.')[0];

                        var newSP = new sanpham
                        {
                            TenSanPham = txt_TenSP.Text.Trim(),
                            MoTa = txt_Mota.Text.Trim(),
                            GiaBan = double.Parse(txt_GiaBan.Text.Trim()),
                            CPU = txt_CPU.Text.Trim(),
                            Ram = txt_Ram.Text.Trim(),
                            OCung = txt_OCung.Text.Trim(),
                            ManHinh = txt_ManHinh.Text.Trim(),
                            VGA = txt_VGA.Text.Trim(),
                            HeDieuHanh = txt_HDH.Text.Trim(),
                            TrongLuong = txt_TrongLuong.Text.Trim(),
                            Pin = txt_Pin.Text.Trim(),
                            SoLuong = int.Parse(txt_SoLuong.Text.Trim()),
                            MaHang =  int.Parse(cbb_Hang.SelectedValue.ToString()),
                            HinhAnh = logoUrl
                        };

                        bool isAdded = bllPro.AddSanPham(newSP);

                        if (isAdded)
                        {
                            MessageBox.Show("Thêm Sản Phẩm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            pros.GetData();
                            Clear();
                            this.Close();
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(publicId))
                            {
                                cloudService.DeleteImage(publicId, folder);
                            }
                            MessageBox.Show("Tên sản phẩm đã tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Xóa hình ảnh nếu xảy ra lỗi khi thêm
                        if (!string.IsNullOrEmpty(publicId))
                        {
                            new CloudIService().DeleteImage(publicId, folder);
                        }
                        MessageBox.Show("Đã xảy ra lỗi khi thêm danh mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_sua_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                if (MessageBox.Show("Bạn có chắc muốn sửa sản phẩm này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string logoUrl = string.Empty;
                    string publicId = string.Empty;
                    string folder = "IMG_PTPM/Products"; // Thư mục lưu hình ảnh trên Cloudinary
                    try
                    {
                        // Lấy URL hình ảnh từ Cloudinary
                        CloudIService cloudService = new CloudIService();
                        logoUrl = cloudService.UploadImageProduct(pic_Logo.ImageLocation);

                        // Lấy publicId từ URL trả về
                        publicId = logoUrl.Substring(logoUrl.LastIndexOf('/') + 1).Split('.')[0];

                        var updateSP = new sanpham();

                        if (pic_Logo.ImageLocation != null)
                        {
                            updateSP = new sanpham
                            {
                                MaSanPham = int.Parse(txt_MaSP.Text.Trim()),
                                TenSanPham = txt_TenSP.Text.Trim(),
                                MoTa = txt_Mota.Text.Trim(),
                                GiaBan = double.Parse(txt_GiaBan.Text.Trim()),
                                CPU = txt_CPU.Text.Trim(),
                                Ram = txt_Ram.Text.Trim(),
                                OCung = txt_OCung.Text.Trim(),
                                ManHinh = txt_ManHinh.Text.Trim(),
                                VGA = txt_VGA.Text.Trim(),
                                HeDieuHanh = txt_HDH.Text.Trim(),
                                TrongLuong = txt_TrongLuong.Text.Trim(),
                                Pin = txt_Pin.Text.Trim(),
                                SoLuong = int.Parse(txt_SoLuong.Text.Trim()),
                                MaHang = int.Parse(cbb_Hang.SelectedValue.ToString()),
                                HinhAnh = logoUrl
                            };
                        }
                        else
                        {
                            updateSP = new sanpham
                            {
                                MaSanPham = int.Parse(txt_MaSP.Text.Trim()),
                                TenSanPham = txt_TenSP.Text.Trim(),
                                MoTa = txt_Mota.Text.Trim(),
                                GiaBan = double.Parse(txt_GiaBan.Text.Trim()),
                                CPU = txt_CPU.Text.Trim(),
                                Ram = txt_Ram.Text.Trim(),
                                OCung = txt_OCung.Text.Trim(),
                                ManHinh = txt_ManHinh.Text.Trim(),
                                VGA = txt_VGA.Text.Trim(),
                                HeDieuHanh = txt_HDH.Text.Trim(),
                                TrongLuong = txt_TrongLuong.Text.Trim(),
                                Pin = txt_Pin.Text.Trim(),
                                SoLuong = int.Parse(txt_SoLuong.Text.Trim()),
                                MaHang = int.Parse(cbb_Hang.SelectedValue.ToString()),
                                HinhAnh = currentImg
                            };
                        }    

                        bool isEdited = bllPro.UpdateSanPham(updateSP);

                        if (isEdited)
                        {
                            if (pic_Logo.ImageLocation != null)
                            {
                                cloudService.DeleteImage(currentImg.Substring(logoUrl.LastIndexOf('/') + 1).Split('.')[0], folder);

                            }
                            MessageBox.Show("Sửa Sản Phẩm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            pros.GetData();
                            Clear();
                            this.Close();
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(publicId))
                            {
                                cloudService.DeleteImage(publicId, folder);
                            }
                            MessageBox.Show("Tên Sản Phẩm đã tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        if (!string.IsNullOrEmpty(publicId))
                        {
                            new CloudIService().DeleteImage(publicId, folder);
                        }
                        MessageBox.Show("Đã xảy ra lỗi khi sửa sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ProductsModule_Load(object sender, EventArgs e)
        {
            LoadCBBHang();
            UpdateButtonState();
        }
        public void LoadCBBHang()
        {
            cbb_Hang.DataSource = bllCate.GetHangs();
            cbb_Hang.DisplayMember = "TenHang";
            cbb_Hang.ValueMember = "MaHang";
        }
        public void UpdateButtonState()
        {
            if (isAddMode)
            {
                cbb_Hang.SelectedIndex = 0;
                txt_MaSP.Text = (bllPro.GetLastIDSanPham() + 1).ToString();
                btn_them.Enabled = true;
                btn_sua.Enabled = false;
                lblTittle.Text = "THÊM THÔNG TIN SẢN PHẨM";
            }
            else
            {
                string hang = pros.dgv_Products.CurrentRow.Cells[13].Value.ToString();
                cbb_Hang.Text = hang;

                btn_sua.Enabled = true;
                btn_them.Enabled = false;
                lblTittle.Text = "SỬA THÔNG TIN SẢN PHẨM";
            }
        }
        public void Clear()
        {
            txt_TenSP.Clear();
            txt_Mota.Clear();
            txt_GiaBan.Clear();
            txt_CPU.Clear();
            txt_Ram.Clear();
            txt_OCung.Clear();
            txt_ManHinh.Clear();
            txt_VGA.Clear();
            txt_HDH.Clear();
            txt_TrongLuong.Clear();
            txt_Pin.Clear();
            txt_SoLuong.Clear();
            pic_Logo.Image = Properties.Resources.DefaultImage;
        }
        public bool CheckInput()
        {
            if (!string.IsNullOrEmpty(txt_MaSP.Text) && !string.IsNullOrEmpty(txt_TenSP.Text) && !string.IsNullOrEmpty(txt_Mota.Text) && !string.IsNullOrEmpty(txt_GiaBan.Text) && !string.IsNullOrEmpty(txt_CPU.Text) && !string.IsNullOrEmpty(txt_Ram.Text) && !string.IsNullOrEmpty(txt_OCung.Text) && !string.IsNullOrEmpty(txt_ManHinh.Text) && !string.IsNullOrEmpty(txt_VGA.Text) && !string.IsNullOrEmpty(txt_HDH.Text) && !string.IsNullOrEmpty(txt_TrongLuong.Text) && !string.IsNullOrEmpty(txt_Pin.Text) && !string.IsNullOrEmpty(txt_SoLuong.Text) && pic_Logo.Image != null && pic_Logo.Image != Properties.Resources.DefaultImage)
            {
                return true;
            }
            return false;
        }
    }
}
