namespace QL_giayit
{
    partial class FormThongKe
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtTongChi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoLuongNhap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gvNhapHang = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXuatBaoCaoNhap = new System.Windows.Forms.Button();
            this.btnThongKeNhap = new System.Windows.Forms.Button();
            this.cbNamNhap = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbThangNhap = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtTongThu = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSoLuongBan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gvBanHang = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXuatBaoCaoBan = new System.Windows.Forms.Button();
            this.btnThongKeBan = new System.Windows.Forms.Button();
            this.cbNamBan = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbThangBan = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhapHang)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBanHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(141, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thống kê tình hình kinh doanh";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(651, 401);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtTongChi);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtSoLuongNhap);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.gvNhapHang);
            this.tabPage1.Controls.Add(this.btnXuatBaoCaoNhap);
            this.tabPage1.Controls.Add(this.btnThongKeNhap);
            this.tabPage1.Controls.Add(this.cbNamNhap);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cbThangNhap);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(643, 375);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nhập hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtTongChi
            // 
            this.txtTongChi.Location = new System.Drawing.Point(423, 340);
            this.txtTongChi.Name = "txtTongChi";
            this.txtTongChi.Size = new System.Drawing.Size(214, 20);
            this.txtTongChi.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Thành tiền (Tổng) :";
            // 
            // txtSoLuongNhap
            // 
            this.txtSoLuongNhap.Location = new System.Drawing.Point(101, 340);
            this.txtSoLuongNhap.Name = "txtSoLuongNhap";
            this.txtSoLuongNhap.Size = new System.Drawing.Size(134, 20);
            this.txtSoLuongNhap.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số lượng (Tổng) :";
            // 
            // gvNhapHang
            // 
            this.gvNhapHang.AllowUserToAddRows = false;
            this.gvNhapHang.AllowUserToDeleteRows = false;
            this.gvNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvNhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Thang,
            this.SLN,
            this.TongTien});
            this.gvNhapHang.Location = new System.Drawing.Point(6, 81);
            this.gvNhapHang.Name = "gvNhapHang";
            this.gvNhapHang.ReadOnly = true;
            this.gvNhapHang.Size = new System.Drawing.Size(631, 239);
            this.gvNhapHang.TabIndex = 7;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // Thang
            // 
            this.Thang.HeaderText = "Tháng";
            this.Thang.Name = "Thang";
            this.Thang.ReadOnly = true;
            // 
            // SLN
            // 
            this.SLN.HeaderText = "Số lượng nhập";
            this.SLN.Name = "SLN";
            this.SLN.ReadOnly = true;
            this.SLN.Width = 155;
            // 
            // TongTien
            // 
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            this.TongTien.Width = 230;
            // 
            // btnXuatBaoCaoNhap
            // 
            this.btnXuatBaoCaoNhap.Location = new System.Drawing.Point(540, 38);
            this.btnXuatBaoCaoNhap.Name = "btnXuatBaoCaoNhap";
            this.btnXuatBaoCaoNhap.Size = new System.Drawing.Size(97, 23);
            this.btnXuatBaoCaoNhap.TabIndex = 6;
            this.btnXuatBaoCaoNhap.Text = "Xuất báo cáo";
            this.btnXuatBaoCaoNhap.UseVisualStyleBackColor = true;
            this.btnXuatBaoCaoNhap.Click += new System.EventHandler(this.btnXuatBaoCaoNhap_Click);
            // 
            // btnThongKeNhap
            // 
            this.btnThongKeNhap.Location = new System.Drawing.Point(441, 38);
            this.btnThongKeNhap.Name = "btnThongKeNhap";
            this.btnThongKeNhap.Size = new System.Drawing.Size(75, 23);
            this.btnThongKeNhap.TabIndex = 5;
            this.btnThongKeNhap.Text = "Thống kê";
            this.btnThongKeNhap.UseVisualStyleBackColor = true;
            this.btnThongKeNhap.Click += new System.EventHandler(this.btnThongKeNhap_Click);
            // 
            // cbNamNhap
            // 
            this.cbNamNhap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNamNhap.FormattingEnabled = true;
            this.cbNamNhap.Location = new System.Drawing.Point(252, 40);
            this.cbNamNhap.Name = "cbNamNhap";
            this.cbNamNhap.Size = new System.Drawing.Size(121, 21);
            this.cbNamNhap.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Năm";
            // 
            // cbThangNhap
            // 
            this.cbThangNhap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThangNhap.FormattingEnabled = true;
            this.cbThangNhap.Location = new System.Drawing.Point(61, 40);
            this.cbThangNhap.Name = "cbThangNhap";
            this.cbThangNhap.Size = new System.Drawing.Size(121, 21);
            this.cbThangNhap.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(497, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thống kê nhập hàng";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtTongThu);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txtSoLuongBan);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.gvBanHang);
            this.tabPage2.Controls.Add(this.btnXuatBaoCaoBan);
            this.tabPage2.Controls.Add(this.btnThongKeBan);
            this.tabPage2.Controls.Add(this.cbNamBan);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.cbThangBan);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(643, 375);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bán hàng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtTongThu
            // 
            this.txtTongThu.Location = new System.Drawing.Point(423, 336);
            this.txtTongThu.Name = "txtTongThu";
            this.txtTongThu.Size = new System.Drawing.Size(214, 20);
            this.txtTongThu.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(319, 339);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Thành tiền (Tổng) :";
            // 
            // txtSoLuongBan
            // 
            this.txtSoLuongBan.Location = new System.Drawing.Point(101, 336);
            this.txtSoLuongBan.Name = "txtSoLuongBan";
            this.txtSoLuongBan.Size = new System.Drawing.Size(134, 20);
            this.txtSoLuongBan.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 343);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Số lượng (Tổng) :";
            // 
            // gvBanHang
            // 
            this.gvBanHang.AllowUserToAddRows = false;
            this.gvBanHang.AllowUserToDeleteRows = false;
            this.gvBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBanHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.gvBanHang.Location = new System.Drawing.Point(6, 68);
            this.gvBanHang.Name = "gvBanHang";
            this.gvBanHang.ReadOnly = true;
            this.gvBanHang.Size = new System.Drawing.Size(631, 239);
            this.gvBanHang.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tháng";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Số lượng bán";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 155;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Tổng tiền";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 230;
            // 
            // btnXuatBaoCaoBan
            // 
            this.btnXuatBaoCaoBan.Location = new System.Drawing.Point(540, 29);
            this.btnXuatBaoCaoBan.Name = "btnXuatBaoCaoBan";
            this.btnXuatBaoCaoBan.Size = new System.Drawing.Size(97, 23);
            this.btnXuatBaoCaoBan.TabIndex = 7;
            this.btnXuatBaoCaoBan.Text = "Xuất báo cáo";
            this.btnXuatBaoCaoBan.UseVisualStyleBackColor = true;
            this.btnXuatBaoCaoBan.Click += new System.EventHandler(this.btnXuatBaoCaoBan_Click);
            // 
            // btnThongKeBan
            // 
            this.btnThongKeBan.Location = new System.Drawing.Point(438, 29);
            this.btnThongKeBan.Name = "btnThongKeBan";
            this.btnThongKeBan.Size = new System.Drawing.Size(75, 23);
            this.btnThongKeBan.TabIndex = 6;
            this.btnThongKeBan.Text = "Thống kê";
            this.btnThongKeBan.UseVisualStyleBackColor = true;
            this.btnThongKeBan.Click += new System.EventHandler(this.btnThongKeBan_Click);
            // 
            // cbNamBan
            // 
            this.cbNamBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNamBan.FormattingEnabled = true;
            this.cbNamBan.Location = new System.Drawing.Point(271, 31);
            this.cbNamBan.Name = "cbNamBan";
            this.cbNamBan.Size = new System.Drawing.Size(121, 21);
            this.cbNamBan.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(223, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Năm";
            // 
            // cbThangBan
            // 
            this.cbThangBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThangBan.FormattingEnabled = true;
            this.cbThangBan.Location = new System.Drawing.Point(80, 31);
            this.cbThangBan.Name = "cbThangBan";
            this.cbThangBan.Size = new System.Drawing.Size(121, 21);
            this.cbThangBan.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tháng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(497, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Thống kê bán hàng";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(584, 448);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 13;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 478);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "FormThongKe";
            this.Text = "FormThongKe";
            this.Load += new System.EventHandler(this.FormThongKe_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhapHang)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBanHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtTongChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoLuongNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gvNhapHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.Button btnXuatBaoCaoNhap;
        private System.Windows.Forms.Button btnThongKeNhap;
        private System.Windows.Forms.ComboBox cbNamNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbThangNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTongThu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSoLuongBan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView gvBanHang;
        private System.Windows.Forms.Button btnXuatBaoCaoBan;
        private System.Windows.Forms.Button btnThongKeBan;
        private System.Windows.Forms.ComboBox cbNamBan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbThangBan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}