namespace GUI.Report
{
    partial class FrmProductReport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Product = new System.Windows.Forms.DataGridView();
            this.btn_pdf = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1387, 27);
            this.panel1.TabIndex = 104;
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.btn_exit.IconColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(1342, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(45, 29);
            this.btn_exit.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(499, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 32);
            this.label1.TabIndex = 108;
            this.label1.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // dgv_Product
            // 
            this.dgv_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product.Location = new System.Drawing.Point(12, 124);
            this.dgv_Product.Name = "dgv_Product";
            this.dgv_Product.RowHeadersWidth = 51;
            this.dgv_Product.RowTemplate.Height = 24;
            this.dgv_Product.Size = new System.Drawing.Size(1363, 468);
            this.dgv_Product.TabIndex = 109;
            // 
            // btn_pdf
            // 
            this.btn_pdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(44)))));
            this.btn_pdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pdf.FlatAppearance.BorderSize = 0;
            this.btn_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pdf.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pdf.ForeColor = System.Drawing.Color.White;
            this.btn_pdf.Location = new System.Drawing.Point(583, 622);
            this.btn_pdf.Name = "btn_pdf";
            this.btn_pdf.Size = new System.Drawing.Size(202, 47);
            this.btn_pdf.TabIndex = 110;
            this.btn_pdf.Text = "Xuất file PDF";
            this.btn_pdf.UseVisualStyleBackColor = false;
            // 
            // FrmProductReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 700);
            this.Controls.Add(this.btn_pdf);
            this.Controls.Add(this.dgv_Product);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProductReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProduct";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public Guna.UI2.WinForms.Guna2ControlBox btn_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Product;
        public System.Windows.Forms.Button btn_pdf;
    }
}