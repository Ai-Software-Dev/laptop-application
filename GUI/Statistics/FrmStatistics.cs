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

namespace GUI.Statistics
{
    public partial class FrmStatistics : Form
    {
        BLL_Statistics bllSta = new BLL_Statistics();
        public FrmStatistics()
        {
            InitializeComponent();
            this.Load += FrmStatistics_Load;
            cbbyear.SelectedIndexChanged += Cbbyear_SelectedIndexChanged;
        }

        private void Cbbyear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbyear.SelectedItem != null)
            {
                int selectedYear = (int)cbbyear.SelectedItem;
                LoadChart(selectedYear);
            }
        }

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            LoadComboBoxYears();

            if (cbbyear.Items.Count > 0)
            {
                cbbyear.SelectedIndex = 0; // Chọn năm đầu tiên
                LoadChart((int)cbbyear.SelectedItem);
            }
        }

        private void LoadComboBoxYears()
        {
            cbbyear.DataSource = bllSta.GetDistinctYears();
            cbbyear.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void LoadChart(int year)
        {
            // Lấy dữ liệu từ BLL
            List<RevenueByMonth> doanhThuTheoThang = bllSta.GetRevenueByMonth(year);
            List<ProductSalesByMonth> sanPhamTheoThang = bllSta.GetProductSalesByMonth(year);
            List<TopCustomer> topKhachHang = bllSta.GetTopCustomers(year);

            // Cập nhật biểu đồ
            UpdateChart(doanhThuTheoThang, sanPhamTheoThang, topKhachHang);
        }

        private void UpdateChart(List<RevenueByMonth> doanhThu, List<ProductSalesByMonth> sanPham, List<TopCustomer> khachHang)
        {
            // Cập nhật biểu đồ doanh thu
            chartRevenue.Series[0].Points.Clear();
            chartRevenue.Series[0].Name = "Doanh Thu"; // Đổi tên Series
            chartRevenue.Series[0].Color = System.Drawing.Color.Blue; // Đổi màu Series thành màu xanh
            foreach (var item in doanhThu)
            {
                chartRevenue.Series[0].Points.AddXY($"Tháng {item.Thang}", item.TongDoanhThu);
            }

            // Cập nhật biểu đồ số lượng sản phẩm bán ra
            chartProduct.Series[0].Points.Clear();
            chartProduct.Series[0].Name = "Sản Phẩm Bán Ra"; // Đổi tên Series
            chartProduct.Series[0].Color = System.Drawing.Color.Green; // Đổi màu Series thành màu xanh lá
            foreach (var item in sanPham)
            {
                chartProduct.Series[0].Points.AddXY($"Tháng {item.Thang}", item.TongSoLuong);
            }

            // Cập nhật biểu đồ khách hàng
            chartTopCustomers.Series[0].Points.Clear();
            chartTopCustomers.Series[0].Name = "Khách Hàng"; // Đổi tên Series
            chartTopCustomers.Series[0].Color = System.Drawing.Color.Red; // Đổi màu Series thành màu đỏ
            foreach (var item in khachHang)
            {
                chartTopCustomers.Series[0].Points.AddXY(item.TenKhachHang, item.TongTien);
            }
        }
    }
}
