using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_giayit
{
    public partial class FormThongKe : Form
    {
        ServiceReferencePhieuNhap.ServicePhieuNhapClient pn = new ServiceReferencePhieuNhap.ServicePhieuNhapClient();
        

        public FormThongKe()
        {
            InitializeComponent();
        }

        

        private void nam()
        {
            gvNhapHang.Columns[1].HeaderText = "Tháng";
            gvBanHang.Columns[1].HeaderText = "Tháng";
        }

        private void thang()
        {
            gvNhapHang.Columns[1].HeaderText = "Ngày";
            gvBanHang.Columns[1].HeaderText = "Ngày";
        }

        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }

        bool kiemtranamnhuan(int nam)
        {
            if (nam % 4 == 0 && nam % 100 != 0)
                return true;
            return false;
        }

        int layngay(int thang, int nam)
        {
            if (thang == 2)
            {
                if (kiemtranamnhuan(nam))
                    return 29;
                else
                    return 28;
            }
            else
            {
                if (thang == 4 || thang == 6 || thang == 9 || thang == 12)
                    return 30;
                else
                    return 31;
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            cbThangNhap.Items.Add("Không chọn");
            cbThangBan.Items.Add("Không chọn");
            for (int i = 1; i <= 12; i++)
            {
                cbThangNhap.Items.Add(i);
                cbThangBan.Items.Add(i);
            }

            List<int> so = new List<int>();
            for (int i = DateTime.Now.Year; i >= DateTime.Now.Year - 10; i--)
                so.Add(i);
            cbNamNhap.DataSource = so;
            cbNamBan.DataSource = so;


        }

        private void btnThongKeNhap_Click(object sender, EventArgs e)
        {
            int stt = 1;
            float thanhtien = 0;
            int tongsoluong = 0;
            gvNhapHang.Rows.Clear();

            if (cbThangNhap.Text == "" || cbThangNhap.Text == "Không chọn")
            {
                PhieuNhap pn = new PhieuNhap();
                nam();                
                int[] soluongsanpham = new int[13];
                float[] tongtiennhap = new float[13];
                pn.Thongketheonam_phieunhap(int.Parse(cbNamNhap.Text), soluongsanpham, tongtiennhap);
                for (int i = 1; i <= 12; i++)
                {
                    string thang = "";
                    if (i < 10)
                        thang = "0" + i.ToString();
                    else
                        thang = i.ToString();
                    string tongtien = tongtiennhap[i].ToString("c");
                    tongtien = tongtien.Substring(1, tongtien.LastIndexOf(".") - 1);
                    thanhtien += tongtiennhap[i];
                    tongsoluong += soluongsanpham[i];
                    if (tongtiennhap[i] > 0)
                    {
                        gvNhapHang.Rows.Add(stt, thang, soluongsanpham[i], tongtien);
                        stt++;
                    }
                }
            }
            else
            {
                thang();
                PhieuNhap pn = new PhieuNhap();
                int[] soluongsanpham = new int[32];
                float[] tongtiennhap = new float[32];
                pn.Thongketheothang_phieunhap(int.Parse(cbThangNhap.Text), int.Parse(cbNamNhap.Text), soluongsanpham, tongtiennhap);
                for (int i = 1; i < layngay(int.Parse(cbThangNhap.Text), int.Parse(cbNamNhap.Text)); i++)
                {
                    string ngay = "";
                    if (i < 10)
                        ngay = "0" + i.ToString();
                    else
                        ngay = i.ToString();
                    string tongtien = tongtiennhap[i].ToString("c");
                    tongtien = tongtien.Substring(1, tongtien.LastIndexOf(".") - 1);
                    thanhtien += tongtiennhap[i];
                    tongsoluong += soluongsanpham[i];
                    if (soluongsanpham[i] > 0)
                    {
                        gvNhapHang.Rows.Add(stt, ngay, soluongsanpham[i], tongtien);
                        stt++;
                    }
                }
            }
            string tt = thanhtien.ToString("c");
            tt = tt.Substring(1, tt.LastIndexOf(".") - 1) + " VNĐ";
            txtTongChi.Text = tt;
            txtSoLuongNhap.Text = tongsoluong.ToString();
        }

        private void btnThongKeBan_Click(object sender, EventArgs e)
        {
            int stt = 1;
            float thanhtien = 0;
            int tongsoluong = 0;
            gvBanHang.Rows.Clear();
            if (cbThangBan.Text == "" || cbThangBan.Text == "Không chọn")
            {
                HoaDon pn = new HoaDon();
                nam();
                int[] soluongsanpham = new int[13];
                float[] tongtiennhap = new float[13];
                pn.Thongketheonam_donhang(int.Parse(cbNamBan.Text), soluongsanpham, tongtiennhap);
                for (int i = 1; i <= 12; i++)
                {
                    string thang = "";
                    if (i < 10)
                        thang = "0" + i.ToString();
                    else
                        thang = i.ToString();
                    string tongtien = tongtiennhap[i].ToString("c");
                    tongtien = tongtien.Substring(1, tongtien.LastIndexOf(".") - 1);
                    thanhtien += tongtiennhap[i];
                    tongsoluong += soluongsanpham[i];
                    if (tongtiennhap[i] > 0)
                    {
                        gvBanHang.Rows.Add(stt, thang, soluongsanpham[i], tongtien);
                        stt++;
                    }
                }
            }
            else
            {
                thang();
                HoaDon pn = new HoaDon();
                int[] soluongsanpham = new int[32];
                float[] tongtiennhap = new float[32];
                pn.Thongketheothang_donhang(int.Parse(cbThangBan.Text), int.Parse(cbNamBan.Text), soluongsanpham, tongtiennhap);
                for (int i = 1; i < layngay(int.Parse(cbThangBan.Text), int.Parse(cbNamBan.Text)); i++)
                {
                    string ngay = "";
                    if (i < 10)
                        ngay = "0" + i.ToString();
                    else
                        ngay = i.ToString();
                    string tongtien = tongtiennhap[i].ToString("c");
                    tongtien = tongtien.Substring(1, tongtien.LastIndexOf(".") - 1);
                    thanhtien += tongtiennhap[i];
                    tongsoluong += soluongsanpham[i];
                    if (soluongsanpham[i] > 0)
                    {
                        gvBanHang.Rows.Add(stt, ngay, soluongsanpham[i], tongtien);
                        stt++;
                    }
                }
            }

            string tt = thanhtien.ToString("c");
            tt = tt.Substring(1, tt.LastIndexOf(".") - 1) + " VNĐ";
            txtTongThu.Text = tt;
            txtSoLuongBan.Text = tongsoluong.ToString();
        }

        private void btnXuatBaoCaoNhap_Click(object sender, EventArgs e)
        {
            Report rp = new Report();
            rp.ExportToExcel_nhap(gvNhapHang, txtSoLuongNhap, txtTongChi, cbThangNhap, cbNamNhap);
        }

        private void btnXuatBaoCaoBan_Click(object sender, EventArgs e)
        {
            Report rp = new Report();
            rp.ExportToExcel_ban(gvBanHang, txtSoLuongBan, txtTongThu, cbThangBan, cbNamBan);
        }


    }
}
