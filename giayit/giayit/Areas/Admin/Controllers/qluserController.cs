using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace giayit.Areas.Admin.Controllers
{
    public class qluserController : Controller
    {
        //
        // GET: /Admin/qluser/
        int size = 9;
        ServiceReferenceAccount.ServiceAccountClient db = new ServiceReferenceAccount.ServiceAccountClient();
        [ChildActionOnly]
        public ActionResult menunguoidung()
        {
            var danhmuc = (from p in db.GetAllTaiKhoan() select p).ToList();
            ViewBag.dem = danhmuc.Count;
            return PartialView();
        }
        public ActionResult Index(string ma, int page = 1)
        {
            if (Session["admin"] != null)
            {
                ViewBag.ma = ma;
                var user = (from s in db.GetAllTaiKhoan() select s).ToList();
                ViewBag.TotalPages = Math.Ceiling((double)user.Count / size);
                return View(user.Skip((page - 1) * size).Take(size));
            }
            else
            {
                return RedirectToAction("../admin/index");
            }
        }
        public ActionResult edit(string ma)
        {
            if (Session["admin"] != null)
            {
                var us = (from s in db.GetAllTaiKhoan() where s.makhachhang.Trim() == ma.Trim() select s).ToList();
                return View(us);
            }
            return RedirectToAction("../admin/index");
        }
        [HttpPost]
        public ActionResult edit(string makh, string password, string hoten, string sdt, string diachi, string email, string ghichu)
        {

            if (db.edituser(makh, password, hoten, sdt, diachi, email, ghichu))
            {
                TempData["message"] = string.Format("{0} sửa thành công ", makh);
                return RedirectToAction("../qluser/index"); 
            }
            else
            {
                TempData["message"] = string.Format("{0} sửa thất bại ", makh);
                return RedirectToAction("../qluser/index"); 
            }

        }
        public ActionResult delete(string id)
        {
            if (db.deleteuser(id))
            {
                TempData["message"] = string.Format("xóa thành công ");
                return RedirectToAction("../qluser/index");
            }
            else
            {
                TempData["message"] = string.Format("xóa thất bại ");
                return RedirectToAction("../qluser/index");
            }
        }

    }
}
