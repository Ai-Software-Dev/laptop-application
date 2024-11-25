
namespace GUI.Customer
{
    partial class FrmCustomers
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
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_Customers = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_SearchCustomer = new System.Windows.Forms.TextBox();
            this.txt_NameUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_IDUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBox_TK = new System.Windows.Forms.GroupBox();
            this.txt_NameLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customers)).BeginInit();
            this.grpBox_TK.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Danh sách khách hàng";
            // 
            // dgv_Customers
            // 
            this.dgv_Customers.AllowUserToAddRows = false;
            this.dgv_Customers.AllowUserToResizeColumns = false;
            this.dgv_Customers.AllowUserToResizeRows = false;
            this.dgv_Customers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Customers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Customers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Customers.ColumnHeadersHeight = 30;
            this.dgv_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Customers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Edit});
            this.dgv_Customers.EnableHeadersVisualStyles = false;
            this.dgv_Customers.Location = new System.Drawing.Point(12, 309);
            this.dgv_Customers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Customers.Name = "dgv_Customers";
            this.dgv_Customers.ReadOnly = true;
            this.dgv_Customers.RowHeadersWidth = 51;
            this.dgv_Customers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Customers.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Customers.RowTemplate.Height = 60;
            this.dgv_Customers.Size = new System.Drawing.Size(1233, 428);
            this.dgv_Customers.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tìm Kiếm";
            // 
            // txt_SearchCustomer
            // 
            this.txt_SearchCustomer.Location = new System.Drawing.Point(23, 119);
            this.txt_SearchCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SearchCustomer.Name = "txt_SearchCustomer";
            this.txt_SearchCustomer.Size = new System.Drawing.Size(335, 29);
            this.txt_SearchCustomer.TabIndex = 11;
            // 
            // txt_NameUser
            // 
            this.txt_NameUser.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_NameUser.Location = new System.Drawing.Point(189, 50);
            this.txt_NameUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NameUser.Name = "txt_NameUser";
            this.txt_NameUser.ReadOnly = true;
            this.txt_NameUser.Size = new System.Drawing.Size(169, 29);
            this.txt_NameUser.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // txt_IDUser
            // 
            this.txt_IDUser.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_IDUser.Location = new System.Drawing.Point(23, 50);
            this.txt_IDUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_IDUser.Name = "txt_IDUser";
            this.txt_IDUser.ReadOnly = true;
            this.txt_IDUser.Size = new System.Drawing.Size(124, 29);
            this.txt_IDUser.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Mã Khách Hàng";
            // 
            // grpBox_TK
            // 
            this.grpBox_TK.Controls.Add(this.txt_Email);
            this.grpBox_TK.Controls.Add(this.label5);
            this.grpBox_TK.Controls.Add(this.txt_Pass);
            this.grpBox_TK.Controls.Add(this.label4);
            this.grpBox_TK.Controls.Add(this.txt_NameLogin);
            this.grpBox_TK.Controls.Add(this.label3);
            this.grpBox_TK.Controls.Add(this.label8);
            this.grpBox_TK.Controls.Add(this.txt_SearchCustomer);
            this.grpBox_TK.Controls.Add(this.txt_NameUser);
            this.grpBox_TK.Controls.Add(this.label2);
            this.grpBox_TK.Controls.Add(this.txt_IDUser);
            this.grpBox_TK.Controls.Add(this.label1);
            this.grpBox_TK.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_TK.Location = new System.Drawing.Point(12, 11);
            this.grpBox_TK.Name = "grpBox_TK";
            this.grpBox_TK.Size = new System.Drawing.Size(1233, 270);
            this.grpBox_TK.TabIndex = 10;
            this.grpBox_TK.TabStop = false;
            this.grpBox_TK.Text = "Quản lý khách hàng";
            // 
            // txt_NameLogin
            // 
            this.txt_NameLogin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_NameLogin.Location = new System.Drawing.Point(395, 50);
            this.txt_NameLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NameLogin.Name = "txt_NameLogin";
            this.txt_NameLogin.ReadOnly = true;
            this.txt_NameLogin.Size = new System.Drawing.Size(169, 29);
            this.txt_NameLogin.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(391, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "Tên Tài Khoản";
            // 
            // txt_Pass
            // 
            this.txt_Pass.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_Pass.Location = new System.Drawing.Point(602, 50);
            this.txt_Pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.ReadOnly = true;
            this.txt_Pass.Size = new System.Drawing.Size(169, 29);
            this.txt_Pass.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(598, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "Mật Khẩu";
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_Email.Location = new System.Drawing.Point(813, 50);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.ReadOnly = true;
            this.txt_Email.Size = new System.Drawing.Size(169, 29);
            this.txt_Email.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(809, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 23);
            this.label5.TabIndex = 37;
            this.label5.Text = "Email";
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
            this.dataGridViewImageColumn2.Image = global::GUI.Properties.Resources.delete;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 60;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Khách Hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Khách Hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 557;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tên Tài Khoản";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Mật Khẩu";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "Email";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
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
            // FrmCustomers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1256, 748);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgv_Customers);
            this.Controls.Add(this.grpBox_TK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCustomers";
            this.Text = "FrmCustomers";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customers)).EndInit();
            this.grpBox_TK.ResumeLayout(false);
            this.grpBox_TK.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        public System.Windows.Forms.DataGridView dgv_Customers;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txt_SearchCustomer;
        public System.Windows.Forms.TextBox txt_NameUser;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_IDUser;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox grpBox_TK;
        public System.Windows.Forms.TextBox txt_Email;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_Pass;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_NameLogin;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
    }
}