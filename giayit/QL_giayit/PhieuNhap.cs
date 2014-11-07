using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace QL_giayit
{
    class PhieuNhap
    {
        ServiceReferencePhieuNhap.ServicePhieuNhapClient pn = new ServiceReferencePhieuNhap.ServicePhieuNhapClient();
        ServiceReferenceChiTietPhieuNhap.ServiceChiTietPhieuNhapClient ctpn = new ServiceReferenceChiTietPhieuNhap.ServiceChiTietPhieuNhapClient();

        public void Thongketheonam_phieunhap(int nam, int[] soluongsanpham, float[] tongtien)
        {
            var dspn = pn.Select_phieunhap_theonam(nam);
            var dsctpn = ctpn.Select_chitietphieunhap_theonam(nam);
            for (int i = 1; i <= 12; i++)
            {
                soluongsanpham[i] = ctpn.laysoluongtheothang(i, dsctpn);
                tongtien[i] = pn.laytongtientheothang(i, dspn);
            }

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

        public void Thongketheothang_phieunhap(int thang, int nam, int[] soluongsanpham, float[] tongtien)
        {
            var dspn = pn.Select_phieunhap_theothang(thang, nam);
            var dsctpn = ctpn.Select_chitietphieunhap_theothang(thang, nam);

            for (int i = 1; i <= layngay(thang, nam); i++)
            {
                soluongsanpham[i] = ctpn.laysoluongtheongay(i, dsctpn);
                tongtien[i] = pn.laytongtientheongay(i, dspn);
            }
        }
        public void TachSo(TextBox luong)
        {
            string txt, txt1;
            txt1 = luong.Text.Replace(",", "");
            txt = "";
            int n = txt1.Length;
            int dem = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                if (dem == 2 && i != 0)
                {
                    txt = "," + txt1.Substring(i, 1) + txt;
                    dem = 0;
                }
                else
                {
                    txt = txt1.Substring(i, 1) + txt;
                    dem += 1;
                }
            }
            luong.Text = txt;
            luong.SelectionStart = luong.Text.Length;
        }  
        

        
    }
}
