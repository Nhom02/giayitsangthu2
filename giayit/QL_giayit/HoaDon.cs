using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_giayit
{
    class HoaDon
    {
        ServiceReferenceHoaDon.ServiceHoaDonClient hd = new ServiceReferenceHoaDon.ServiceHoaDonClient();
        ServiceReferenceChiTietHoaDon.ServiceChiTietHoaDonClient cthd = new ServiceReferenceChiTietHoaDon.ServiceChiTietHoaDonClient();

        public void Thongketheonam_donhang(int nam, int[] soluongsanpham, float[] tongtien)
        {
            var dshd = hd.Select_hoadon_theonam(nam);
            var dscthd = cthd.Select_chitiethoadon_theonam(nam);
            for (int i = 1; i < 13; i++)
            {
                soluongsanpham[i] = cthd.laysoluongtheothang(i, dscthd);
                tongtien[i] = hd.laytongtientheothang(i, dshd);
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

        public void Thongketheothang_donhang(int thang, int nam, int[] soluongsanpham, float[] tongtien)
        {
            var dspn = hd.Select_hoadon_theothang(thang, nam);
            var dsctpn = cthd.Select_chitiethoadon_theothang(thang, nam);

            for (int i = 1; i <= layngay(thang, nam); i++)
            {
                soluongsanpham[i] = cthd.laysoluongtheongay(i, dsctpn);
                tongtien[i] = hd.laytongtientheongay(i, dspn);
            }
        }
    }
}
