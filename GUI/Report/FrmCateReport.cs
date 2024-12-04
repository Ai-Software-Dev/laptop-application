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
using BLL;
using GUI.Category;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace GUI.Report
{
    public partial class FrmCateReport : Form
    {
        BLL_Category bllCategory = new BLL_Category();
        private List<hang> hangList;
        FrmReport cats;
        public bool isAddMode = false;
        public FrmCateReport(FrmReport cat)
        {
            InitializeComponent();
            GetData();
            cats = cat;
            btn_pdf.Click += Btn_pdf_Click;
        }

        private void Btn_pdf_Click(object sender, EventArgs e)
        {
            if (dgv_Categories.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "ListCategory.pdf";
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
                            PdfPTable pdfTable = new PdfPTable(dgv_Categories.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            string arialFontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
                            string arialBoldFontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arialbd.ttf");

                            BaseFont arialBase = BaseFont.CreateFont(arialFontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                            BaseFont arialBoldBase = BaseFont.CreateFont(arialBoldFontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

                            iTextSharp.text.Font columnHeaderFont = new iTextSharp.text.Font(arialBoldBase, 12, iTextSharp.text.Font.BOLD);
                            iTextSharp.text.Font cellDataFont = new iTextSharp.text.Font(arialBase, 10, iTextSharp.text.Font.NORMAL);

                            foreach (DataGridViewColumn column in dgv_Categories.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, columnHeaderFont));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dgv_Categories.Rows)
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

                                Paragraph titleParagraph = new Paragraph("DANH SÁCH HÃNG", titleFont);
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
            hangList = bllCategory.GetHangs();

            dgv_Categories.DataSource = hangList.Select(h => new
            {
                Ma = h.MaHang,
                Ten = h.TenHang 
            }).ToList();

            dgv_Categories.Columns[0].HeaderText = "Mã hãng";
            dgv_Categories.Columns[1].HeaderText = "Tên hãng";
        }
    }
}
