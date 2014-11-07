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
    public partial class FormQuanLyTonKho : Form
    {
        ServiceReferenceSanPham.ServiceSanPhamClient sp = new ServiceReferenceSanPham.ServiceSanPhamClient();
        ServiceReferenceTonKho.ServiceTonKhoClient tk = new ServiceReferenceTonKho.ServiceTonKhoClient();
        public FormQuanLyTonKho()
        {
            InitializeComponent();
        }

        private void Lamlai()
        {
            gvTonKho.Rows.Clear();
            int tongsoluongtonkho = 0;
            var dstk = tk.getalltonkholoc(DateTime.Now);
            var dssp = sp.Getallsanpham();
            foreach (var tonkho in dstk)
            {
                tongsoluongtonkho += int.Parse(tonkho.soluong.ToString());
                foreach (var sanpham in dssp)
                {

                    if (sanpham.masanpham == tonkho.masanpham)
                    {
                        string gia = sanpham.giasanpham.ToString("c");
                        gia = gia.Substring(1, gia.LastIndexOf(".") - 1) + " VNĐ";
                        gvTonKho.Rows.Add(tonkho.ngay, tonkho.masanpham, sanpham.tensanpham, sanpham.maloai, gia, tonkho.soluong);
                    }
                }
            }
            txtTongSoLuong.Text = tongsoluongtonkho.ToString() + " Cái";
        }

        private void gvTonKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormQuanLyTonKho_Load(object sender, EventArgs e)
        {
                int tongsoluongtonkho = 0;

                var dssp = sp.Getallsanpham();
                
                cbTenSanPham.DataSource = dssp;
                cbTenSanPham.DisplayMember = "tensanpham";
                cbTenSanPham.ValueMember = "masanpham";

                var dslsp = sp.Getallloaisanpham();
                cbLoaiSanPham.DataSource = dslsp;
                cbLoaiSanPham.DisplayMember = "tenloai";
                cbLoaiSanPham.ValueMember = "maloai";

                var dstk = tk.getalltonkholoc(DateTime.Now);
                foreach (var tonkho in dstk)
                {
                    tongsoluongtonkho += int.Parse(tonkho.soluong.ToString());
                    foreach (var sanpham in dssp)
                    {
                        if (sanpham.masanpham == tonkho.masanpham)
                        {
                            string gia = sanpham.giasanpham.ToString("c");
                            gia = gia.Substring(1, gia.LastIndexOf(".") - 1) + " VNĐ";
                            gvTonKho.Rows.Add(tonkho.ngay, tonkho.masanpham, sanpham.tensanpham, sanpham.maloai, gia, tonkho.soluong);
                        }
                    }
                }

                txtTongSoLuong.Text = tongsoluongtonkho.ToString() + " Cái";                         
                       
            
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTKDSSP_Click(object sender, EventArgs e)
        {
            int tongsoluongtonkho = 0;
            gvTonKho.Rows.Clear();

            var dstk = tk.Select_tonkho(ngayxem.Value.Date, cbLoaiSanPham.SelectedValue.ToString());

            foreach (var tonkho in dstk)            
            {
                tongsoluongtonkho += int.Parse(tonkho.soluong.ToString());
                foreach (var sanpham in sp.Getallsanpham())
                {
                    if (sanpham.masanpham == tonkho.masanpham)
                    {
                        string gia = sanpham.giasanpham.ToString("c");
                        gia = gia.Substring(1, gia.LastIndexOf(".") - 1) + " VNĐ";
                        gvTonKho.Rows.Add(tonkho.ngay, tonkho.masanpham, sanpham.tensanpham, sanpham.maloai, gia, tonkho.soluong);
                    }
                }
            }

            txtTongSoLuong.Text = tongsoluongtonkho.ToString() + " cái";


        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            Lamlai();
        }

        private void btnTKSP_Click(object sender, EventArgs e)
        {
            int tongsoluongtonkho = 0;
            var dstk = tk.Select_tonkho_theosanpham(dtpNgaySP.Value.Date, cbTenSanPham.SelectedValue.ToString());
            foreach (var tonkho in dstk)
            {
                tongsoluongtonkho += int.Parse(tonkho.soluong.ToString());
            }
            txtSLSP.Text = tongsoluongtonkho.ToString() + " cái";
        }

        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {
            Report rp = new Report();
            rp.ExportToExcel_dssp(gvTonKho, txtTongSoLuong);
        }
    }
}
