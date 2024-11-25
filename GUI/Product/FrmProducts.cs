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

namespace GUI.Product
{
    public partial class FrmProducts : Form
    {
        BLL_Product bllProduct = new BLL_Product();
        private List<sanpham> sanphamList;
        public FrmProducts()
        {
            InitializeComponent();
            GetData();
            txt_SearchPro.TextChanged += Txt_SearchPro_TextChanged;
            dgv_Products.SelectionChanged += Dgv_Products_SelectionChanged;
            btn_Add.Click += Btn_Add_Click;
            dgv_Products.CellContentClick += Dgv_Products_CellContentClick;
        }

        private void Dgv_Products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgv_Products.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                ProductsModule module = new ProductsModule(this);
                module.txt_MaSP.Text = dgv_Products.Rows[e.RowIndex].Cells[0].Value.ToString();
                module.txt_TenSP.Text = dgv_Products.Rows[e.RowIndex].Cells[1].Value.ToString();
                module.txt_Mota.Text = dgv_Products.Rows[e.RowIndex].Cells[2].Value.ToString();
                module.txt_GiaBan.Text = dgv_Products.Rows[e.RowIndex].Cells[3].Value.ToString();
                module.txt_CPU.Text = dgv_Products.Rows[e.RowIndex].Cells[4].Value.ToString();
                module.txt_Ram.Text = dgv_Products.Rows[e.RowIndex].Cells[5].Value.ToString();
                module.txt_OCung.Text = dgv_Products.Rows[e.RowIndex].Cells[6].Value.ToString();
                module.txt_ManHinh.Text = dgv_Products.Rows[e.RowIndex].Cells[7].Value.ToString();
                module.txt_VGA.Text = dgv_Products.Rows[e.RowIndex].Cells[8].Value.ToString();
                module.txt_HDH.Text = dgv_Products.Rows[e.RowIndex].Cells[9].Value.ToString();
                module.txt_TrongLuong.Text = dgv_Products.Rows[e.RowIndex].Cells[10].Value.ToString();
                module.txt_Pin.Text = dgv_Products.Rows[e.RowIndex].Cells[11].Value.ToString();
                module.txt_SoLuong.Text = dgv_Products.Rows[e.RowIndex].Cells[12].Value.ToString();

                module.pic_Logo.Image = (Image)dgv_Products.Rows[e.RowIndex].Cells[14].Value;
                module.currentImg = dgv_Products.Rows[e.RowIndex].Cells[15].Value.ToString();
                module.txt_MaSP.Focus();
                module.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        var SPId = int.Parse(dgv_Products.Rows[e.RowIndex].Cells[0].Value.ToString());

                        bllProduct.DeleteSanPham(SPId);

                        MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi xóa sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            ProductsModule module = new ProductsModule(this);
            module.isAddMode = true;
            module.ShowDialog();
        }

        private void Dgv_Products_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Products.SelectedRows.Count > 0)
            {
                txt_IDPro.Text = dgv_Products.CurrentRow.Cells[0].Value.ToString();
                txt_NamePro.Text = dgv_Products.CurrentRow.Cells[1].Value.ToString();
                txt_DescripPro.Text = dgv_Products.CurrentRow.Cells[2].Value.ToString();
                txt_PricePro.Text = dgv_Products.CurrentRow.Cells[3].Value.ToString();
                txt_CPU.Text = dgv_Products.CurrentRow.Cells[4].Value.ToString();
                txt_Ram.Text = dgv_Products.CurrentRow.Cells[5].Value.ToString();
                txt_DiskPro.Text = dgv_Products.CurrentRow.Cells[6].Value.ToString();
                txt_Screen.Text = dgv_Products.CurrentRow.Cells[7].Value.ToString();
                txt_VGA.Text = dgv_Products.CurrentRow.Cells[8].Value.ToString();
                txt_SystemPro.Text = dgv_Products.CurrentRow.Cells[9].Value.ToString();
                txt_Weight.Text = dgv_Products.CurrentRow.Cells[10].Value.ToString();
                txt_Pin.Text = dgv_Products.CurrentRow.Cells[11].Value.ToString();
                txt_StockPro.Text = dgv_Products.CurrentRow.Cells[12].Value.ToString();
                txt_NameCate.Text = dgv_Products.CurrentRow.Cells[13].Value.ToString();

                // Gán ảnh từ cột Hình Ảnh (Cell[2]) cho PictureBox
                if (dgv_Products.CurrentRow.Cells[14].Value != DBNull.Value)
                {
                    pic_Logo.Image = (Image)dgv_Products.CurrentRow.Cells[14].Value; // Lưu ý: gán đúng kiểu Image
                }
                else
                {
                    pic_Logo.Image = Properties.Resources.DefaultImage; // Ảnh mặc định nếu không có ảnh
                }
                dgv_Products.Cursor = Cursors.Hand;
            }
            else
            {
                txt_IDPro.Clear();
                txt_NamePro.Clear();
                txt_DescripPro.Clear();
                txt_PricePro.Clear();
                txt_CPU.Clear();
                txt_Ram.Clear();
                txt_DiskPro.Clear();
                txt_Screen.Clear();
                txt_VGA.Clear();
                txt_SystemPro.Clear();
                txt_Weight.Clear();
                txt_Pin.Clear();
                txt_StockPro.Clear();
                txt_NameCate.Clear();
                pic_Logo.Image = Properties.Resources.DefaultImage;
                dgv_Products.Cursor = Cursors.Default;
            }
        }

        private void Txt_SearchPro_TextChanged(object sender, EventArgs e)
        {
            string searchKeyword = txt_SearchPro.Text.Trim();

            if (string.IsNullOrEmpty(searchKeyword))
            {
                GetData();
            }
            else
            {
                PopulateDataGridView(bllProduct.SearchSanPhams(searchKeyword));
            }
        }

        public void GetData()
        {
            try
            {
                sanphamList = bllProduct.GetSanPham();
                PopulateDataGridView(sanphamList);   // Hiển thị dữ liệu
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PopulateDataGridView(List<sanpham> data)
        {
            dgv_Products.Rows.Clear();

            foreach (var sp in data)
            {
                Image logoImage = GetImageFromUrl(sp.HinhAnh);

                dgv_Products.Rows.Add(
                    sp.MaSanPham,
                    sp.TenSanPham,
                    sp.MoTa,
                    sp.GiaBan,
                    sp.CPU,
                    sp.Ram,
                    sp.OCung,
                    sp.ManHinh,
                    sp.VGA,
                    sp.HeDieuHanh,
                    sp.TrongLuong,
                    sp.Pin,
                    sp.SoLuong,
                    sp.hang.TenHang,
                    logoImage,
                    sp.HinhAnh
                );
            }

            dgv_Products.Refresh();
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
