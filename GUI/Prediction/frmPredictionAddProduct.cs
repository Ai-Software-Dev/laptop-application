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
            if (string.IsNullOrWhiteSpace(txtProductId.Text) ||
        string.IsNullOrWhiteSpace(txtProductName.Text) ||
        string.IsNullOrWhiteSpace(txtQuantitySold.Text) ||
        string.IsNullOrWhiteSpace(txtStockLevel.Text) ||
        string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin sản phẩm.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;  // Dừng hàm nếu có trường dữ liệu chưa được nhập
            }

            // Lấy dữ liệu từ các TextBox
            int productId = int.TryParse(txtProductId.Text, out var id) ? id : 0;
            var productName = txtProductName.Text;
            var quantitySold = int.TryParse(txtQuantitySold.Text, out var qtySold) ? qtySold : 0;
            var stockLevel = int.TryParse(txtStockLevel.Text, out var stock) ? stock : 0;
            var price = double.TryParse(txtPrice.Text, out var prc) ? prc : 0.0;

            InventoryData newProduct = new InventoryData(
                productId,
                productName,
                quantitySold,
                stockLevel,
                price,
                false
            );

            bool needRestock = xlttPML.Predict(newProduct) == 1;

            newProduct.NeedRestock = needRestock;

            lbl_predict.Text = needRestock ? "Cần bổ sung kho hàng" : "Không cần bổ sung kho hàng";
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

            table.Columns.Add("ProductId", typeof(int));
            table.Columns.Add("ProductName", typeof(string));
            table.Columns.Add("QuantitySold", typeof(int));
            table.Columns.Add("StockLevel", typeof(int));
            table.Columns.Add("Price", typeof(double));
            table.Columns.Add("NeedRestock", typeof(bool));

            foreach (var item in inventoryData)
            {
                table.Rows.Add(item.ProductId, item.ProductName, item.QuantitySold, item.StockLevel, item.Price, item.NeedRestock);
            }

            return table;
        }
    }
}
