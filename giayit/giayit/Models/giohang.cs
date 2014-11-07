using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace giayit.Models
{
    public class giohang
    {

        ServiceReferenceHoaDon.ServiceHoaDonClient hd = new ServiceReferenceHoaDon.ServiceHoaDonClient();
        ServiceReferenceChiTietHoaDon.ServiceChiTietHoaDonClient cthd = new ServiceReferenceChiTietHoaDon.ServiceChiTietHoaDonClient();

        public List<bizgiohang> listsp = new List<bizgiohang>();
        public void AddItem(string Masp, string Tensp, int quantity, int giatien, string hinh, string sx, int slc)
        {
            bizgiohang sp = listsp
            .Where(p => p.masp == Masp).FirstOrDefault();
            if (sp == null)
            {
                listsp.Add(new bizgiohang { masp = Masp, tensp = Tensp, Quantity = quantity, giasanpham = giatien, hinhanh = hinh, xuatsu = sx, Soluongcon = slc });
            }
            else
            {
                sp.Quantity += quantity;
            }

        }
        public class bizgiohang
        {
            public string masp { get; set; }
            public string tensp { get; set; }
            public string hinhanh { get; set; }
            public string xuatsu { get; set; }
            public int giasanpham { get; set; }
            public int Quantity { get; set; }
            public int Soluongcon { get; set; }
        }

        public void RemoveLine(string masp)
        {
            listsp.RemoveAll(l => l.masp == masp);
        }

        public void xoahet()
        {
            listsp.Clear();
        }

        public void capnhatsoluong(string masp, int soluong)
        {
            bizgiohang sp = listsp.Where(p => p.masp == masp).FirstOrDefault();
            sp.Quantity = soluong;

        }

        public decimal tongtien()
        {
            return listsp.Sum(e => e.giasanpham * e.Quantity);
        }

        public decimal tongsoluong()
        {
            return listsp.Sum(e => e.Quantity);
        }

        public void themhoadon(string tenkh, string diachi, string sdt, string makh, string email)
        {
            var _hd = (from s in hd.Getallhoadon() orderby s.mahoadon descending select s).FirstOrDefault();

            int i = _hd.mahoadon;
            i++;
            hd.themhoadon(i, tenkh, diachi, sdt, makh, email, listsp.Sum(e => e.giasanpham * e.Quantity));

            foreach (var item in listsp)
            {
                cthd.themchitiethoadon(i, item.masp, item.Quantity, item.tensp, item.giasanpham);
            }
            listsp.Clear();
        }
    }
}