
namespace GUI.Statistics
{
    partial class FrmStatistics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbyear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chartProduct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTopCustomers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // chartRevenue
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend1);
            this.chartRevenue.Location = new System.Drawing.Point(12, 112);
            this.chartRevenue.Name = "chartRevenue";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartRevenue.Series.Add(series1);
            this.chartRevenue.Size = new System.Drawing.Size(395, 597);
            this.chartRevenue.TabIndex = 0;
            this.chartRevenue.Text = "chart1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(540, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 45);
            this.label7.TabIndex = 15;
            this.label7.Text = "Thống kê";
            // 
            // cbbyear
            // 
            this.cbbyear.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbyear.FormattingEnabled = true;
            this.cbbyear.Location = new System.Drawing.Point(70, 49);
            this.cbbyear.Name = "cbbyear";
            this.cbbyear.Size = new System.Drawing.Size(121, 32);
            this.cbbyear.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "Năm";
            // 
            // chartProduct
            // 
            chartArea2.Name = "ChartArea1";
            this.chartProduct.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartProduct.Legends.Add(legend2);
            this.chartProduct.Location = new System.Drawing.Point(430, 112);
            this.chartProduct.Name = "chartProduct";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartProduct.Series.Add(series2);
            this.chartProduct.Size = new System.Drawing.Size(395, 597);
            this.chartProduct.TabIndex = 18;
            this.chartProduct.Text = "chart1";
            // 
            // chartTopCustomers
            // 
            chartArea3.Name = "ChartArea1";
            this.chartTopCustomers.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartTopCustomers.Legends.Add(legend3);
            this.chartTopCustomers.Location = new System.Drawing.Point(849, 112);
            this.chartTopCustomers.Name = "chartTopCustomers";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartTopCustomers.Series.Add(series3);
            this.chartTopCustomers.Size = new System.Drawing.Size(395, 597);
            this.chartTopCustomers.TabIndex = 19;
            this.chartTopCustomers.Text = "chart1";
            // 
            // FrmStatistics
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1256, 748);
            this.Controls.Add(this.chartTopCustomers);
            this.Controls.Add(this.chartProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbyear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chartRevenue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStatistics";
            this.Text = "FrmStatistics";
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbyear;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProduct;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopCustomers;
    }
}