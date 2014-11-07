using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
namespace ServiceGiayit
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceTonKho" in both code and config file together.
    public class ServiceTonKho : IServiceTonKho
    {
        giayitEntities db = new giayitEntities();
        ServiceSanPham sp = new ServiceSanPham();
       // ServiceChiTietHoaDon CTHD= new ServiceChiTietHoaDon();
        
        //Trừ số lượng khi thây đổi đơn hầng
        public bool Trusoluongkhidathang(string mahd)
        {
            /*  var cthd = CTHD.Getallchitiethoadon().Where(x => x.mahoadon == int.Parse(mahd)).ToList();
              foreach (var t in cthd)
              {
                  //sp.editslspgiam(t.masanpham, int.Parse(t.soluong.ToString()));
                  giamtk(t.masanpham, int.Parse(t.soluong.ToString()));
              }
              */
            return false;
           
        }

        public bool Them(string masp)
        {        
                tonkho sp1 = new tonkho();
                try
                {
                    sp1.ngay = DateTime.Parse(DateTime.Now.ToShortDateString());
                    sp1.masanpham = masp;
                    sp1.soluong = 0;
                    db.tonkhoes.Add(sp1);
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            
        }


        public bool Themtk(string masp, int soluong)
        {
            var tk = (from s in db.tonkhoes where s.masanpham==masp orderby s.ngay descending select s).FirstOrDefault();
            int _soluong = int.Parse(tk.soluong.ToString()) + soluong;
            if (sp.editslsp(masp, _soluong))
            {
                tonkho sp1 = new tonkho();
                try
                {
                    sp1.ngay = DateTime.Now;
                    sp1.masanpham = masp;
                    sp1.soluong = _soluong;
                    db.tonkhoes.Add(sp1);
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else return false;
        }

        public bool giamtk(string masp, int soluong)
        {
            var tk = (from s in db.tonkhoes where s.masanpham==masp orderby s.ngay descending select s).FirstOrDefault();
            int _soluong = int.Parse(tk.soluong.ToString()) - soluong;
            if (sp.editslspgiam(masp, _soluong))
            {
                tonkho sp1 = new tonkho();
                try
                {
                    sp1.ngay = DateTime.Parse(DateTime.Now.ToShortDateString());
                    sp1.masanpham = masp;
                    sp1.soluong = _soluong;
                    db.tonkhoes.Add(sp1);
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else return false;
        }


        public List<tonkho> getalltonkho()
        {
            var lstTonkho = new List<tonkho>();

            var tonkho = from n in db.tonkhoes select n;
            foreach (tonkho tk in tonkho)
            {
                tonkho ltk = new tonkho()
                {
                   ngay=tk.ngay,
                   masanpham=tk.masanpham,
                   soluong=tk.soluong
                };
                lstTonkho.Add(ltk);
            }

            return lstTonkho;
        }

        public List<tonkho> getalltonkholoc(DateTime time)
        {
            var lstTonkho = new List<tonkho>();   
           var sanpham= sp.Getallsanpham();
            var tonkho = from n in db.tonkhoes select n;
            int i = 1;
            foreach (var t in sanpham)
            {
                foreach (tonkho tk in tonkho)
                {
                    try
                    {
                        var date = (from n in getalltonkho() where n.masanpham == t.masanpham && DateTime.Parse(n.ngay.ToShortDateString()) <= time orderby DateTime.Parse(n.ngay.ToShortDateString()) descending select n).FirstOrDefault();
                        if (t.masanpham == tk.masanpham && tk.ngay == date.ngay)
                        {
                            tonkho ltk = new tonkho()
                            {
                                ngay = tk.ngay,
                                masanpham = tk.masanpham,
                                soluong = tk.soluong
                            };
                            lstTonkho.Add(ltk);
                            break;
                        }
                    }
                    catch {
                        tonkho ltk = new tonkho()
                        {
                            ngay = time,
                            masanpham = tk.masanpham,
                            soluong = 0
                        };
                        lstTonkho.Add(ltk);
                        break;
                    }
                   
                }
            }
            return lstTonkho;
        }

        public List<tonkho> Select_tonkho(DateTime ngay, string maloai)
        {            
            var dstk = getalltonkholoc(ngay);
            var dssp=sp.Getallsanpham();

            dstk = (from c in dstk 
                    join o in dssp 
                    on c.masanpham equals o.masanpham 
                    where o.maloai == maloai 
                    select c).ToList();
            return dstk;
        }


        public List<tonkho> Select_tonkho_theosanpham(DateTime ngay, string masp)
        {
            var dstk = getalltonkholoc(ngay);           

            dstk = (from c in dstk 
                    where c.masanpham == masp 
                    select c).ToList();
            return dstk;
        }

         

    }
}
