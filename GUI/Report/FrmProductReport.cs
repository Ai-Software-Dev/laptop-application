using BLL;
using DTO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Report
{
    public partial class FrmProductReport : Form
    {
        BLL_Product bll_Product = new BLL_Product();
        private List<sanpham> productList;
        FrmReport cats;
        public bool isAddMode = false;
        public FrmProductReport(FrmReport cat)
        {
            InitializeComponent();
            GetData();
            cats = cat;
            btn_pdf.Click += Btn_pdf_Click;
        }

        private void Btn_pdf_Click(object sender, EventArgs e)
        {
            if (dgv_Product.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "ListProduct.pdf";
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
                            PdfPTable pdfTable = new PdfPTable(dgv_Product.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            // Đọc font từ file
                            string arialFontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
                            string arialBoldFontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arialbd.ttf");

                            BaseFont arialBase = BaseFont.CreateFont(arialFontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                            BaseFont arialBoldBase = BaseFont.CreateFont(arialBoldFontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

                            iTextSharp.text.Font columnHeaderFont = new iTextSharp.text.Font(arialBoldBase, 12, iTextSharp.text.Font.BOLD);
                            iTextSharp.text.Font cellDataFont = new iTextSharp.text.Font(arialBase, 10, iTextSharp.text.Font.NORMAL);
                            
                            foreach (DataGridViewColumn column in dgv_Product.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, columnHeaderFont));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dgv_Product.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    PdfPCell dataCell = new PdfPCell(new Phrase(cell.Value?.ToString() ?? string.Empty, cellDataFont));
                                    pdfTable.AddCell(dataCell);
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();

                                var currentDate = DateTime.Now;
                                string formattedDate = $"TP.HCM, ngày {currentDate:dd} tháng {currentDate:MM} năm {currentDate:yyyy}";

                                var titleFont = new iTextSharp.text.Font(arialBoldBase, 16, iTextSharp.text.Font.BOLD);
                                var dateFont = new iTextSharp.text.Font(arialBase, 12, iTextSharp.text.Font.NORMAL);

                                Paragraph dateParagraph = new Paragraph(formattedDate, dateFont);
                                dateParagraph.Alignment = Element.ALIGN_RIGHT;
                                pdfDoc.Add(dateParagraph);

                                Paragraph titleParagraph = new Paragraph("DANH SÁCH SẢN PHẨM TRONG CỬA HÀNG", titleFont);
                                titleParagraph.Alignment = Element.ALIGN_CENTER;
                                pdfDoc.Add(titleParagraph);

                                pdfDoc.Add(new Paragraph("\n"));

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


        public void GetData()
        {
            productList = bll_Product.GetSanPham();

            dgv_Product.DataSource = productList.Select(p => new
            {
                Ma = p.MaSanPham,
                Ten = p.TenSanPham,
                Gia = p.GiaBan,
                CPU = p.CPU,
                Ram = p.Ram,
                Ocung = p.OCung,
                Manhinh = p.ManHinh, 
                VGA = p.VGA, 
                HDH = p.HeDieuHanh, 
                TL = p.TrongLuong, 
                Pin = p.Pin,
                SL = p.SoLuong
            }).ToList();

            dgv_Product.Columns[0].HeaderText = "Mã sản phẩm";
            dgv_Product.Columns[1].HeaderText = "Tên sản phẩm";
            dgv_Product.Columns[2].HeaderText = "Giá bán";
            dgv_Product.Columns[3].HeaderText = "CPU";
            dgv_Product.Columns[4].HeaderText = "RAM";
            dgv_Product.Columns[5].HeaderText = "Ổ cứng";
            dgv_Product.Columns[6].HeaderText = "Màn hình";
            dgv_Product.Columns[7].HeaderText = "VGA";
            dgv_Product.Columns[8].HeaderText = "Hệ điều hành";
            dgv_Product.Columns[9].HeaderText = "Trọng lượng";
            dgv_Product.Columns[10].HeaderText = "PIN";
            dgv_Product.Columns[11].HeaderText = "Số lượng";
        }
    }
}
