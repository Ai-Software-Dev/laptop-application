namespace GUI.Prediction
{
    partial class frmPredictionAddProduct
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
            this.dgv_dataTrain = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_predict = new System.Windows.Forms.Button();
            this.lbl_predict = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtQuantitySold = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtStockLevel = new System.Windows.Forms.TextBox();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dataTrain)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_dataTrain
            // 
            this.dgv_dataTrain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dataTrain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dataTrain.Location = new System.Drawing.Point(141, 294);
            this.dgv_dataTrain.Name = "dgv_dataTrain";
            this.dgv_dataTrain.RowHeadersWidth = 51;
            this.dgv_dataTrain.RowTemplate.Height = 24;
            this.dgv_dataTrain.Size = new System.Drawing.Size(1174, 398);
            this.dgv_dataTrain.TabIndex = 0;
            // 
            // btn_predict
            // 
            this.btn_predict.Location = new System.Drawing.Point(141, 148);
            this.btn_predict.Name = "btn_predict";
            this.btn_predict.Size = new System.Drawing.Size(373, 44);
            this.btn_predict.TabIndex = 1;
            this.btn_predict.Text = "Dự báo thêm sản phẩm mới";
            this.btn_predict.UseVisualStyleBackColor = true;
            // 
            // lbl_predict
            // 
            this.lbl_predict.AutoSize = true;
            this.lbl_predict.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_predict.Location = new System.Drawing.Point(530, 167);
            this.lbl_predict.Name = "lbl_predict";
            this.lbl_predict.Size = new System.Drawing.Size(27, 25);
            this.lbl_predict.TabIndex = 2;
            this.lbl_predict.Text = "...";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(271, 31);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(1044, 27);
            this.txtProductName.TabIndex = 3;
            // 
            // txtQuantitySold
            // 
            this.txtQuantitySold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantitySold.Location = new System.Drawing.Point(644, 94);
            this.txtQuantitySold.Name = "txtQuantitySold";
            this.txtQuantitySold.Size = new System.Drawing.Size(243, 27);
            this.txtQuantitySold.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(1072, 94);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(243, 27);
            this.txtPrice.TabIndex = 6;
            // 
            // txtStockLevel
            // 
            this.txtStockLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockLevel.Location = new System.Drawing.Point(1072, 148);
            this.txtStockLevel.Name = "txtStockLevel";
            this.txtStockLevel.Size = new System.Drawing.Size(243, 27);
            this.txtStockLevel.TabIndex = 7;
            // 
            // txtProductId
            // 
            this.txtProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductId.Location = new System.Drawing.Point(271, 94);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(243, 27);
            this.txtProductId.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(641, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Số lượng đã bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1069, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Giá bán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1069, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Số lượng tồn";
            // 
            // frmPredictionAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 704);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.txtStockLevel);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQuantitySold);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lbl_predict);
            this.Controls.Add(this.btn_predict);
            this.Controls.Add(this.dgv_dataTrain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPredictionAddProduct";
            this.Text = "frmPredictionAddProduct";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dataTrain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_dataTrain;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_predict;
        private System.Windows.Forms.Label lbl_predict;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtQuantitySold;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtStockLevel;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}