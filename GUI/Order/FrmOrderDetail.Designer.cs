
namespace GUI.Order
{
    partial class FrmOrderDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_exit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Button();
            this.pnCTHD = new System.Windows.Forms.Panel();
            this.dgv_OrderDetail = new System.Windows.Forms.DataGridView();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblPhiVanChuyen = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.lblHinhThuc = new System.Windows.Forms.Label();
            this.lblNgayMua = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblHT = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.pnCTHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.btn_exit.IconColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(829, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(45, 29);
            this.btn_exit.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 27);
            this.panel1.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 29);
            this.label1.TabIndex = 103;
            this.label1.Text = "Chi Tiết Hóa Đơn";
            // 
            // btn_print
            // 
            this.btn_print.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Location = new System.Drawing.Point(622, 807);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(240, 42);
            this.btn_print.TabIndex = 125;
            this.btn_print.Text = "IN HÓA ĐƠN";
            this.btn_print.UseVisualStyleBackColor = true;
            // 
            // pnCTHD
            // 
            this.pnCTHD.Controls.Add(this.dgv_OrderDetail);
            this.pnCTHD.Controls.Add(this.lblThanhTien);
            this.pnCTHD.Controls.Add(this.label1);
            this.pnCTHD.Controls.Add(this.label11);
            this.pnCTHD.Controls.Add(this.lblPhiVanChuyen);
            this.pnCTHD.Controls.Add(this.label15);
            this.pnCTHD.Controls.Add(this.lblTongTien);
            this.pnCTHD.Controls.Add(this.label17);
            this.pnCTHD.Controls.Add(this.lblMaHD);
            this.pnCTHD.Controls.Add(this.lblHinhThuc);
            this.pnCTHD.Controls.Add(this.lblNgayMua);
            this.pnCTHD.Controls.Add(this.lblDiaChi);
            this.pnCTHD.Controls.Add(this.lblSDT);
            this.pnCTHD.Controls.Add(this.lblHT);
            this.pnCTHD.Controls.Add(this.label24);
            this.pnCTHD.Controls.Add(this.label25);
            this.pnCTHD.Controls.Add(this.label26);
            this.pnCTHD.Controls.Add(this.label27);
            this.pnCTHD.Controls.Add(this.label28);
            this.pnCTHD.Controls.Add(this.label29);
            this.pnCTHD.Controls.Add(this.label30);
            this.pnCTHD.Controls.Add(this.label31);
            this.pnCTHD.Location = new System.Drawing.Point(0, 31);
            this.pnCTHD.Name = "pnCTHD";
            this.pnCTHD.Size = new System.Drawing.Size(874, 770);
            this.pnCTHD.TabIndex = 127;
            // 
            // dgv_OrderDetail
            // 
            this.dgv_OrderDetail.AllowUserToAddRows = false;
            this.dgv_OrderDetail.AllowUserToResizeColumns = false;
            this.dgv_OrderDetail.AllowUserToResizeRows = false;
            this.dgv_OrderDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_OrderDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_OrderDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_OrderDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_OrderDetail.ColumnHeadersHeight = 25;
            this.dgv_OrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_OrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgv_OrderDetail.EnableHeadersVisualStyles = false;
            this.dgv_OrderDetail.Location = new System.Drawing.Point(23, 342);
            this.dgv_OrderDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_OrderDetail.Name = "dgv_OrderDetail";
            this.dgv_OrderDetail.ReadOnly = true;
            this.dgv_OrderDetail.RowHeadersVisible = false;
            this.dgv_OrderDetail.RowHeadersWidth = 30;
            this.dgv_OrderDetail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_OrderDetail.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_OrderDetail.RowTemplate.Height = 60;
            this.dgv_OrderDetail.Size = new System.Drawing.Size(833, 306);
            this.dgv_OrderDetail.TabIndex = 148;
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhTien.Location = new System.Drawing.Point(665, 734);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(109, 23);
            this.lblThanhTien.TabIndex = 146;
            this.lblThanhTien.Text = "Họ và tên:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(519, 734);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 23);
            this.label11.TabIndex = 145;
            this.label11.Text = "Thành tiền:";
            // 
            // lblPhiVanChuyen
            // 
            this.lblPhiVanChuyen.AutoSize = true;
            this.lblPhiVanChuyen.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhiVanChuyen.Location = new System.Drawing.Point(665, 696);
            this.lblPhiVanChuyen.Name = "lblPhiVanChuyen";
            this.lblPhiVanChuyen.Size = new System.Drawing.Size(109, 23);
            this.lblPhiVanChuyen.TabIndex = 144;
            this.lblPhiVanChuyen.Text = "Họ và tên:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(519, 696);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(145, 23);
            this.label15.TabIndex = 143;
            this.label15.Text = "Phí vận chuyển:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(665, 659);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(109, 23);
            this.lblTongTien.TabIndex = 142;
            this.lblTongTien.Text = "Họ và tên:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(519, 659);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 23);
            this.label17.TabIndex = 141;
            this.label17.Text = "Tổng tiền:";
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHD.Location = new System.Drawing.Point(151, 57);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(98, 23);
            this.lblMaHD.TabIndex = 140;
            this.lblMaHD.Text = "Họ và tên:";
            // 
            // lblHinhThuc
            // 
            this.lblHinhThuc.AutoSize = true;
            this.lblHinhThuc.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHinhThuc.Location = new System.Drawing.Point(151, 310);
            this.lblHinhThuc.Name = "lblHinhThuc";
            this.lblHinhThuc.Size = new System.Drawing.Size(98, 23);
            this.lblHinhThuc.TabIndex = 139;
            this.lblHinhThuc.Text = "Họ và tên:";
            // 
            // lblNgayMua
            // 
            this.lblNgayMua.AutoSize = true;
            this.lblNgayMua.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayMua.Location = new System.Drawing.Point(151, 264);
            this.lblNgayMua.Name = "lblNgayMua";
            this.lblNgayMua.Size = new System.Drawing.Size(98, 23);
            this.lblNgayMua.TabIndex = 138;
            this.lblNgayMua.Text = "Họ và tên:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(151, 219);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(98, 23);
            this.lblDiaChi.TabIndex = 137;
            this.lblDiaChi.Text = "Họ và tên:";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(151, 177);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(98, 23);
            this.lblSDT.TabIndex = 136;
            this.lblSDT.Text = "Họ và tên:";
            // 
            // lblHT
            // 
            this.lblHT.AutoSize = true;
            this.lblHT.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHT.Location = new System.Drawing.Point(151, 133);
            this.lblHT.Name = "lblHT";
            this.lblHT.Size = new System.Drawing.Size(98, 23);
            this.lblHT.TabIndex = 135;
            this.lblHT.Text = "Họ và tên:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(19, 310);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(93, 23);
            this.label24.TabIndex = 134;
            this.label24.Text = "Hình thức";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(19, 264);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(103, 23);
            this.label25.TabIndex = 133;
            this.label25.Text = "Ngày mua:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(19, 219);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(74, 23);
            this.label26.TabIndex = 132;
            this.label26.Text = "Địa chỉ:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(19, 177);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(52, 23);
            this.label27.TabIndex = 131;
            this.label27.Text = "SĐT:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(19, 133);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(98, 23);
            this.label28.TabIndex = 130;
            this.label28.Text = "Họ và tên:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(19, 92);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(230, 24);
            this.label29.TabIndex = 129;
            this.label29.Text = "Thông tin khách hàng";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(19, 57);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(117, 23);
            this.label30.TabIndex = 128;
            this.label30.Text = "Mã hóa đơn:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(346, -25);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(214, 29);
            this.label31.TabIndex = 127;
            this.label31.Text = "Chi Tiết Hóa Đơn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Sản Phẩm";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Số Lượng";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Giá Bán";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 130;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Thành Tiền";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 130;
            // 
            // FrmOrderDetail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(874, 861);
            this.Controls.Add(this.pnCTHD);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOrderDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOrderDetail";
            this.panel1.ResumeLayout(false);
            this.pnCTHD.ResumeLayout(false);
            this.pnCTHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2ControlBox btn_exit;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_print;
        public System.Windows.Forms.DataGridView dgv_OrderDetail;
        public System.Windows.Forms.Label lblThanhTien;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label lblPhiVanChuyen;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label lblTongTien;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.Label lblMaHD;
        public System.Windows.Forms.Label lblHinhThuc;
        public System.Windows.Forms.Label lblNgayMua;
        public System.Windows.Forms.Label lblDiaChi;
        public System.Windows.Forms.Label lblSDT;
        public System.Windows.Forms.Label lblHT;
        public System.Windows.Forms.Label label24;
        public System.Windows.Forms.Label label25;
        public System.Windows.Forms.Label label26;
        public System.Windows.Forms.Label label27;
        public System.Windows.Forms.Label label28;
        public System.Windows.Forms.Label label29;
        public System.Windows.Forms.Label label30;
        public System.Windows.Forms.Label label31;
        public System.Windows.Forms.Panel pnCTHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}