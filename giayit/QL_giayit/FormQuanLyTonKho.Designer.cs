namespace QL_giayit
{
    partial class FormQuanLyTonKho
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.txtTongSoLuong = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gvTonKho = new System.Windows.Forms.DataGridView();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXuatBaoCao = new System.Windows.Forms.Button();
            this.btnTKDSSP = new System.Windows.Forms.Button();
            this.ngayxem = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLoaiSanPham = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSLSP = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTKSP = new System.Windows.Forms.Button();
            this.dtpNgaySP = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTenSanPham = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTonKho)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLamLai);
            this.groupBox1.Controls.Add(this.txtTongSoLuong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.gvTonKho);
            this.groupBox1.Controls.Add(this.btnXuatBaoCao);
            this.groupBox1.Controls.Add(this.btnTKDSSP);
            this.groupBox1.Controls.Add(this.ngayxem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbLoaiSanPham);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 250);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê theo danh sách sản phẩm";
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(494, 17);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(75, 23);
            this.btnLamLai.TabIndex = 9;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // txtTongSoLuong
            // 
            this.txtTongSoLuong.AutoSize = true;
            this.txtTongSoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTongSoLuong.Location = new System.Drawing.Point(613, 226);
            this.txtTongSoLuong.Name = "txtTongSoLuong";
            this.txtTongSoLuong.Size = new System.Drawing.Size(75, 13);
            this.txtTongSoLuong.TabIndex = 8;
            this.txtTongSoLuong.Text = "Tông số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tổng số lượng tồn kho";
            // 
            // gvTonKho
            // 
            this.gvTonKho.AllowUserToAddRows = false;
            this.gvTonKho.AllowUserToDeleteRows = false;
            this.gvTonKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTonKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ngay,
            this.MaSP,
            this.TenSP,
            this.TenLoai,
            this.Gia,
            this.SL});
            this.gvTonKho.Location = new System.Drawing.Point(6, 46);
            this.gvTonKho.Name = "gvTonKho";
            this.gvTonKho.ReadOnly = true;
            this.gvTonKho.Size = new System.Drawing.Size(682, 171);
            this.gvTonKho.TabIndex = 6;
            this.gvTonKho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTonKho_CellContentClick);
            // 
            // Ngay
            // 
            this.Ngay.HeaderText = "Ngày nhập kho";
            this.Ngay.Name = "Ngay";
            this.Ngay.ReadOnly = true;
            // 
            // MaSP
            // 
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            // 
            // TenSP
            // 
            this.TenSP.HeaderText = "Tên sản phâm";
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            this.TenSP.Width = 135;
            // 
            // TenLoai
            // 
            this.TenLoai.HeaderText = "Loại sản phẩm";
            this.TenLoai.Name = "TenLoai";
            this.TenLoai.ReadOnly = true;
            this.TenLoai.Width = 150;
            // 
            // Gia
            // 
            this.Gia.HeaderText = "Giá bán (VNĐ)";
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            this.Gia.Width = 150;
            // 
            // SL
            // 
            this.SL.HeaderText = "Số lượng";
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            // 
            // btnXuatBaoCao
            // 
            this.btnXuatBaoCao.Location = new System.Drawing.Point(581, 17);
            this.btnXuatBaoCao.Name = "btnXuatBaoCao";
            this.btnXuatBaoCao.Size = new System.Drawing.Size(107, 23);
            this.btnXuatBaoCao.TabIndex = 5;
            this.btnXuatBaoCao.Text = "Xuất báo cáo";
            this.btnXuatBaoCao.UseVisualStyleBackColor = true;
            this.btnXuatBaoCao.Click += new System.EventHandler(this.btnXuatBaoCao_Click);
            // 
            // btnTKDSSP
            // 
            this.btnTKDSSP.Location = new System.Drawing.Point(413, 17);
            this.btnTKDSSP.Name = "btnTKDSSP";
            this.btnTKDSSP.Size = new System.Drawing.Size(75, 23);
            this.btnTKDSSP.TabIndex = 4;
            this.btnTKDSSP.Text = "Thống kê";
            this.btnTKDSSP.UseVisualStyleBackColor = true;
            this.btnTKDSSP.Click += new System.EventHandler(this.btnTKDSSP_Click);
            // 
            // ngayxem
            // 
            this.ngayxem.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngayxem.Location = new System.Drawing.Point(245, 20);
            this.ngayxem.Name = "ngayxem";
            this.ngayxem.Size = new System.Drawing.Size(151, 20);
            this.ngayxem.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày";
            // 
            // cbLoaiSanPham
            // 
            this.cbLoaiSanPham.FormattingEnabled = true;
            this.cbLoaiSanPham.Location = new System.Drawing.Point(39, 19);
            this.cbLoaiSanPham.Name = "cbLoaiSanPham";
            this.cbLoaiSanPham.Size = new System.Drawing.Size(133, 21);
            this.cbLoaiSanPham.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSLSP);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnTKSP);
            this.groupBox2.Controls.Add(this.dtpNgaySP);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbTenSanPham);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(701, 106);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống kê theo từng sản phẩm";
            // 
            // txtSLSP
            // 
            this.txtSLSP.AutoSize = true;
            this.txtSLSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtSLSP.Location = new System.Drawing.Point(613, 71);
            this.txtSLSP.Name = "txtSLSP";
            this.txtSLSP.Size = new System.Drawing.Size(75, 13);
            this.txtSLSP.TabIndex = 10;
            this.txtSLSP.Text = "Tông số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(470, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số lượng tồn kho";
            // 
            // btnTKSP
            // 
            this.btnTKSP.Location = new System.Drawing.Point(620, 21);
            this.btnTKSP.Name = "btnTKSP";
            this.btnTKSP.Size = new System.Drawing.Size(75, 23);
            this.btnTKSP.TabIndex = 8;
            this.btnTKSP.Text = "Thống kê";
            this.btnTKSP.UseVisualStyleBackColor = true;
            this.btnTKSP.Click += new System.EventHandler(this.btnTKSP_Click);
            // 
            // dtpNgaySP
            // 
            this.dtpNgaySP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySP.Location = new System.Drawing.Point(378, 23);
            this.dtpNgaySP.Name = "dtpNgaySP";
            this.dtpNgaySP.Size = new System.Drawing.Size(151, 20);
            this.dtpNgaySP.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày";
            // 
            // cbTenSanPham
            // 
            this.cbTenSanPham.FormattingEnabled = true;
            this.cbTenSanPham.Location = new System.Drawing.Point(91, 23);
            this.cbTenSanPham.Name = "cbTenSanPham";
            this.cbTenSanPham.Size = new System.Drawing.Size(185, 21);
            this.cbTenSanPham.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tên giày";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(638, 380);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 11;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FormQuanLyTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 408);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormQuanLyTonKho";
            this.Text = "FormQuanLyTonKho";
            this.Load += new System.EventHandler(this.FormQuanLyTonKho_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTonKho)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Label txtTongSoLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gvTonKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.Button btnXuatBaoCao;
        private System.Windows.Forms.Button btnTKDSSP;
        private System.Windows.Forms.DateTimePicker ngayxem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLoaiSanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label txtSLSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTKSP;
        private System.Windows.Forms.DateTimePicker dtpNgaySP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTenSanPham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDong;
    }
}