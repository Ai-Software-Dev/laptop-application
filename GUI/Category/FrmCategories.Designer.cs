
namespace GUI.Category
{
    partial class FrmCategories
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
            this.label8 = new System.Windows.Forms.Label();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.txt_SearchCategories = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_NameCategories = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_IDCategories = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Categories = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.grpBox_TK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Categories)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBox_TK
            // 
            this.grpBox_TK.Controls.Add(this.label8);
            this.grpBox_TK.Controls.Add(this.pic_Logo);
            this.grpBox_TK.Controls.Add(this.txt_SearchCategories);
            this.grpBox_TK.Controls.Add(this.btn_Add);
            this.grpBox_TK.Controls.Add(this.txt_NameCategories);
            this.grpBox_TK.Controls.Add(this.label2);
            this.grpBox_TK.Controls.Add(this.txt_IDCategories);
            this.grpBox_TK.Controls.Add(this.label1);
            this.grpBox_TK.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_TK.Location = new System.Drawing.Point(12, 12);
            this.grpBox_TK.Name = "grpBox_TK";
            this.grpBox_TK.Size = new System.Drawing.Size(1233, 270);
            this.grpBox_TK.TabIndex = 6;
            this.grpBox_TK.TabStop = false;
            this.grpBox_TK.Text = "Quản lý danh mục";
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
            // pic_Logo
            // 
            this.pic_Logo.Location = new System.Drawing.Point(899, 25);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(328, 230);
            this.pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Logo.TabIndex = 33;
            this.pic_Logo.TabStop = false;
            // 
            // txt_SearchCategories
            // 
            this.txt_SearchCategories.Location = new System.Drawing.Point(23, 119);
            this.txt_SearchCategories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SearchCategories.Name = "txt_SearchCategories";
            this.txt_SearchCategories.Size = new System.Drawing.Size(335, 29);
            this.txt_SearchCategories.TabIndex = 11;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Image = global::GUI.Properties.Resources.add;
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.Location = new System.Drawing.Point(23, 225);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(123, 30);
            this.btn_Add.TabIndex = 27;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Add.UseVisualStyleBackColor = false;
            // 
            // txt_NameCategories
            // 
            this.txt_NameCategories.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_NameCategories.Location = new System.Drawing.Point(189, 50);
            this.txt_NameCategories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NameCategories.Name = "txt_NameCategories";
            this.txt_NameCategories.ReadOnly = true;
            this.txt_NameCategories.Size = new System.Drawing.Size(169, 29);
            this.txt_NameCategories.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tên Danh Mục";
            // 
            // txt_IDCategories
            // 
            this.txt_IDCategories.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_IDCategories.Location = new System.Drawing.Point(23, 50);
            this.txt_IDCategories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_IDCategories.Name = "txt_IDCategories";
            this.txt_IDCategories.ReadOnly = true;
            this.txt_IDCategories.Size = new System.Drawing.Size(124, 29);
            this.txt_IDCategories.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Mã Danh Mục";
            // 
            // dgv_Categories
            // 
            this.dgv_Categories.AllowUserToAddRows = false;
            this.dgv_Categories.AllowUserToResizeColumns = false;
            this.dgv_Categories.AllowUserToResizeRows = false;
            this.dgv_Categories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Categories.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Categories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Categories.ColumnHeadersHeight = 30;
            this.dgv_Categories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Categories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Edit,
            this.Delete});
            this.dgv_Categories.EnableHeadersVisualStyles = false;
            this.dgv_Categories.Location = new System.Drawing.Point(12, 310);
            this.dgv_Categories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Categories.Name = "dgv_Categories";
            this.dgv_Categories.ReadOnly = true;
            this.dgv_Categories.RowHeadersWidth = 51;
            this.dgv_Categories.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Categories.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Categories.RowTemplate.Height = 60;
            this.dgv_Categories.Size = new System.Drawing.Size(1233, 428);
            this.dgv_Categories.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Danh sách danh mục";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::GUI.Properties.Resources.update;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 60;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::GUI.Properties.Resources.delete;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 60;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Danh Mục";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Tên Danh Mục";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Hình Ảnh";
            this.Column3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "URL";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
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
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Image = global::GUI.Properties.Resources.delete;
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 60;
            // 
            // FrmCategories
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1257, 749);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgv_Categories);
            this.Controls.Add(this.grpBox_TK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCategories";
            this.Text = "FrmCategories";
            this.grpBox_TK.ResumeLayout(false);
            this.grpBox_TK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Categories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dgv_Categories;
        public System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        public System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        public System.Windows.Forms.GroupBox grpBox_TK;
        public System.Windows.Forms.Button btn_Add;
        public System.Windows.Forms.TextBox txt_NameCategories;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txt_SearchCategories;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_IDCategories;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.PictureBox pic_Logo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}