using GUI.Category;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Report
{
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
            btn_CateRe.Click += Btn_CateRe_Click;
        }

        private void Btn_CateRe_Click(object sender, EventArgs e)
        {
            FrmCateReport module = new FrmCateReport(this);
            module.isAddMode = true;
            module.ShowDialog();
        }

        private void btn_Revenue_Click(object sender, EventArgs e)
        {
            FrmRevenue module = new FrmRevenue(this);
            module.isAddMode = true;
            module.ShowDialog();
        }

        private void btn_ProRe_Click(object sender, EventArgs e)
        {
            FrmProductReport module = new FrmProductReport(this);
            module.isAddMode = true;
            module.ShowDialog();
        }
    }
}
