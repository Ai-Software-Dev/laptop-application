
namespace GUI.Order
{
    partial class FrmOrders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpBox_TK = new System.Windows.Forms.GroupBox();
            this.txt_HinhThuc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_SearchOrders = new System.Windows.Forms.TextBox();
            this.txt_MaDH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_Orders = new System.Windows.Forms.DataGridView();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TrangThai = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_NgayMua = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Details = new System.Windows.Forms.DataGridViewImageColumn();
            this.grpBox_TK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Orders)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBox_TK
            // 
            this.grpBox_TK.Controls.Add(this.txt_NgayMua);
            this.grpBox_TK.Controls.Add(this.label10);
            this.grpBox_TK.Controls.Add(this.txt_TrangThai);
            this.grpBox_TK.Controls.Add(this.label9);
            this.grpBox_TK.Controls.Add(this.txt_TongTien);
            this.grpBox_TK.Controls.Add(this.label6);
            this.grpBox_TK.Controls.Add(this.txt_HinhThuc);
            this.grpBox_TK.Controls.Add(this.label5);
            this.grpBox_TK.Controls.Add(this.label8);
            this.grpBox_TK.Controls.Add(this.txt_SearchOrders);
            this.grpBox_TK.Controls.Add(this.txt_MaDH);
            this.grpBox_TK.Controls.Add(this.label1);
            this.grpBox_TK.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_TK.Location = new System.Drawing.Point(11, 12);
            this.grpBox_TK.Name = "grpBox_TK";
            this.grpBox_TK.Size = new System.Drawing.Size(1233, 270);
            this.grpBox_TK.TabIndex = 11;
            this.grpBox_TK.TabStop = false;
            this.grpBox_TK.Text = "Quản lý đơn hàng";
            // 
            // txt_HinhThuc
            // 
            this.txt_HinhThuc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_HinhThuc.Location = new System.Drawing.Point(23, 128);
            this.txt_HinhThuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_HinhThuc.Name = "txt_HinhThuc";
            this.txt_HinhThuc.ReadOnly = true;
            this.txt_HinhThuc.Size = new System.Drawing.Size(335, 29);
            this.txt_HinhThuc.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 23);
            this.label5.TabIndex = 37;
            this.label5.Text = "Hình Thức Thanh Toán";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tìm Kiếm";
            // 
            // txt_SearchOrders
            // 
            this.txt_SearchOrders.Location = new System.Drawing.Point(23, 212);
            this.txt_SearchOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SearchOrders.Name = "txt_SearchOrders";
            this.txt_SearchOrders.Size = new System.Drawing.Size(335, 29);
            this.txt_SearchOrders.TabIndex = 11;
            // 
            // txt_MaDH
            // 
            this.txt_MaDH.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_MaDH.Location = new System.Drawing.Point(23, 50);
            this.txt_MaDH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaDH.Name = "txt_MaDH";
            this.txt_MaDH.ReadOnly = true;
            this.txt_MaDH.Size = new System.Drawing.Size(124, 29);
            this.txt_MaDH.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Mã Đơn Hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Danh sách đơn hàng";
            // 
            // dgv_Orders
            // 
            this.dgv_Orders.AllowUserToAddRows = false;
            this.dgv_Orders.AllowUserToResizeColumns = false;
            this.dgv_Orders.AllowUserToResizeRows = false;
            this.dgv_Orders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Orders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Orders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Orders.ColumnHeadersHeight = 30;
            this.dgv_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column8,
            this.Column7,
            this.Column3,
            this.Column4,
            this.Edit,
            this.Details});
            this.dgv_Orders.EnableHeadersVisualStyles = false;
            this.dgv_Orders.Location = new System.Drawing.Point(7, 310);
            this.dgv_Orders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Orders.Name = "dgv_Orders";
            this.dgv_Orders.ReadOnly = true;
            this.dgv_Orders.RowHeadersWidth = 51;
            this.dgv_Orders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Orders.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Orders.RowTemplate.Height = 60;
            this.dgv_Orders.Size = new System.Drawing.Size(1233, 428);
            this.dgv_Orders.TabIndex = 13;
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_TongTien.Location = new System.Drawing.Point(395, 128);
            this.txt_TongTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.ReadOnly = true;
            this.txt_TongTien.Size = new System.Drawing.Size(376, 29);
            this.txt_TongTien.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(391, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 23);
            this.label6.TabIndex = 39;
            this.label6.Text = "Tổng Tiền";
            // 
            // txt_TrangThai
            // 
            this.txt_TrangThai.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_TrangThai.Location = new System.Drawing.Point(189, 50);
            this.txt_TrangThai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TrangThai.Name = "txt_TrangThai";
            this.txt_TrangThai.ReadOnly = true;
            this.txt_TrangThai.Size = new System.Drawing.Size(169, 29);
            this.txt_TrangThai.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(185, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 23);
            this.label9.TabIndex = 41;
            this.label9.Text = "Trạng Thái";
            // 
            // txt_NgayMua
            // 
            this.txt_NgayMua.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_NgayMua.Location = new System.Drawing.Point(395, 41);
            this.txt_NgayMua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NgayMua.Name = "txt_NgayMua";
            this.txt_NgayMua.ReadOnly = true;
            this.txt_NgayMua.Size = new System.Drawing.Size(376, 29);
            this.txt_NgayMua.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(391, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 23);
            this.label10.TabIndex = 43;
            this.label10.Text = "Ngày Mua";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::GUI.Properties.Resources.update;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 60;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::GUI.Properties.Resources.details;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 60;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Đơn Hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 130;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Ngày Mua";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 300;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "Hình Thức Thanh Toán";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Tổng Tiền";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Trạng Thái";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Image = global::GUI.Properties.Resources.update;
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Width = 60;
            // 
            // Details
            // 
            this.Details.HeaderText = "";
            this.Details.Image = global::GUI.Properties.Resources.eye;
            this.Details.MinimumWidth = 6;
            this.Details.Name = "Details";
            this.Details.ReadOnly = true;
            this.Details.Width = 60;
            // 
            // FrmOrders
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1256, 748);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgv_Orders);
            this.Controls.Add(this.grpBox_TK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOrders";
            this.Text = "FrmOrders";
            this.grpBox_TK.ResumeLayout(false);
            this.grpBox_TK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Orders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox grpBox_TK;
        public System.Windows.Forms.TextBox txt_HinhThuc;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txt_SearchOrders;
        public System.Windows.Forms.TextBox txt_MaDH;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.DataGridView dgv_Orders;
        public System.Windows.Forms.TextBox txt_TrangThai;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txt_TongTien;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txt_NgayMua;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Details;
    }
}