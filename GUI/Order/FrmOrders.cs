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

namespace GUI.Order
{
    public partial class FrmOrders : Form
    {
        BLL_Order bllOrder = new BLL_Order();
        private List<hoadon> orderList;
        public FrmOrders()
        {
            InitializeComponent();
            GetData();
            txt_SearchOrders.TextChanged += Txt_SearchOrders_TextChanged;
            dgv_Orders.SelectionChanged += Dgv_Orders_SelectionChanged;
            dgv_Orders.CellContentClick += Dgv_Orders_CellContentClick;
            dgv_Orders.CellFormatting += Dgv_Orders_CellFormatting;
        }

        private void Dgv_Orders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra nếu cột là cột trạng thái (giả sử cột trạng thái ở index 7)
            if (e.Value != null && e.Value.ToString() == "Đã xác nhận")
            {
                e.CellStyle.ForeColor = Color.Green;
                e.CellStyle.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            }
            else
            {
                e.CellStyle.ForeColor = Color.Black; // Màu mặc định
                e.CellStyle.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            }
        }

        private void Dgv_Orders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgv_Orders.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                if (dgv_Orders.Rows[e.RowIndex].Cells[4].Value.ToString() == "Chưa xác nhận")
                {
                    if (MessageBox.Show("Bạn có chắc muốn xác nhận đơn hàng này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            var OrdId = int.Parse(dgv_Orders.Rows[e.RowIndex].Cells[0].Value.ToString());

                            bllOrder.UpdateOrders(OrdId);

                            MessageBox.Show("Xác nhận thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GetData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Đã xảy ra lỗi khi xác nhận đơn hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }    
            }
            else if (colName == "Details")
            {
                FrmOrderDetail frm = new FrmOrderDetail();
                var OrdId = int.Parse(dgv_Orders.Rows[e.RowIndex].Cells[0].Value.ToString());
                HoaDonChiTiet hd = bllOrder.GetHoaDonByID(OrdId);
                frm.lblMaHD.Text = hd.MaHoaDon.ToString();
                frm.lblHT.Text = hd.TenKhachHang.ToString();
                frm.lblSDT.Text = hd.SDT.ToString();
                frm.lblDiaChi.Text = hd.DiaChi.ToString();
                frm.lblNgayMua.Text = hd.NgayMua.ToString();
                frm.lblHinhThuc.Text = hd.HinhThucThanhToan.ToString();

                int i = 1;
                foreach (var sp in hd.ChiTietSanPhams)
                {
                    frm.dgv_OrderDetail.Rows.Add(
                        i,
                        sp.TenSanPham,
                        sp.SoLuong,
                        sp.GiaBan.ToString("N0"),
                        sp.ThanhTien.ToString("N0")
                    );
                    ++i;
                }

                frm.lblTongTien.Text = (hd.TongTien - 100000).ToString("N0") + " VNĐ";
                frm.lblPhiVanChuyen.Text = "100.000 VNĐ";
                frm.lblThanhTien.Text = hd.TongTien.ToString("N0") + " VNĐ";

                if (hd.TrangThai != "Đã xác nhận")
                {
                    frm.btn_print.Enabled = false;
                }    

                frm.ShowDialog();
            }    
        }

        private void Dgv_Orders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Orders.SelectedRows.Count > 0)
            {
                txt_MaDH.Text = dgv_Orders.CurrentRow.Cells[0].Value.ToString();
                txt_NgayMua.Text = dgv_Orders.CurrentRow.Cells[1].Value.ToString();
                txt_HinhThuc.Text = dgv_Orders.CurrentRow.Cells[2].Value.ToString();
                txt_TongTien.Text = dgv_Orders.CurrentRow.Cells[3].Value.ToString();

                string trangThai = dgv_Orders.CurrentRow.Cells[4].Value.ToString();
                txt_TrangThai.Text = trangThai;
                // Đổi màu chữ cho txt_TrangThai
                if (trangThai == "Đã xác nhận")
                {
                    txt_TrangThai.ForeColor = Color.Green; // Màu xanh lá
                    txt_TrangThai.Font = new Font("Tahoma", 10.8f, FontStyle.Bold);
                }
                else
                {
                    txt_TrangThai.ForeColor = Color.Black; // Màu mặc định
                    txt_TrangThai.Font = new Font("Tahoma", 10.8f, FontStyle.Regular);
                }

                dgv_Orders.Cursor = Cursors.Hand;
            }
            else
            {
                txt_MaDH.Clear();
                txt_NgayMua.Clear();
                txt_HinhThuc.Clear();
                txt_TongTien.Clear();
                txt_TrangThai.Clear();
                dgv_Orders.Cursor = Cursors.Default;
            }
        }

        private void Txt_SearchOrders_TextChanged(object sender, EventArgs e)
        {
            string searchKeyword = txt_SearchOrders.Text.Trim();

            if (string.IsNullOrEmpty(searchKeyword))
            {
                GetData();
            }
            else
            {
                var searchresult = bllOrder.SearchHoaDons(searchKeyword);

                dgv_Orders.Rows.Clear();

                foreach (var ord in searchresult)
                {
                    dgv_Orders.Rows.Add(
                        ord.MaHoaDon,
                        ord.NgayMua,
                        ord.HinhThucThanhToan,
                        ord.TongTien != null ? $"{ord.TongTien.Value.ToString("N0")}₫" : "0₫",
                        ord.TrangThai
                    );
                }

                dgv_Orders.Refresh();
            }
        }

        public void GetData()
        {
            try
            {
                orderList = bllOrder.GetHoaDon(); // Lấy danh sách gốc

                dgv_Orders.Rows.Clear();

                foreach (var ord in orderList)
                {
                    dgv_Orders.Rows.Add(
                        ord.MaHoaDon,
                        ord.NgayMua,
                        ord.HinhThucThanhToan,
                        ord.TongTien != null ? $"{ord.TongTien.Value.ToString("N0")}₫" : "0₫",
                        ord.TrangThai
                    );
                }

                dgv_Orders.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
