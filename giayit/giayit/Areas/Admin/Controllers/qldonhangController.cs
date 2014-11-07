using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace giayit.Areas.Admin.Controllers
{
    public class qldonhangController : Controller
    {
        int size = 9;
   
        ServiceReferenceHoaDon.ServiceHoaDonClient db = new ServiceReferenceHoaDon.ServiceHoaDonClient();
        ServiceReferenceChiTietHoaDon.ServiceChiTietHoaDonClient db1 = new ServiceReferenceChiTietHoaDon.ServiceChiTietHoaDonClient();

        public ActionResult menudonhang()
        {
            var danhmuc = (from p in db.Getallhoadon() where p.tinhtrang=="chưa liên lạc" select p).ToList();
            ViewBag.dem = danhmuc.Count;
            return PartialView();
        }
        public ActionResult Index(string ngaytu, string thangtu, string namtu, string ngayden, string thangden, string namden, string trangthai, string ma, /*string sortby,*/ int page = 1, int sortBy = 0, bool isAsc = true)
        {
            if (Session["admin"] != null)
            {
                ViewBag.Trangthai = trangthai;

                ViewBag.Ngaytu = ngaytu;
                ViewBag.Thangtu = thangtu;
                ViewBag.Namtu = namtu;

                ViewBag.Ngayden = ngayden;
                ViewBag.Thangden = thangden;
                ViewBag.Namden = namden;

                var hoadon = from s in db.Getallhoadon() select s;

                if (!String.IsNullOrEmpty(ngaytu) && !String.IsNullOrEmpty(thangtu) && !String.IsNullOrEmpty(namtu))
                {
                    try
                    {
                        DateTime tu = new DateTime(int.Parse(namtu), int.Parse(thangtu), int.Parse(ngaytu));
                        hoadon = from s in db.Getallhoadon()
                                 where s.ngaymuahang >= tu.Date
                                 select s;
                    }
                    catch
                    {
                        TempData["message"] = string.Format("Thời gian không nằm trong lịch hệ thống ");
                        return RedirectToAction("../qldonhang/index");
                    }
                }

                if (!String.IsNullOrEmpty(ngayden) && !String.IsNullOrEmpty(thangden) && !String.IsNullOrEmpty(namden))
                {
                    try
                    {
                        DateTime den = new DateTime(int.Parse(namden), int.Parse(thangden), int.Parse(ngayden));
                        hoadon = from s in db.Getallhoadon()
                                 where s.ngaymuahang <= den.Date
                                 select s;
                    }
                    catch
                    {
                        TempData["message"] = string.Format("Thời gian không nằm trong lịch hệ thống ");
                        return RedirectToAction("../qldonhang/index");
                    }

                }
                if (!String.IsNullOrEmpty(ngaytu) && !String.IsNullOrEmpty(thangtu) && !String.IsNullOrEmpty(namtu) &&
                    !String.IsNullOrEmpty(ngayden) && !String.IsNullOrEmpty(thangden) && !String.IsNullOrEmpty(namden))
                {
                    try
                    {
                        DateTime tu = new DateTime(int.Parse(namtu), int.Parse(thangtu), int.Parse(ngaytu));
                        DateTime den = new DateTime(int.Parse(namden), int.Parse(thangden), int.Parse(ngayden));
                        hoadon = from s in db.Getallhoadon()
                                 where s.ngaymuahang >= tu.Date && s.ngaymuahang <= den.Date
                                 select s;
                    }
                    catch
                    {
                        TempData["message"] = string.Format("Thời gian không nằm trong lịch hệ thống ");
                        return RedirectToAction("../qldonhang/index");
                    }
                }

                if (!String.IsNullOrEmpty(trangthai))
                {
                    hoadon = hoadon.Where(s => s.tinhtrang == trangthai);
                }

                switch (sortBy)
                {
                    case 1:
                        hoadon = isAsc ? hoadon.OrderBy(p => p.tongtien) : hoadon.OrderByDescending(p => p.tongtien);
                        break;
                    case 2:
                        hoadon = isAsc ? hoadon.OrderBy(p => p.ngaymuahang) : hoadon.OrderByDescending(p => p.ngaymuahang);
                        break;
                    case 3:
                        hoadon = isAsc ? hoadon.OrderBy(p => p.tinhtrang) : hoadon.OrderByDescending(p => p.tinhtrang);
                        break;

                }

                ViewBag.SortBy = sortBy;
                ViewBag.IsAsc = isAsc;

                ViewBag.TotalPages = Math.Ceiling((double)hoadon.ToList().Count / size);

                return View(hoadon.ToList().Skip((page - 1) * size).Take(size));
            }
            else
            {
                return RedirectToAction("../admin/index");
            }
                  


        }
        public ActionResult chitiet(int mahd)
        {

            if (Session["admin"] != null)
            {
                var tinhtrang = (from s in db.Getallhoadon() where s.mahoadon == mahd select s).FirstOrDefault();
                ViewBag.chuoi= tinhtrang.tinhtrang;
             

                var hd = (from s in db.Getallhoadon() where s.mahoadon == mahd select s).FirstOrDefault();
                ViewBag.tenkh = hd.tenkhachhang;
                ViewBag.diachi = hd.diachi;
                ViewBag.sdt = hd.sdt;
                ViewBag.email = hd.email;
                var ct = (from s in db1.Getallchitiethoadon() where s.mahoadon == mahd select s).ToList();
                return View(ct);
            }
            else
            {
                return RedirectToAction("../admin/index");
            }
        }
        
        
        public ActionResult edit(string mahd)
        {
            if (Session["admin"] != null)
            {
                int _mahd = int.Parse(mahd);
                var hd = (from s in db.Getallhoadon() where s.mahoadon == _mahd select s).ToList();
                return View(hd);
            }
            return RedirectToAction("../admin/index");
        }
        [HttpPost]
        public ActionResult edit(string mahd, string tinhtrang)
        {

            if (db.editdonhang(mahd, tinhtrang))
            {
                if (tinhtrang=="đã giao")
                {
                    db1.trusoluongdathang(int.Parse(mahd));
                }
                    TempData["message"] = string.Format("{0} sửa thành công ", mahd);
                    return RedirectToAction("../qldonhang/index");
                
            }
            else
            {
                TempData["message"] = string.Format("{0} sửa thất bại ", mahd);
                return RedirectToAction("../qldonhang/index");
            }
        }
    }
}
