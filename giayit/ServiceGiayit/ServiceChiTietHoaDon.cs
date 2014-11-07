using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceGiayit
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceChiTietHoaDon" in both code and config file together.
    public class ServiceChiTietHoaDon : IServiceChiTietHoaDon
    {
        giayitEntities db = new giayitEntities();
        ServiceHoaDon hd = new ServiceHoaDon();
        ServiceTonKho tk = new ServiceTonKho();
        //Trừ số lượng theo đơn đặt hàng
        public bool trusoluongdathang(int mahd)
        {
            var list=Select_chitiethoadon_theomahd(mahd);
            foreach (var t in list)
            {
                tk.giamtk(t.masanpham.ToString(), int.Parse(t.soluong.ToString()));
            }
            return true;
        }
        public List<chitiethoadon> Select_chitiethoadon_theomahd(int mahd)
        {
            var list = new List<chitiethoadon>();
            var ccthoadon = from n in db.chitiethoadons where n.mahoadon==mahd select n;
            foreach (chitiethoadon lsp in ccthoadon)
            {
                chitiethoadon lst = new chitiethoadon()
                {
                    mahoadon = lsp.mahoadon,
                    masanpham = lsp.masanpham,
                    tensanpham = lsp.tensanpham,
                    soluong = lsp.soluong,
                    giasanpham = lsp.giasanpham

                };
                list.Add(lst);
            }
            return list;
        }

        public List<chitiethoadon> Getallchitiethoadon()
        {
            var list = new List<chitiethoadon>();
            var ccthoadon = from n in db.chitiethoadons select n;
            foreach (chitiethoadon lsp in ccthoadon)
            {
                chitiethoadon lst = new chitiethoadon()
                {
                    mahoadon = lsp.mahoadon,
                    masanpham = lsp.masanpham,
                    tensanpham = lsp.tensanpham,
                    soluong = lsp.soluong,
                    giasanpham = lsp.giasanpham

                };
                list.Add(lst);
            }
            return list;
        }


        public void themchitiethoadon(int mahoadon, string masp, int soluong, string tensp, int giasp)
        {
            chitiethoadon cthd = new chitiethoadon();
            cthd.mahoadon = mahoadon;
            cthd.masanpham = masp;
            cthd.soluong = soluong;
            cthd.tensanpham = tensp;
            cthd.giasanpham = giasp;
            db.chitiethoadons.Add(cthd);
            db.SaveChanges();
        }


        public List<chitiethoadon> Select_chitiethoadon_theonam(int nam)
        {
            var dshd = hd.Getallhoadon();
            var dscthd = Getallchitiethoadon();
            dscthd = (from p in dscthd
                      join q in dshd
                      on p.mahoadon equals q.mahoadon
                      where DateTime.Parse(q.ngaygiaohang.ToString()).Year == nam
                      && q.tinhtrang.Equals("đã giao")
                      select p).ToList();

            return dscthd;
        }


        


        public List<chitiethoadon> Select_chitiethoadon_theothang(int thang, int nam)
        {
            var dshd = hd.Getallhoadon();
            var dscthd = Getallchitiethoadon();
            dscthd = (from p in dscthd
                      join q in dshd
                      on p.mahoadon equals q.mahoadon
                      where DateTime.Parse(q.ngaygiaohang.ToString()).Month == thang
                      && DateTime.Parse(q.ngaygiaohang.ToString()).Year == nam
                      && q.tinhtrang.Equals("đã giao")
                      select p).ToList();

            return dscthd;
        }

        public int laysoluongtheongay(int ngay, List<chitiethoadon> dscthd)
        {
            int soluong = 0;
            var dshd = hd.Getallhoadon();            
            dscthd = (from p in dscthd
                      join q in dshd
                      on p.mahoadon equals q.mahoadon
                      where DateTime.Parse(q.ngaygiaohang.ToString()).Day == ngay
                      && q.tinhtrang.Equals("đã giao")
                      select p).ToList();

            foreach (chitiethoadon c in dscthd)
            {
                soluong += int.Parse(c.soluong.ToString());
            }
            return soluong;
        }


        public int laysoluongtheothang(int thang, List<chitiethoadon> dscthd)
        {
            int soluong = 0;
            var dshd = hd.Getallhoadon();
            dscthd = (from p in dscthd
                      join q in dshd
                      on p.mahoadon equals q.mahoadon
                      where DateTime.Parse(q.ngaygiaohang.ToString()).Month == thang
                      && q.tinhtrang.Equals("đã giao")
                      select p).ToList();

            foreach (chitiethoadon c in dscthd)
            {
                soluong += int.Parse(c.soluong.ToString());
            }
            return soluong;
        }
    }
}
