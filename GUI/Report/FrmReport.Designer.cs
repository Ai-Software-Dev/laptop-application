namespace GUI.Report
{
    partial class FrmReport
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
            this.btn_CateRe = new System.Windows.Forms.Button();
            this.btn_ProRe = new System.Windows.Forms.Button();
            this.btn_Revenue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CateRe
            // 
            this.btn_CateRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_CateRe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CateRe.FlatAppearance.BorderSize = 0;
            this.btn_CateRe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CateRe.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CateRe.ForeColor = System.Drawing.Color.Black;
            this.btn_CateRe.Location = new System.Drawing.Point(263, 394);
            this.btn_CateRe.Name = "btn_CateRe";
            this.btn_CateRe.Size = new System.Drawing.Size(173, 37);
            this.btn_CateRe.TabIndex = 87;
            this.btn_CateRe.Text = "Loại sản phẩm";
            this.btn_CateRe.UseVisualStyleBackColor = false;
            // 
            // btn_ProRe
            // 
            this.btn_ProRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_ProRe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ProRe.FlatAppearance.BorderSize = 0;
            this.btn_ProRe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ProRe.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ProRe.ForeColor = System.Drawing.Color.Black;
            this.btn_ProRe.Location = new System.Drawing.Point(476, 394);
            this.btn_ProRe.Name = "btn_ProRe";
            this.btn_ProRe.Size = new System.Drawing.Size(173, 37);
            this.btn_ProRe.TabIndex = 88;
            this.btn_ProRe.Text = "Sản phẩm";
            this.btn_ProRe.UseVisualStyleBackColor = false;
            this.btn_ProRe.Click += new System.EventHandler(this.btn_ProRe_Click);
            // 
            // btn_Revenue
            // 
            this.btn_Revenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Revenue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Revenue.FlatAppearance.BorderSize = 0;
            this.btn_Revenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Revenue.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Revenue.ForeColor = System.Drawing.Color.Black;
            this.btn_Revenue.Location = new System.Drawing.Point(693, 394);
            this.btn_Revenue.Name = "btn_Revenue";
            this.btn_Revenue.Size = new System.Drawing.Size(293, 37);
            this.btn_Revenue.TabIndex = 89;
            this.btn_Revenue.Text = "Báo cáo doanh thu";
            this.btn_Revenue.UseVisualStyleBackColor = false;
            this.btn_Revenue.Click += new System.EventHandler(this.btn_Revenue_Click);
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 775);
            this.Controls.Add(this.btn_Revenue);
            this.Controls.Add(this.btn_ProRe);
            this.Controls.Add(this.btn_CateRe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReport";
            this.Text = "FrmReport";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btn_CateRe;
        public System.Windows.Forms.Button btn_ProRe;
        public System.Windows.Forms.Button btn_Revenue;
    }
}