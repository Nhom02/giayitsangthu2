using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_giayit
{
    public partial class FormNhapHang : Form
    {
        ServiceReferenceSanPham.ServiceSanPhamClient SP = new ServiceReferenceSanPham.ServiceSanPhamClient();
        ServiceReferenceChiTietPhieuNhap.ServiceChiTietPhieuNhapClient CTPN = new ServiceReferenceChiTietPhieuNhap.ServiceChiTietPhieuNhapClient();
        ServiceReferencePhieuNhap.ServicePhieuNhapClient PN = new ServiceReferencePhieuNhap.ServicePhieuNhapClient();
        ServiceReferenceTonKho.ServiceTonKhoClient TK = new ServiceReferenceTonKho.ServiceTonKhoClient();
        int k = 1;
        string gia;
        int tongtien2;
        public FormNhapHang()
        {
            InitializeComponent();
            load();
            lbsl.Hide();
            lbgt.Hide();
        }
        public void load()
        {
            var grv = SP.Getallsanpham();
            gvSanPham.AutoGenerateColumns = false;
            gvSanPham.DataSource = grv;
            gvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void gvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            k = 0;
            DataGridViewRow dr = gvSanPham.SelectedRows[0];
            txtTenSP.Text = dr.Cells["TenSP"].Value.ToString();
            txtMaSP.Text = dr.Cells["MaSP"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (k == 0)
            {
                if (txtSL.Text != "" && txtGia.Text != "")
                {
                    try
                    {
                        int t = 0;
                        gvphieunhap.Rows.Add(txtMaSP.Text, txtTenSP.Text, txtSL.Text, txtGia.Text);
                        for (int i = 0; i < int.Parse(gvphieunhap.RowCount.ToString()); i++)
                        {
                            string re = gvphieunhap.Rows[i].Cells["GiaSP"].Value.ToString().Replace(",", "");
                            t += int.Parse(gvphieunhap.Rows[i].Cells["Soluong"].Value.ToString()) * int.Parse(re);
                        }
                        
                        string tongtien = t.ToString("c");
                        txtTongTien.Text = tongtien.Substring(1, tongtien.LastIndexOf(".") - 1) + " VNĐ";
                        tongtien2 = t;
                    }
                    catch { }
                }
                else 
                {
                    if (txtSL.Text == "")
                    {
                        lbsl.Show();
                    }
                    if (txtGia.Text == "")
                    {
                        lbgt.Show();
                    }
                    MessageBox.Show("Chưa nhập giá và số lượng"); 
                }
            }
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            lbsl.Hide();
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            lbgt.Hide();
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {
            PhieuNhap pn = new PhieuNhap();
          //  gia.re
            pn.TachSo(txtGia);
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            gvphieunhap.AutoGenerateColumns = false;
            gvphieunhap.Rows.Clear();
            gvphieunhap.DataSource = null;
            txtTongTien.Text = "Tổng tiền";
        }

        private void btnLuuu_Click(object sender, EventArgs e)
        {
            if (txtNguoiNhap.Text == ""||int.Parse(gvphieunhap.RowCount.ToString())<=0)
            { 
                MessageBox.Show("Bạn chưa nhập tên người lập phiếu hoặc chưa chọn sản phẩm"); 
            }
            else
            {
                int a = PN.getallphieunhap().Count();
                a++;
                try
                {
                    if (PN.Thempn(txtNguoiNhap.Text, DateTime.Now, tongtien2))
                    {
                        for (int i = 0; i < int.Parse(gvphieunhap.RowCount.ToString()); i++)
                        {
                            TK.Themtk(gvphieunhap.Rows[i].Cells["MaSanPham"].Value.ToString(), int.Parse(gvphieunhap.Rows[i].Cells["SoLuong"].Value.ToString()));
                            CTPN.Themctpn(a, gvphieunhap.Rows[i].Cells["MaSanPham"].Value.ToString(), int.Parse(gvphieunhap.Rows[i].Cells["GiaSP"].Value.ToString().Replace(",", "")), int.Parse(gvphieunhap.Rows[i].Cells["SoLuong"].Value.ToString()));
                        }
                    }
                    MessageBox.Show("Thêm thành công");
                    this.Close();
                }
                catch 
                { 
                    MessageBox.Show("Thêm thất bại"); 
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            gvSanPham.AutoGenerateColumns = false;
        //    
            gvSanPham.DataSource = null;
            
          var  listSanPham = SP.Getallsanpham();
          //var listtk;
            foreach (var item in listSanPham)
            {
                string tensp = item.masanpham.Trim();
                if (tensp.Contains(txttk.Text.Trim()) || tensp.StartsWith(txttk.Text.Trim()) || tensp.EndsWith(txttk.Text.Trim()) || tensp == txttk.Text.Trim())
                {
                    gvSanPham.Rows.Add(item.masanpham,item.tensanpham,item.soluongcon,item.giasanpham);
                }
            }
            gvSanPham.Rows.Clear();
            gvSanPham.DataSource = null;
          //  gvSanPham.DataSource = listtk;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvphieunhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gvphieunhap.Columns["xoa"].Index && int.Parse(gvphieunhap.RowCount.ToString()) > 0)
            {
                // int i = 0;
                try
                {
                  //  foreach (DataGridViewRow item in this.gvphieunhap.SelectedRows)
                  //  {
                   //     gvphieunhap.Rows.RemoveAt(item.Index);
                   // }
                    foreach (DataGridViewCell oneCell in gvphieunhap.SelectedCells)
                    {
                        if (oneCell.Selected)
                            gvphieunhap.Rows.RemoveAt(oneCell.RowIndex);
                    }
                }
                catch
                { }
            }
        }

        private void FormNhapHang_Load(object sender, EventArgs e)
        {

        }
    }
}
