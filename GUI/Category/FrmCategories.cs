using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Category
{
    public partial class FrmCategories : Form
    {
        BLL_Category bllCategory = new BLL_Category();
        private List<hang> hangList;

        public FrmCategories()
        {
            InitializeComponent();
            GetData();
            txt_SearchCategories.TextChanged += Txt_SearchCategories_TextChanged;
            dgv_Categories.SelectionChanged += Dgv_Categories_SelectionChanged;
            btn_Add.Click += Btn_Add_Click;
            dgv_Categories.CellContentClick += Dgv_Categories_CellContentClick;
        }

        private void Dgv_Categories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgv_Categories.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                CategoriesModule module = new CategoriesModule(this);
                module.txt_MaHang.Text = dgv_Categories.Rows[e.RowIndex].Cells[0].Value.ToString();
                module.txt_TenHang.Text = dgv_Categories.Rows[e.RowIndex].Cells[1].Value.ToString();
                module.pic_Logo.Image = (Image)dgv_Categories.Rows[e.RowIndex].Cells[2].Value;
                module.currentImg = dgv_Categories.Rows[e.RowIndex].Cells[3].Value.ToString();
                module.txt_TenHang.Focus();
                module.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa danh mục này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        var categoryId = int.Parse(dgv_Categories.Rows[e.RowIndex].Cells[0].Value.ToString());

                        bllCategory.DeleteHang(categoryId);

                        MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi xóa danh mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            CategoriesModule module = new CategoriesModule(this);
            module.isAddMode = true;
            module.ShowDialog();
        }

        private void Dgv_Categories_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Categories.SelectedRows.Count > 0)
            {
                txt_IDCategories.Text = dgv_Categories.CurrentRow.Cells[0].Value.ToString();
                txt_NameCategories.Text = dgv_Categories.CurrentRow.Cells[1].Value.ToString();

                // Gán ảnh từ cột Hình Ảnh (Cell[2]) cho PictureBox
                if (dgv_Categories.CurrentRow.Cells[2].Value != DBNull.Value)
                {
                    pic_Logo.Image = (Image)dgv_Categories.CurrentRow.Cells[2].Value; // Lưu ý: gán đúng kiểu Image
                }
                else
                {
                    pic_Logo.Image = Properties.Resources.DefaultImage; // Ảnh mặc định nếu không có ảnh
                }
                dgv_Categories.Cursor = Cursors.Hand;
            }
            else
            {
                txt_IDCategories.Clear();
                txt_IDCategories.Clear();
                pic_Logo.Image = Properties.Resources.DefaultImage;
                dgv_Categories.Cursor = Cursors.Default;
            }
        }

        private void Txt_SearchCategories_TextChanged(object sender, EventArgs e)
        {
            string searchKeyword = txt_SearchCategories.Text.Trim();

            if (string.IsNullOrEmpty(searchKeyword))
            {
                GetData();
            }
            else
            {
                PopulateDataGridView(bllCategory.SearchHangs(searchKeyword));
            }
        }

        public void GetData()
        {
            try
            {
                hangList = bllCategory.GetHangs(); // Lấy danh sách gốc
                PopulateDataGridView(hangList);   // Hiển thị dữ liệu
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PopulateDataGridView(List<hang> data)
        {
            dgv_Categories.Rows.Clear();

            foreach (var cate in data)
            {
                Image logoImage = GetImageFromUrl(cate.Logo);

                dgv_Categories.Rows.Add(
                    cate.MaHang,
                    cate.TenHang,
                    logoImage,
                    cate.Logo
                );
            }

            dgv_Categories.Refresh();
        }

        private Image GetImageFromUrl(string url)
        {
            try
            {
                if (!string.IsNullOrEmpty(url))
                {
                    using (WebClient client = new WebClient())
                    {
                        byte[] imageData = client.DownloadData(url);
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            return Image.FromStream(ms);
                        }
                    }
                }
            }
            catch
            {
                // Trả về ảnh mặc định nếu tải thất bại
                return Properties.Resources.DefaultImage;
            }

            return Properties.Resources.DefaultImage; // Nếu URL null hoặc rỗng
        }
    }
}
