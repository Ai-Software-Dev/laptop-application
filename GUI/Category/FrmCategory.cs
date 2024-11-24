﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using BLL;
using DTO;
using System.IO;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Component;
using System.Net;
using System.Drawing;

namespace GUI.Category
{
    public partial class FrmCategory : Form
    {
        BLL_Category bllCategory = new BLL_Category();
        List<hang> hangList = new List<hang>();
        private bool isEditing = false;
        private int currentMaHang;
        private Cloundinary cloudinaryHelper = new Cloundinary();
        private string uploadedImageUrl = "";

        public FrmCategory()
        {
            InitializeComponent();
            LoadData();
            txtSearch.TextChanged += TxtSearch_TextChanged;
            this.btnAdd.Click += BtnAdd_Click;
            this.btnSave.Click += BtnSave_Click;
            this.btnDelete.Click += BtnDelete_Click;
            this.btnUpdate.Click += BtnUpdate_Click;
            btnUploadLogo.Click += BtnUploadLogo_Click;
            dgvCategory.CellClick += DgvCategory_CellClick;
        }

        private void BtnUploadLogo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        uploadedImageUrl = cloudinaryHelper.UploadImage(openFileDialog.FileName);
                        picLogo.Load(uploadedImageUrl); // Hiển thị ảnh trong PictureBox
                        MessageBox.Show("Upload thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi tải ảnh: {ex.Message}");
                    }
                }
            }
        }

        private void DgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCategory.Rows[e.RowIndex];
                string maHang = row.Cells["MaHang"].Value.ToString();
                string tenHang = row.Cells["TenHang"].Value.ToString();
                string logoUrl = row.Cells["Logo"].Value.ToString();

                txtIDCategory.Text = maHang;
                txtNameCategory.Text = tenHang;

                if (!string.IsNullOrEmpty(logoUrl))
                {
                    try
                    {
                        picLogo.Load(logoUrl);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}");
                    }
                }
                else
                {
                    picLogo.Image = null;
                }
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchKeyword = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchKeyword))
            {
                LoadData();
            }
            else
            {
                hangList = bllCategory.SearchHangs(searchKeyword);
                dgvCategory.DataSource = new BindingList<hang>(hangList);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCategory.SelectedRows.Count > 0)
            {
                var selectedRow = dgvCategory.SelectedRows[0];
                if (selectedRow != null)
                {
                    var selectedHang = selectedRow.DataBoundItem as hang;
                    if (selectedHang != null)
                    {
                        txtIDCategory.Text = selectedHang.MaHang.ToString();
                        txtNameCategory.Text = selectedHang.TenHang;

                        currentMaHang = selectedHang.MaHang;
                        isEditing = true;

                        txtIDCategory.Enabled = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCategory.SelectedRows.Count > 0)
            {
                var selectedHang = dgvCategory.SelectedRows[0].DataBoundItem as hang;
                if (selectedHang != null)
                {
                    var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa mục này không?",
                        "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirmResult == DialogResult.Yes)
                    {
                        bllCategory.DeleteHang(selectedHang.MaHang);
                        LoadData();
                    }
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNameCategory.Text))
            {
                MessageBox.Show("Tên hãng không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (isEditing)
            {
                var updatedHang = new hang
                {
                    MaHang = currentMaHang,
                    TenHang = txtNameCategory.Text,
                    Logo = uploadedImageUrl
                };

                bllCategory.UpdateHang(updatedHang);
                MessageBox.Show("Đã cập nhật hãng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var newHang = new hang
                {
                    TenHang = txtNameCategory.Text,
                    Logo = uploadedImageUrl 
                };

                bllCategory.AddHang(newHang);
                MessageBox.Show("Đã thêm hãng mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadData();
            txtIDCategory.Text = "";
            txtNameCategory.Text = "";
            isEditing = false;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            txtIDCategory.Text = "";
            txtNameCategory.Text = "";
            txtIDCategory.Enabled = false;
            isEditing = false;
        }

        public void LoadData()
        {
            hangList = bllCategory.GetHangs();
            dgvCategory.DataSource = new BindingList<hang>(hangList);
            dgvCategory.Columns["TenHang"].HeaderText = "Tên Hãng";
            dgvCategory.Columns["MaHang"].HeaderText = "Mã Hãng";
            dgvCategory.Columns["Logo"].HeaderText = "Logo";
        }

    }
}
