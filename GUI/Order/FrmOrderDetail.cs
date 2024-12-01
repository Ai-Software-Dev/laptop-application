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

namespace GUI.Order
{
    public partial class FrmOrderDetail : Form
    {
        private PrintDocument printDocument;
        public FrmOrderDetail()
        {
            InitializeComponent();
            btn_exit.Click += Btn_exit_Click;
            btn_print.Click += Btn_print_Click;

            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(pnCTHD.Width, pnCTHD.Height);
            pnCTHD.DrawToBitmap(bitmap, new Rectangle(0, 0, pnCTHD.Width, pnCTHD.Height));
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
