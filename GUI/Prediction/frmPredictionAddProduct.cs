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
using DAL;
using PML;


namespace GUI.Prediction
{
    public partial class frmPredictionAddProduct : Form
    {
        private DAL_AI dalAI;
        private XuLyThuatToanPML xlttPML;
        public frmPredictionAddProduct()
        {
            InitializeComponent();
            dalAI = new DAL_AI();
            xlttPML = new XuLyThuatToanPML();
            loadDataTrain();
            btn_predict.Click += Btn_predict_Click;
            dgv_dataTrain.CellClick += Dgv_dataTrain_CellClick;

            List<InventoryData> trainingData = dalAI.getProductData();
            xlttPML.TrainModel(trainingData);
        }

        private void Dgv_dataTrain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgv_dataTrain.Rows[e.RowIndex];

                var productId = selectedRow.Cells["ProductId"].Value?.ToString() ?? string.Empty;
                var productName = selectedRow.Cells["ProductName"].Value?.ToString() ?? string.Empty;
                var quantitySold = selectedRow.Cells["QuantitySold"].Value?.ToString() ?? string.Empty;
                var stockLevel = selectedRow.Cells["StockLevel"].Value?.ToString() ?? string.Empty;
                var price = selectedRow.Cells["Price"].Value?.ToString() ?? string.Empty;

                txtProductId.Text = productId;
                txtProductName.Text = productName;
                txtQuantitySold.Text = quantitySold;
                txtStockLevel.Text = stockLevel;
                txtPrice.Text = price;
            }
        }

        private void Btn_predict_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập
            if (string.IsNullOrWhiteSpace(txtProductId.Text) ||
                string.IsNullOrWhiteSpace(txtProductName.Text) ||
                string.IsNullOrWhiteSpace(txtQuantitySold.Text) ||
                string.IsNullOrWhiteSpace(txtStockLevel.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin sản phẩm.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra tính hợp lệ của các giá trị số
            if (!int.TryParse(txtQuantitySold.Text, out var quantitySold) || quantitySold < 0)
            {
                MessageBox.Show("Số lượng đã bán phải là giá trị hợp lệ và không âm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtStockLevel.Text, out var stockLevel) || stockLevel < 0)
            {
                MessageBox.Show("Mức tồn kho phải là giá trị hợp lệ và không âm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtPrice.Text, out var price) || price <= 0)
            {
                MessageBox.Show("Giá sản phẩm phải là giá trị hợp lệ và lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tạo đối tượng InventoryData
            InventoryData newProduct = new InventoryData(
                int.Parse(txtProductId.Text),
                txtProductName.Text,
                quantitySold,
                stockLevel,
                price,
                false
            );

            try
            {
                // Dự đoán sản phẩm có cần nhập thêm kho hay không
                bool needRestock = xlttPML.Predict(newProduct) == 1;
                newProduct.NeedRestock = needRestock;

                lbl_predict.Text = needRestock ? "Cần bổ sung kho hàng" : "Không cần bổ sung kho hàng";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi dự đoán: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadDataTrain()
        {
            List<InventoryData> inventoryDatas = dalAI.getProductData();

            if (inventoryDatas == null || inventoryDatas.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable dataTable = ConvertToDataTable(inventoryDatas);
            dgv_dataTrain.DataSource = dataTable;
        }

        private DataTable ConvertToDataTable(List<InventoryData> inventoryData)
        {
            DataTable table = new DataTable();

            var properties = typeof(InventoryData).GetProperties();
            foreach (var prop in properties)
            {
                table.Columns.Add(prop.Name, prop.PropertyType);
            }

            foreach (var item in inventoryData)
            {
                var row = table.NewRow();
                foreach (var prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item);
                }
                table.Rows.Add(row);
            }

            return table;
        }
    }
}
