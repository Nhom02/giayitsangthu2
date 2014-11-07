using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace giayit.Areas.Admin.Controllers
{
    public class qlsanphamController : Controller
    {
        //
        // GET: /Admin/qlsanpham/
        ServiceReferenceSanPham.ServiceSanPhamClient db = new ServiceReferenceSanPham.ServiceSanPhamClient();
        ServiceReferenceTonKho.ServiceTonKhoClient tk = new ServiceReferenceTonKho.ServiceTonKhoClient();

        public string _tenloai;
        public string _url;
        int size = 6;
        
        [ChildActionOnly]
        public ActionResult qlsanpham()
        {

            ViewBag.count = db.Getallsanpham().Count();
            return PartialView();
        }
        public ActionResult index(string tensanpham, string ma, int page = 1)
        {
            if (Session["admin"] != null)
            {
                ViewBag.ma = ma;
                ViewBag.Search = tensanpham;
                var sanpham = (from p in db.Getallsanpham() orderby p.stt descending select p).ToList();
                if (!String.IsNullOrEmpty(tensanpham))
                {
                    sanpham = db.Getallsanpham().Where(s => s.tensanpham.ToLower().Contains(tensanpham.Trim())).ToList();
                    
                }
                ViewBag.TotalPages = Math.Ceiling((double)sanpham.Count / size);
                return View(sanpham.Skip((page - 1) * size).Take(size));
            }
            else
            {
                return RedirectToAction("../admin/index");
            }
        }

        public ActionResult themsp()
        {
            if (Session["admin"] != null)
            {
                var loaisp = (from s in db.Getallloaisanpham() select s).ToList();
                return View(loaisp);
            }
            return RedirectToAction("../admin/index");
        }
        [HttpPost]
        public ActionResult themsp(HttpPostedFileBase file, string loaihang, string tensp, string chatlieu, string gia, string mota, string sl)
        {

            if (file != null && file.ContentLength > 0 && loaihang != null && tensp != null && chatlieu != null && gia != null && mota != null && sl != null)
            {
                var loaisp = (from s in db.Getallloaisanpham() where s.maloai == loaihang select s).ToList();
                foreach (var item in loaisp)
                {
                    _tenloai = item.tenloai;
                }

                string hinhanh = file.FileName.ToString();
                string url = "image/giay" + "/" + _tenloai + "/" + hinhanh;

                // extract only the fielname
                var fileName = Path.GetFileName(file.FileName);
                // store the file inside ~/App_Data/uploads folder
                var path = Path.Combine(Server.MapPath("~/image/giay/" + _tenloai + ""), fileName);
                file.SaveAs(path);
                //return RedirectToAction("../home/index");    
                if (db.themsp(loaihang, tensp, chatlieu, int.Parse(gia), mota, int.Parse(sl), url))
                {
                    tk.Them(tensp);
                    TempData["message"] = string.Format("{0} thêm thành công ", tensp);
                    return RedirectToAction("../qlsanpham/index"); }
                else
                {
                    TempData["message"] = string.Format("{0} thêm thất bại ", tensp);
                    return RedirectToAction("../qlsanpham/index");
                }

            }
            // redirect back to the index action to show the form once again
            return RedirectToAction("../admin/quanly");
        }
        public ActionResult delete(string id)
        {
            if (db.deletesp(id))
            {
                TempData["message"] = string.Format(" xóa thành công ");
                return RedirectToAction("../qlsanpham/index"); 
            }
            else
            {
                TempData["message"] = string.Format(" xóa thất bại ");
                return RedirectToAction("../qlsanpham/index"); 
            }

        }
        public ActionResult kichhoat(string id)
        {
            if (db.kichhoat(id))
            {
                TempData["message"] = string.Format(" kích hoạt thành công ");
                return RedirectToAction("../qlsanpham/index");
            }
            else
            {
                TempData["message"] = string.Format(" kích hoạt thất bại ");
                return RedirectToAction("../qlsanpham/index");
            }

        }
        public ActionResult edit(string id)
        {
            if (Session["admin"] != null)
            {
                var sp = (from s in db.Getallsanpham() where s.masanpham == id select s).ToList();
                ViewBag.loaisanpham = (from s in db.Getallloaisanpham() select s).ToList();
                return View(sp);
            }
            return RedirectToAction("../admin/index");
        }
        [HttpPost]
        public ActionResult edit(string id, HttpPostedFileBase file, string tensp, string chatlieu, string gia, string mota, string sl, string _hinhanh, string loaisp)
        {
            var _loaisp = (from s in db.Getallloaisanpham() where s.maloai == loaisp select s).FirstOrDefault();

            _tenloai = _loaisp.tenloai;

            if (file != null && file.ContentLength > 0)
            {
                string hinhanh = file.FileName.ToString();
                _url = "image/giay" + "/" + _tenloai + "/" + hinhanh;
                var fileName = Path.GetFileName(file.FileName);
                // store the file inside ~/App_Data/uploads folder
                var path = Path.Combine(Server.MapPath("~/image/giay/" + _tenloai + ""), fileName);
                file.SaveAs(path);
            }
            else
            { _url = _hinhanh; }
            if (db.editsp(id, tensp, chatlieu, gia, mota, sl, _url, loaisp, _url))
            {
                TempData["message"] = string.Format("{0} sửa thành công ", tensp);
                return RedirectToAction("../qlsanpham/index");
            }
            else
            {
                TempData["message"] = string.Format("{0} sửa thất bại ", tensp);
                return RedirectToAction("../admin/quanly");
            }

        }
    }
}
