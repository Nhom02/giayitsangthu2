using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace giayit.Controllers
{
    public class SanPhamController : Controller
    {

        int size = 9;

        ServiceReferenceSanPham.ServiceSanPhamClient obj = new ServiceReferenceSanPham.ServiceSanPhamClient();

        public ActionResult ChiTietSanPham(string masp)
        {
            var sp = obj.Getallsanpham_coan();
            var ctsp = sp.Where(x => x.masanpham == masp).ToList();
            var loaisp = obj.Getallloaisanpham();
            foreach (var item in ctsp)
            {
                var loai = loaisp.Where(x => x.maloai == item.maloai).FirstOrDefault();
                ViewBag.loaigiay = loai.tenloai;
            }

            var nhacc = obj.Getallnhacungcap();
            foreach (var item in ctsp)
            {
                var nhacungcap = nhacc.Where(x => x.manhacungcap == item.manhacungcap).FirstOrDefault();
                ViewBag.nhacungcap = nhacungcap.tennhacungcap;
            }


       //     ViewBag.het = "Hết";
        //    ViewBag.con = "Còn hàng";
            return View(ctsp);            
        }

        public ActionResult DanhMucSP()
        {
            return PartialView(obj.Getallloaisanpham());
        }

        public ActionResult TimKiem()
        {
            var loaisp = obj.Getallloaisanpham();
            return PartialView(loaisp.ToList());
        }

        public ActionResult LietKeSP(string ma, int page=1)
        {
            var sp = obj.Getallsanpham_coan();
            ViewBag.ma = ma;
            var sanpham = (from p in sp where p.maloai == ma select p).ToList();
            ViewBag.TotalPages = Math.Ceiling((double)sanpham.Count / size);
            return View(sanpham.Skip((page - 1) * size).Take(size));
        }

        public ActionResult TimKiemCB(string chuoitk, int page = 1)
        {
            var sp = obj.Getallsanpham_coan();

            ViewBag.chuoitk = chuoitk;

            var sanpham = (from s in sp
                           where s.tensanpham.ToLower().Contains(chuoitk.Trim()) 
                           select s).ToList();
            ViewBag.TotalPages = Math.Ceiling((double)sanpham.Count / size);
            return View(sanpham.Skip((page - 1) * size).Take(size));
        }

        public ActionResult TimKiemNC(string loaihang, string giatu, string giaden, string chuoitk, int page = 1)
        {
            var sp = obj.Getallsanpham_coan();
            try
            {
                ViewBag.loaihang = loaihang;
                ViewBag.giaden = giaden;
                ViewBag.giatu = giatu;
                ViewBag.chuoitk = chuoitk;
                if (chuoitk == "")
                {
                    if (loaihang == "")
                    {
                        if (giatu == "" && giaden == "")
                        {
                            var findpro = sp.ToList();
                            ViewBag.TotalPages = Math.Ceiling((double)findpro.Count / size);
                            return View(findpro.Skip((page - 1) * size).Take(size));
                        }
                        if (giatu == "" && giaden != "")
                        {

                            long _giaden = long.Parse(giaden);
                            var findpro = (from s in sp where s.giasanpham <= _giaden select s).ToList();
                            ViewBag.TotalPages = Math.Ceiling((double)findpro.Count / size);
                            return View(findpro.Skip((page - 1) * size).Take(size));
                        }
                        if (giaden == "" && giatu != "")
                        {
                            long _giatu = long.Parse(giatu);

                            var findpro = (from s in sp where s.giasanpham >= _giatu select s).ToList();
                            ViewBag.TotalPages = Math.Ceiling((double)findpro.Count / size);
                            return View(findpro.Skip((page - 1) * size).Take(size));
                        }
                        if (giatu != "" && giaden != "")
                        {
                            long _giatu = long.Parse(giatu);
                            long _giaden = long.Parse(giaden);
                            var findpro = (from s in sp where s.giasanpham >= _giatu && s.giasanpham <= _giaden select s).ToList();
                            ViewBag.TotalPages = Math.Ceiling((double)findpro.Count / size);
                            return View(findpro.Skip((page - 1) * size).Take(size));
                        }
                    }
                    else
                    {
                        if (giatu == "" && giaden == "")
                        {
                            var findpro = (from s in sp where s.maloai == loaihang select s).ToList();
                            ViewBag.TotalPages = Math.Ceiling((double)findpro.Count / size);
                            return View(findpro.Skip((page - 1) * size).Take(size));
                        }
                        if (giatu == "" && giaden != "")
                        {

                            long _giaden = long.Parse(giaden);
                            var findpro = (from s in sp where s.giasanpham <= _giaden && s.maloai == loaihang select s).ToList();
                            ViewBag.TotalPages = Math.Ceiling((double)findpro.Count / size);
                            return View(findpro.Skip((page - 1) * size).Take(size));
                        }
                        if (giaden == "" && giatu != "")
                        {
                            long _giatu = long.Parse(giatu);

                            var findpro = (from s in sp where s.giasanpham >= _giatu && s.maloai == loaihang select s).ToList();
                            ViewBag.TotalPages = Math.Ceiling((double)findpro.Count / size);
                            return View(findpro.Skip((page - 1) * size).Take(size));
                        }
                        if (giatu != "" && giaden != "")
                        {
                            long _giatu = long.Parse(giatu);
                            long _giaden = long.Parse(giaden);
                            var findpro = (from s in sp where s.giasanpham >= _giatu && s.giasanpham <= _giaden && s.maloai == loaihang select s).ToList();
                            ViewBag.TotalPages = Math.Ceiling((double)findpro.Count / size);
                            return View(findpro.Skip((page - 1) * size).Take(size));
                        }
                    }
                }
                else
                {
                    if (loaihang == "")
                    {
                        if (giatu == "" && giaden == "")
                        {
                            var findpro = (from s in sp where s.tensanpham.ToLower().Contains(chuoitk.Trim()) select s).ToList();
                            ViewBag.TotalPages = Math.Ceiling((double)findpro.Count / size);
                            return View(findpro.Skip((page - 1) * size).Take(size));
                        }
                        if (giatu == "" && giaden != "")
                        {

                            long _giaden = long.Parse(giaden);
                            var findpro = (from s in sp where s.tensanpham.Contains(chuoitk) && s.giasanpham <= _giaden select s).ToList();
                            ViewBag.TotalPages = Math.Ceiling((double)findpro.Count / size);
                            return View(findpro.Skip((page - 1) * size).Take(size));
                        }
                        if (giaden == "" && giatu != "")
                        {
                            long _giatu = long.Parse(giatu);

                            var findpro = (from s in sp where s.tensanpham.Contains(chuoitk) && s.giasanpham >= _giatu select s).ToList();
                            ViewBag.TotalPages = Math.Ceiling((double)findpro.Count / size);
                            return View(findpro.Skip((page - 1) * size).Take(size));
                        }
                        if (giatu != "" && giaden != "")
                        {
                            long _giatu = long.Parse(giatu);
                            long _giaden = long.Parse(giaden);
                            var findpro = (from s in sp where s.tensanpham.Contains(chuoitk) && s.giasanpham >= _giatu && s.giasanpham <= _giaden select s).ToList();
                            ViewBag.TotalPages = Math.Ceiling((double)findpro.Count / size);
                            return View(findpro.Skip((page - 1) * size).Take(size));
                        }
                    }
                    else
                    {
                        if (giatu == "" && giaden == "")
                        {
                            var findpro = (from s in sp where s.tensanpham.Contains(chuoitk) && s.maloai == loaihang select s).ToList();
                            ViewBag.TotalPages = Math.Ceiling((double)findpro.Count / size);
                            return View(findpro.Skip((page - 1) * size).Take(size));
                        }
                        if (giatu == "" && giaden != "")
                        {

                            long _giaden = long.Parse(giaden);
                            var findpro = (from s in sp where s.tensanpham.Contains(chuoitk) && s.giasanpham <= _giaden && s.maloai == loaihang select s).ToList();
                            ViewBag.TotalPages = Math.Ceiling((double)findpro.Count / size);
                            return View(findpro.Skip((page - 1) * size).Take(size));
                        }
                        if (giaden == "" && giatu != "")
                        {
                            long _giatu = long.Parse(giatu);

                            var findpro = (from s in sp where s.tensanpham.Contains(chuoitk) && s.giasanpham >= _giatu && s.maloai == loaihang select s).ToList();
                            ViewBag.TotalPages = Math.Ceiling((double)findpro.Count / size);
                            return View(findpro.Skip((page - 1) * size).Take(size));
                        }
                        if (giatu != "" && giaden != "")
                        {
                            long _giatu = long.Parse(giatu);
                            long _giaden = long.Parse(giaden);
                            var findpro = (from s in sp where s.tensanpham.Contains(chuoitk) && s.giasanpham >= _giatu && s.giasanpham <= _giaden && s.maloai == loaihang select s).ToList();
                            ViewBag.TotalPages = Math.Ceiling((double)findpro.Count / size);
                            return View(findpro.Skip((page - 1) * size).Take(size));
                        }
                    }
                }
                return View();
            }
            catch
            {
                var findpro = sp.Take(0);
                return View(findpro.Skip((page - 1) * size).Take(size));
            }
        }
    }
}
