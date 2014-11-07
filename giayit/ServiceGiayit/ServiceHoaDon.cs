using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceGiayit
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceHoaDon" in both code and config file together.
    public class ServiceHoaDon : IServiceHoaDon
    {
        giayitEntities db = new giayitEntities();
        ServiceSanPham _sp = new ServiceSanPham();
      //  ServiceChiTietHoaDon _CTHD = new ServiceChiTietHoaDon();
       ServiceTonKho _TK = new ServiceTonKho();
     //  ServiceChiTietPhieuNhap CT = new ServiceChiTietPhieuNhap();
        public bool editdonhang(string mahd, string tinhtrang)
        {
            
            
            int _mahd = int.Parse(mahd);
            var hd = db.hoadons.First(m => m.mahoadon == _mahd);
            try
            {
                /*
                if (tinhtrang == "đã giao")
                {
                    _TK.Trusoluongkhidathang(mahd);
                }*/
                hd.mahoadon = _mahd;
                hd.makhachhang = hd.makhachhang;
                hd.tenkhachhang = hd.tenkhachhang;
                hd.ghichu = hd.ghichu;
                hd.email = hd.email;
                hd.ngaymuahang = hd.ngaymuahang;
                hd.ngaygiaohang = hd.ngaygiaohang;
                hd.tongtien = hd.tongtien;
                hd.sdt = hd.sdt;
                hd.diachi = hd.diachi;
                hd.tinhtrang = tinhtrang;
                //   UpdateModel(n);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<hoadon> Getallhoadon()
        {
            var list = new List<hoadon>();
            var hoadon = from n in db.hoadons select n;
            foreach (hoadon lsp in hoadon)
            {
                hoadon lst = new hoadon()
                {
                    makhachhang = lsp.makhachhang,
                    diachi = lsp.diachi,
                    email = lsp.email,
                    ghichu = lsp.ghichu,
                    tongtien = lsp.tongtien,
                    ngaygiaohang = lsp.ngaygiaohang,
                    ngaymuahang = lsp.ngaymuahang,
                    sdt = lsp.sdt,
                    mahoadon = lsp.mahoadon,
                    tenkhachhang = lsp.tenkhachhang,
                    tinhtrang = lsp.tinhtrang,

                };
                list.Add(lst);
            }
            return list;
        }


        public void themhoadon(int mahoadon, string tenkh, string diachi, string sdt, string makh, string email, int tongtien)
        {
            hoadon hd = new hoadon();
            hd.mahoadon = mahoadon;
            hd.makhachhang = makh;
            hd.tenkhachhang = tenkh;
            hd.diachi = diachi;
            hd.sdt = sdt;
            hd.email = email;
            hd.tongtien = tongtien;
            hd.ngaymuahang = DateTime.Parse(DateTime.Now.ToShortDateString());
            hd.ngaygiaohang = DateTime.Parse(DateTime.Now.ToShortDateString());
            hd.tinhtrang = "chưa liên lạc";
            hd.ghichu = "";
            db.hoadons.Add(hd);
            db.SaveChanges();     
        }


        public List<hoadon> Select_hoadon_theonam(int nam)
        {
            var dshd = Getallhoadon();
            dshd = (from hd in dshd
                    where DateTime.Parse(hd.ngaygiaohang.ToString()).Year == nam
                    && hd.tinhtrang.Equals("đã giao")
                    select hd).ToList();
            return dshd;
        }
        

        public float laytongtientheothang(int thang, List<hoadon> dshd)
        {
            float tong = 0;     
            dshd = (from hd in dshd
                    where DateTime.Parse(hd.ngaygiaohang.ToString()).Month == thang
                    && hd.tinhtrang.Equals("đã giao")
                    select hd).ToList();

            foreach (hoadon pn in dshd)
            {
                tong += int.Parse(pn.tongtien.ToString());
            }
            return tong;
        }


        public List<hoadon> Select_hoadon_theothang(int thang, int nam)
        {
            var dshd = Getallhoadon();
            dshd = (from hd in dshd
                    where DateTime.Parse(hd.ngaygiaohang.ToString()).Month == thang
                    && DateTime.Parse(hd.ngaygiaohang.ToString()).Year == nam
                    && hd.tinhtrang.Equals("đã giao")
                    select hd).ToList();
            return dshd;
        }

        public float laytongtientheongay(int ngay, List<hoadon> dshd)
        {
            float tong = 0;             
            dshd = (from hd in dshd
                    where DateTime.Parse(hd.ngaygiaohang.ToString()).Day == ngay                    
                    && hd.tinhtrang.Equals("đã giao")
                    select hd).ToList();
            foreach (hoadon pn in dshd)
            {
                tong += int.Parse(pn.tongtien.ToString());
            }
            return tong;

        }
    }
}
