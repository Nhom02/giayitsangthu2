using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceGiayit
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceChiTietPhieuNhap" in both code and config file together.
    public class ServiceChiTietPhieuNhap : IServiceChiTietPhieuNhap
    {
        giayitEntities db = new giayitEntities();
        ServicePhieuNhap pn = new ServicePhieuNhap();

        public List<chitietphieunhap> getallchitietphieunhap()
        {
            var lstctpn = new List<chitietphieunhap>();

            var dspn = from n in db.chitietphieunhaps select n;
            foreach (chitietphieunhap ctpn in dspn)
            {
                chitietphieunhap lst = new chitietphieunhap()
                {
                    maphieunhap = ctpn.maphieunhap,
                    masanpham=ctpn.masanpham,
                    soluong=ctpn.soluong,
                    gia=ctpn.gia
                };
                lstctpn.Add(lst);
            }

            return lstctpn;
        }


        public List<chitietphieunhap> Select_chitietphieunhap_theonam(int nam)
        {
            var dspn = pn.getallphieunhap();
            var dsctpn = getallchitietphieunhap();
            dsctpn = (from p in dsctpn
                      join q in dspn
                      on p.maphieunhap equals q.maphieunhap
                      where DateTime.Parse(q.ngaynhap.ToString()).Year == nam
                      select p).ToList();

            return dsctpn;
        }


        public int laysoluongtheothang(int thang, List<chitietphieunhap> dsctpn)
        {
            int soluong = 0;
            var dspn = pn.getallphieunhap();            
            dsctpn = (from p in dsctpn
                      join q in dspn
                      on p.maphieunhap equals q.maphieunhap
                      where DateTime.Parse(q.ngaynhap.ToString()).Month == thang
                      select p).ToList();

            foreach (chitietphieunhap c in dsctpn)
            {
                soluong += c.soluong;
            }
            return soluong;
        }


        public List<chitietphieunhap> Select_chitietphieunhap_theothang(int thang, int nam)
        {
            var dspn = pn.getallphieunhap();
            var dsctpn = getallchitietphieunhap();
            dsctpn = (from p in dsctpn
                      join q in dspn
                      on p.maphieunhap equals q.maphieunhap
                      where DateTime.Parse(q.ngaynhap.ToString()).Month == thang
                      && DateTime.Parse(q.ngaynhap.ToString()).Year == nam
                      select p).ToList();

            return dsctpn;
        }


        public int laysoluongtheongay(int ngay, List<chitietphieunhap> dsctpn)
        {
            int soluong = 0;
            var dspn = pn.getallphieunhap();           
            dsctpn = (from p in dsctpn
                      join q in dspn
                      on p.maphieunhap equals q.maphieunhap
                      where DateTime.Parse(q.ngaynhap.ToString()).Day == ngay
                      select p).ToList();

            foreach (chitietphieunhap c in dsctpn)
            {
                soluong += c.soluong;
            }
            return soluong;
        }

        public bool Themctpn(int maphieunhap, string masanpham, int gia, int soluong)
        {       
            chitietphieunhap ctpn = new chitietphieunhap();
            try
            {
                ctpn.maphieunhap = maphieunhap;
                ctpn.masanpham = masanpham;
                ctpn.gia = gia;
                ctpn.soluong = soluong;
                db.chitietphieunhaps.Add(ctpn);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
