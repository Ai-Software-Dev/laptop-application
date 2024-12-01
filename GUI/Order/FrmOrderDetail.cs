using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.IO.Image;
using iText.Kernel.Pdf.Canvas;

namespace GUI.Order
{
    public partial class FrmOrderDetail : Form
    {
        public FrmOrderDetail()
        {
            InitializeComponent();
            btn_exit.Click += Btn_exit_Click;
            btn_print.Click += Btn_print_Click;
        }

        private void ExportToPDF(string filePath)
        {
            // Tạo một đối tượng PdfWriter để ghi dữ liệu ra file PDF
            using (PdfWriter writer = new PdfWriter(filePath))
            {
                // Tạo một đối tượng PdfDocument với PdfWriter
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    // Tạo một đối tượng Document từ PdfDocument
                    Document document = new Document(pdf);

                    // Chỉ định kích thước cố định cho trang PDF (874x770)
                    float pageWidth = 874;
                    float pageHeight = 770;
                    pdf.SetDefaultPageSize(new iText.Kernel.Geom.PageSize(pageWidth, pageHeight));

                    // Chuyển panel thành hình ảnh bitmap
                    Bitmap bitmap = new Bitmap(pnCTHD.Width, pnCTHD.Height);
                    pnCTHD.DrawToBitmap(bitmap, new Rectangle(0, 0, pnCTHD.Width, pnCTHD.Height));

                    // Chuyển Bitmap thành mảng byte
                    using (MemoryStream ms = new MemoryStream())
                    {
                        bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        byte[] byteArray = ms.ToArray();

                        // Tạo iTextSharp Image từ byte array
                        iText.Layout.Element.Image pdfImage = new iText.Layout.Element.Image(iText.IO.Image.ImageDataFactory.Create(byteArray));

                        // Đảm bảo hình ảnh được vẽ đúng kích thước trên trang PDF
                        pdfImage.SetWidth(pageWidth);
                        pdfImage.SetHeight(pageHeight);

                        // Thêm hình ảnh vào trang PDF
                        document.Add(pdfImage);

                        // Đóng document sau khi hoàn thành
                        document.Close();
                    }
                }
            }

            MessageBox.Show("PDF đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.Title = "Save as PDF";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Gọi phương thức xuất ra PDF
                ExportToPDF(saveFileDialog.FileName);
            }
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
