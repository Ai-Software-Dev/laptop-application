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

namespace GUI.Category
{
    public partial class CategoriesModule : Form
    {
        public bool isAddMode = false;
        BLL_Category bllCategory = new BLL_Category();
        FrmCategories cats;
        public string currentImg;
        public CategoriesModule(FrmCategories cat)
        {
            InitializeComponent();
            this.Load += CategoriesModule_Load;
            this.btn_huy.Click += Btn_huy_Click;
            this.btn_sua.Click += Btn_sua_Click;
            this.btn_them.Click += Btn_them_Click;
            btn_Browse.Click += Btn_Browse_Click;
            btn_exit.Click += Btn_exit_Click;
            cats = cat;
        }

        private void CategoriesModule_Load(object sender, EventArgs e)
        {
            UpdateButtonState();
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
                if (MessageBox.Show("Bạn có chắc muốn thêm hãng này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string logoUrl = string.Empty;
                    string publicId = string.Empty;
                    string folder = "IMG_PTPM/Category"; // Thư mục lưu hình ảnh trên Cloudinary

                    try
                    {
                        // Lấy URL hình ảnh từ Cloudinary
                        CloudIService cloudService = new CloudIService();
                        logoUrl = cloudService.UploadImageCategory(pic_Logo.ImageLocation);

                        // Lấy publicId từ URL trả về
                        publicId = logoUrl.Substring(logoUrl.LastIndexOf('/') + 1).Split('.')[0];

                        var newhang = new hang
                        {
                            TenHang = txt_TenHang.Text.Trim(),
                            Logo = logoUrl
                        };

                        bool isAdded = bllCategory.AddHang(newhang);

                        if (isAdded)
                        {
                            MessageBox.Show("Thêm Danh Mục Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cats.GetData();
                            Clear();
                            this.Close();
                        }
                        else
                        {
                            // Xóa hình ảnh nếu tên danh mục không hợp lệ
                            if (!string.IsNullOrEmpty(publicId))
                            {
                                cloudService.DeleteImage(publicId, folder);
                            }
                            MessageBox.Show("Tên Danh Mục đã tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (MessageBox.Show("Bạn có chắc muốn sửa danh mục này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string logoUrl = string.Empty;
                    string publicId = string.Empty;
                    string folder = "IMG_PTPM/Category"; // Thư mục lưu hình ảnh trên Cloudinary
                    try
                    {
                        // Lấy URL hình ảnh từ Cloudinary
                        CloudIService cloudService = new CloudIService();
                        logoUrl = cloudService.UploadImageCategory(pic_Logo.ImageLocation);

                        // Lấy publicId từ URL trả về
                        publicId = logoUrl.Substring(logoUrl.LastIndexOf('/') + 1).Split('.')[0];

                        var updatehang = new hang();

                        if (pic_Logo.ImageLocation != null)
                        {
                            updatehang = new hang
                            {
                                MaHang = int.Parse(txt_MaHang.Text.Trim()),
                                TenHang = txt_TenHang.Text.Trim(),
                                Logo = logoUrl
                            };
                        }
                        else
                        {
                            updatehang = new hang
                            {
                                MaHang = int.Parse(txt_MaHang.Text.Trim()),
                                TenHang = txt_TenHang.Text.Trim(),
                                Logo = currentImg
                            };
                        }    


                        bool isEdited = bllCategory.UpdateHang(updatehang);

                        if (isEdited)
                        {
                            if (pic_Logo.ImageLocation != null)
                            {
                                cloudService.DeleteImage(currentImg.Substring(logoUrl.LastIndexOf('/') + 1).Split('.')[0], folder);
                            }    
                            MessageBox.Show("Sửa Danh Mục Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cats.GetData();
                            Clear();
                            this.Close();
                        }
                        else
                        {
                            // Xóa hình ảnh nếu tên danh mục không hợp lệ
                            if (!string.IsNullOrEmpty(publicId))
                            {
                                cloudService.DeleteImage(publicId, folder);
                            }
                            MessageBox.Show("Tên Danh Mục đã tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Xóa hình ảnh nếu xảy ra lỗi khi thêm
                        if (!string.IsNullOrEmpty(publicId))
                        {
                            new CloudIService().DeleteImage(publicId, folder);
                        }
                        MessageBox.Show("Đã xảy ra lỗi khi sửa danh mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                txt_MaHang.Text = (bllCategory.GetLastIDHang() + 1).ToString();
                btn_them.Enabled = true;
                btn_sua.Enabled = false;
                lblTittle.Text = "THÊM THÔNG TIN DANH MỤC";
            }
            else
            {
                btn_sua.Enabled = true;
                btn_them.Enabled = false;
                lblTittle.Text = "SỬA THÔNG TIN DANH MỤC";
            }
        }
        public void Clear()
        {
            txt_TenHang.Clear();
            pic_Logo.Image = Properties.Resources.DefaultImage;
        }
        public bool CheckInput()
        {
            if (!string.IsNullOrEmpty(txt_MaHang.Text) && !string.IsNullOrEmpty(txt_TenHang.Text) && pic_Logo.Image != null && pic_Logo.Image != Properties.Resources.DefaultImage)
            {
                return true;
            }
            return false;
        }
    }
}
