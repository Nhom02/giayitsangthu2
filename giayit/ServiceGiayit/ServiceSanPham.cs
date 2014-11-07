using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceGiayit
{
    
    public class ServiceSanPham : IServiceSanPham
    {
        giayitEntities db = new giayitEntities();
       // ServiceTonKho tk = new ServiceTonKho();

        public bool editsp(string id, string tensp, string chatlieu, string gia, string mota, string sl, string _hinhanh, string loaisp, string _url)
        {
            var sanpham = db.sanphams.First(m => m.masanpham == id);
            try
            {
                sanpham.masanpham = id;
                sanpham.tensanpham = tensp;
                sanpham.chatlieu = chatlieu;
                sanpham.giasanpham = int.Parse(gia);
                sanpham.motasanpham = mota;
                sanpham.soluongcon = int.Parse(sl);
                sanpham.hinhanh = _url;
                sanpham.ghichu = 1;
                sanpham.sanphammoi = 1;
                sanpham.manhacungcap = 1;
                sanpham.maloai = loaisp;
                // UpdateModel(sanpham);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool deletesp(string masp)
        {
            var acticle = db.sanphams.Where(m => m.masanpham.Trim() == masp.Trim()).SingleOrDefault();
            try
            {
                acticle.sanphammoi = 0;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool kichhoat(string masp)
        {
            var acticle = db.sanphams.Where(m => m.masanpham.Trim() == masp.Trim()).SingleOrDefault();
            try
            {
                acticle.sanphammoi = 1;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool themsp(string maloai, string tensp, string chatlieu, int gia, string mota, int sl, string hinhanh)
        {
            var _sp = (from s in db.sanphams orderby s.stt descending select s).FirstOrDefault();
            int _stt = int.Parse(_sp.stt.ToString());
            _stt++;
            sanpham sp = new sanpham();
            try
            {
                sp.masanpham = tensp;
                sp.tensanpham = tensp;
                sp.chatlieu = chatlieu;
                sp.giasanpham = gia;
                sp.motasanpham = mota;
                sp.soluongcon = 0;
                sp.hinhanh = hinhanh;
                sp.ghichu = 1;
                sp.sanphammoi = 1;
                sp.maloai = maloai;
                sp.manhacungcap = 1;
                sp.stt = _stt;
                db.sanphams.Add(sp);
                db.SaveChanges();
               // tk.Themtk(sp.tensanpham, 0);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Đơn hàng
      
        
        // Người dùng
       
        public List<admin> Getalladmin()
        {
            var list = db.admins.ToList();
            return list;
        }
        
        
        public List<loaisanpham> Getallloaisanpham()
        {
            var lstLoaisanpham = new List<loaisanpham>();

            var danhmuc = from n in db.loaisanphams select n;
            foreach (loaisanpham lsp in danhmuc)
            {
                loaisanpham lst = new loaisanpham()
                {
                    maloai = lsp.maloai,
                    tenloai = lsp.tenloai
                };
                lstLoaisanpham.Add(lst);
            }

            return lstLoaisanpham;
        }


        public List<sanpham> Getallsanpham()
        {
            var lstSanPham = new List<sanpham>();

            var sanpham = from n in db.sanphams select n;
            foreach (sanpham sp in sanpham)
            {
                sanpham lst = new sanpham()
                {
                    masanpham=sp.masanpham,
                    tensanpham=sp.tensanpham,
                    chatlieu=sp.chatlieu,
                    giasanpham=sp.giasanpham,
                    motasanpham=sp.motasanpham,
                    soluongcon=sp.soluongcon,
                    sanphammoi=sp.sanphammoi,
                    hinhanh=sp.hinhanh,
                    ghichu=sp.ghichu,
                    maloai=sp.maloai,
                    manhacungcap=sp.manhacungcap,
                    stt=sp.stt                    
                };
                lstSanPham.Add(lst);
            }

            return lstSanPham;
        }

        public List<sanpham> Getallsanpham_coan()
        {
            var lstSanPham = new List<sanpham>();

            var sanpham = from n in db.sanphams where n.sanphammoi==1 select n;
            foreach (sanpham sp in sanpham)
            {
                sanpham lst = new sanpham()
                {
                    masanpham = sp.masanpham,
                    tensanpham = sp.tensanpham,
                    chatlieu = sp.chatlieu,
                    giasanpham = sp.giasanpham,
                    motasanpham = sp.motasanpham,
                    soluongcon = sp.soluongcon,
                    sanphammoi = sp.sanphammoi,
                    hinhanh = sp.hinhanh,
                    ghichu = sp.ghichu,
                    maloai = sp.maloai,
                    manhacungcap = sp.manhacungcap,
                    stt = sp.stt
                };
                lstSanPham.Add(lst);
            }

            return lstSanPham;
        }


        public List<nhacungcap> Getallnhacungcap()
        {
            var lstnhacungcap = new List<nhacungcap>();

            var nhacungcap = from n in db.nhacungcaps select n;
            foreach (nhacungcap lncc in nhacungcap)
            {
                nhacungcap lst = new nhacungcap()
                {
                    manhacungcap = lncc.manhacungcap,
                    tennhacungcap = lncc.tennhacungcap
                };
                lstnhacungcap.Add(lst);
            }

            return lstnhacungcap;
        }


        public sanpham getsanpham(string masanpham)
        {
            var sanpham = db.sanphams.First(x => x.masanpham == masanpham);
            sanpham sp = new sanpham();
            try
            {
                sp.masanpham = sanpham.masanpham;
                sp.tensanpham = sanpham.tensanpham;
                sp.chatlieu = sanpham.chatlieu;
                sp.giasanpham = sanpham.giasanpham;
                sp.motasanpham = sanpham.motasanpham;
                sp.soluongcon = sanpham.soluongcon;
                sp.hinhanh = sanpham.hinhanh;
                sp.ghichu = sanpham.ghichu;
                sp.sanphammoi = sanpham.sanphammoi;
                sp.maloai = sanpham.maloai;
                sp.manhacungcap = sanpham.manhacungcap;
                sp.stt = sanpham.stt;

                return sp;
            }
            catch
            {
                return sp;
            }
        }
      public  bool editslsp(string masp, int soluong)
        {
            var sanpham = db.sanphams.First(m => m.masanpham == masp);
            try
            {
                sanpham.masanpham = sanpham.masanpham;
                sanpham.tensanpham = sanpham.tensanpham;
                sanpham.chatlieu = sanpham.chatlieu;
                sanpham.giasanpham = sanpham.giasanpham;
                sanpham.motasanpham = sanpham.motasanpham;
                sanpham.soluongcon = soluong;
                sanpham.hinhanh = sanpham.hinhanh;
                sanpham.ghichu = sanpham.ghichu;
                sanpham.sanphammoi = sanpham.sanphammoi;
                sanpham.manhacungcap = sanpham.manhacungcap;
                sanpham.maloai = sanpham.maloai;
                // UpdateModel(sanpham);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        ///Giảm số lượng sản phẩm khi đặt hàng
      public bool editslspgiam(string masp, int soluong)
      {
          var sanpham = db.sanphams.First(m => m.masanpham == masp);
          try
          {
              sanpham.masanpham = sanpham.masanpham;
              sanpham.tensanpham = sanpham.tensanpham;
              sanpham.chatlieu = sanpham.chatlieu;
              sanpham.giasanpham = sanpham.giasanpham;
              sanpham.motasanpham = sanpham.motasanpham;
              sanpham.soluongcon = sanpham.soluongcon-soluong;
              sanpham.hinhanh = sanpham.hinhanh;
              sanpham.ghichu = sanpham.ghichu;
              sanpham.sanphammoi = sanpham.sanphammoi;
              sanpham.manhacungcap = sanpham.manhacungcap;
              sanpham.maloai = sanpham.maloai;
              // UpdateModel(sanpham);
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
