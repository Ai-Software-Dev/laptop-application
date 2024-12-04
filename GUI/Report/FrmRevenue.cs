using BLL;
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
using iText.Commons.Actions.Data;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace GUI.Report
{
    public partial class FrmRevenue : Form
    {
        FrmReport cats;
        public bool isAddMode = false;
        BLL_Revenue bll_Revenue = new BLL_Revenue();
        public FrmRevenue(FrmReport cat)
        {
            InitializeComponent();
            cats = cat;
            btnLoc.Click += BtnLoc_Click;
            InitializeDataGridView();
            btn_pdf.Click += Btn_pdf_Click;
        }

        private void Btn_pdf_Click(object sender, EventArgs e)
        {
            if (dgvListProduct.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "RevenueReport.pdf";
                bool fileError = false;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Không thể ghi dữ liệu tới ổ đĩa. Mô tả lỗi:" + ex.Message);
                        }
                    }

                    if (!fileError)
                    {
                        try
                        {
                            string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "tahoma.ttf");
                            BaseFont baseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                            iTextSharp.text.Font vietnameseFont = new iTextSharp.text.Font(baseFont, 12);

                            PdfPTable pdfTable = new PdfPTable(dgvListProduct.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dgvListProduct.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, vietnameseFont));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dgvListProduct.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    PdfPCell dataCell = new PdfPCell(new Phrase(cell.Value?.ToString() ?? string.Empty, vietnameseFont));
                                    dataCell.MinimumHeight = 18;
                                    pdfTable.AddCell(dataCell);
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();

                                iTextSharp.text.Font boldFont = new iTextSharp.text.Font(baseFont, 18, iTextSharp.text.Font.BOLD);

                                Paragraph titleParagraph = new Paragraph("BÁO CÁO DANH SÁCH SẢN PHẨM ĐÃ BÁN", boldFont);
                                titleParagraph.Alignment = Element.ALIGN_CENTER;
                                titleParagraph.SpacingAfter = 15;

                                pdfDoc.Add(titleParagraph);

                                DateTime startDate = dateStart.Value.Date;
                                DateTime endDate = dateEnd.Value.Date;
                                string formattedDate = $"Thời gian: từ ngày {startDate:dd/MM/yyyy} đến ngày {endDate:dd/MM/yyyy}";
                                Paragraph dateParagraph = new Paragraph(formattedDate, vietnameseFont);
                                dateParagraph.Alignment = Element.ALIGN_CENTER;
                                dateParagraph.SpacingAfter = 10;
                                pdfDoc.Add(dateParagraph);

                                int totalQuantity = dgvListProduct.Rows.Cast<DataGridViewRow>().Sum(r => Convert.ToInt32(r.Cells["colSoLuongBan"].Value));
                                double totalRevenue = dgvListProduct.Rows.Cast<DataGridViewRow>().Sum(r => Convert.ToDouble(r.Cells["colThanhTien"].Value));

                                pdfDoc.Add(new Paragraph($"Tổng số lượng sản phẩm đã bán: {totalQuantity}", vietnameseFont) { SpacingAfter = 10 });
                                pdfDoc.Add(new Paragraph($"Tổng doanh thu: {totalRevenue:N0} VND", vietnameseFont) { SpacingAfter = 10 });

                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Xuất file thành công!!!", "Thông báo");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Mô tả lỗi :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có bản ghi nào được Export!!!", "Thông báo");
            }
        }


        private void InitializeDataGridView()
        {
            dgvListProduct.AutoGenerateColumns = false;

            dgvListProduct.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Mã sản phẩm",
                DataPropertyName = "MaSanPham",
                Name = "colMaSanPham"
            });

            dgvListProduct.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Tên sản phẩm",
                DataPropertyName = "TenSanPham",
                Name = "colTenSanPham"
            });

            dgvListProduct.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Số lượng bán",
                DataPropertyName = "SoLuongBan",
                Name = "colSoLuongBan"
            });

            dgvListProduct.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Giá bán",
                DataPropertyName = "GiaBan",
                Name = "colGiaBan"
            });

            dgvListProduct.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Thành tiền",
                DataPropertyName = "ThanhTien",
                Name = "colThanhTien"
            });
            dgvListProduct.EnableHeadersVisualStyles = false;
            dgvListProduct.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 224, 192);
            dgvListProduct.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black; 

            dgvListProduct.RowTemplate.Height = 30; 
        }

        private void BtnLoc_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateStart.Value.Date;
            DateTime endDate = dateEnd.Value.Date;
            List<RevenueReport> products = bll_Revenue.GetProductSales(startDate, endDate);
            dgvListProduct.DataSource = products;
            lblTime.Text = $"Thời gian: từ ngày {startDate:dd/MM/yyyy} đến ngày {endDate:dd/MM/yyyy}";
            int totalQuantity = products.Sum(p => p.SoLuongBan);
            double totalRevenue = products.Sum(p => p.ThanhTien);
            lblSumQuantity.Text = $"Tổng số lượng sản phẩm đã bán: {totalQuantity}";
            lblSumRevenue.Text = $"Tổng doanh thu: {totalRevenue:N0} VND";
        }
    }
}
