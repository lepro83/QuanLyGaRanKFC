﻿namespace QuanLyGaRanKFC.View
{
    partial class fQuanLyGaRanKFC
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbCapBac = new System.Windows.Forms.Label();
            this.lbDisplayName = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnKho = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnChiNhanh = new System.Windows.Forms.Button();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.pnLogo = new System.Windows.Forms.Panel();
            this.pnChildForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnThongKe);
            this.panel1.Controls.Add(this.btnKho);
            this.panel1.Controls.Add(this.btnHoaDon);
            this.panel1.Controls.Add(this.btnKhachHang);
            this.panel1.Controls.Add(this.btnNhanVien);
            this.panel1.Controls.Add(this.btnChiNhanh);
            this.panel1.Controls.Add(this.btnTrangChu);
            this.panel1.Controls.Add(this.pnLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 1404);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbCapBac);
            this.panel2.Controls.Add(this.lbDisplayName);
            this.panel2.Controls.Add(this.btnDangXuat);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 1171);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 233);
            this.panel2.TabIndex = 9;
            // 
            // lbCapBac
            // 
            this.lbCapBac.AutoSize = true;
            this.lbCapBac.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbCapBac.Location = new System.Drawing.Point(189, 96);
            this.lbCapBac.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbCapBac.Name = "lbCapBac";
            this.lbCapBac.Size = new System.Drawing.Size(78, 32);
            this.lbCapBac.TabIndex = 3;
            this.lbCapBac.Text = "label2";
            // 
            // lbDisplayName
            // 
            this.lbDisplayName.AutoSize = true;
            this.lbDisplayName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbDisplayName.Location = new System.Drawing.Point(189, 34);
            this.lbDisplayName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbDisplayName.Name = "lbDisplayName";
            this.lbDisplayName.Size = new System.Drawing.Size(78, 32);
            this.lbDisplayName.TabIndex = 2;
            this.lbDisplayName.Text = "label1";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.DimGray;
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 148);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(464, 85);
            this.btnDangXuat.TabIndex = 1;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::QuanLyGaRanKFC.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(50, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnThongKe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnThongKe.Location = new System.Drawing.Point(0, 702);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(464, 85);
            this.btnThongKe.TabIndex = 8;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // btnKho
            // 
            this.btnKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKho.FlatAppearance.BorderSize = 0;
            this.btnKho.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnKho.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKho.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnKho.Location = new System.Drawing.Point(0, 617);
            this.btnKho.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnKho.Name = "btnKho";
            this.btnKho.Size = new System.Drawing.Size(464, 85);
            this.btnKho.TabIndex = 7;
            this.btnKho.Text = "Kho";
            this.btnKho.UseVisualStyleBackColor = true;
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoaDon.FlatAppearance.BorderSize = 0;
            this.btnHoaDon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnHoaDon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHoaDon.Location = new System.Drawing.Point(0, 532);
            this.btnHoaDon.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(464, 85);
            this.btnHoaDon.TabIndex = 6;
            this.btnHoaDon.Text = "Hóa Đơn";
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnKhachHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnKhachHang.Location = new System.Drawing.Point(0, 447);
            this.btnKhachHang.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(464, 85);
            this.btnKhachHang.TabIndex = 5;
            this.btnKhachHang.Text = "Khách Hàng";
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnNhanVien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 362);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(464, 85);
            this.btnNhanVien.TabIndex = 4;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnChiNhanh
            // 
            this.btnChiNhanh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChiNhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChiNhanh.FlatAppearance.BorderSize = 0;
            this.btnChiNhanh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnChiNhanh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnChiNhanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiNhanh.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnChiNhanh.Location = new System.Drawing.Point(0, 277);
            this.btnChiNhanh.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnChiNhanh.Name = "btnChiNhanh";
            this.btnChiNhanh.Size = new System.Drawing.Size(464, 85);
            this.btnChiNhanh.TabIndex = 3;
            this.btnChiNhanh.Text = "Chi Nhánh";
            this.btnChiNhanh.UseVisualStyleBackColor = true;
            this.btnChiNhanh.Click += new System.EventHandler(this.btnChiNhanh_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrangChu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrangChu.FlatAppearance.BorderSize = 0;
            this.btnTrangChu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnTrangChu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTrangChu.Location = new System.Drawing.Point(0, 192);
            this.btnTrangChu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(464, 85);
            this.btnTrangChu.TabIndex = 2;
            this.btnTrangChu.Text = "Trang Chủ";
            this.btnTrangChu.UseVisualStyleBackColor = true;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // pnLogo
            // 
            this.pnLogo.BackgroundImage = global::QuanLyGaRanKFC.Properties.Resources.kfc_PNG53;
            this.pnLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLogo.Location = new System.Drawing.Point(0, 0);
            this.pnLogo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(464, 192);
            this.pnLogo.TabIndex = 1;
            // 
            // pnChildForm
            // 
            this.pnChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(37)))), ((int)(((byte)(54)))));
            this.pnChildForm.BackgroundImage = global::QuanLyGaRanKFC.Properties.Resources.kfc_head2;
            this.pnChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnChildForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnChildForm.Location = new System.Drawing.Point(464, 0);
            this.pnChildForm.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnChildForm.Name = "pnChildForm";
            this.pnChildForm.Size = new System.Drawing.Size(1523, 1404);
            this.pnChildForm.TabIndex = 1;
            // 
            // fQuanLyGaRanKFC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1987, 1404);
            this.Controls.Add(this.pnChildForm);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "fQuanLyGaRanKFC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyGaRanKFC";
            this.Load += new System.EventHandler(this.QuanLyGaRanKFC_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnThongKe;
        private Button btnKho;
        private Button btnHoaDon;
        private Button btnKhachHang;
        private Button btnNhanVien;
        private Button btnChiNhanh;
        private Button btnTrangChu;
        private Panel pnLogo;
        private Label lbDisplayName;
        private Button btnDangXuat;
        private PictureBox pictureBox1;
        private Label lbCapBac;
        private Panel pnChildForm;
    }
}