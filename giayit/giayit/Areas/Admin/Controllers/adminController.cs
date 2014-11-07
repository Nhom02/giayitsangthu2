using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace giayit.Areas.Admin.Controllers
{
    public class adminController : Controller
    {

        ServiceReferenceSanPham.ServiceSanPhamClient ad = new ServiceReferenceSanPham.ServiceSanPhamClient();
        //
        // GET: /Admin/admin/

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string username, string password)
        {

            var db = (from s in ad.Getalladmin()  where s.username.Trim() == username.Trim() && s.password.Trim()==password.Trim() select s).ToList();
            if (db.Count >= 1)
            {
                Session["admin"] = username;
                return RedirectToAction("quanly");
            }
            else
            {
                TempData["message"] = string.Format("Tên đăng nhập hoặc mật khẩu không đúng");
                return RedirectToAction("index", "admin");
            }
        }

        public ActionResult LogOff()
        {
            Session.Timeout = 10;
            Session["admin"] = null;
            return RedirectToAction("index","admin");
        }

        public ActionResult quanly()
        {

            return View();
        }

       
    }
}
