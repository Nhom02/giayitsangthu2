using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace giayit.Controllers
{
    public class HomeController : Controller
    {
        ServiceReferenceSanPham.ServiceSanPhamClient obj = new ServiceReferenceSanPham.ServiceSanPhamClient();
        public ActionResult Index()
        {
            var sp = obj.Getallsanpham_coan().OrderByDescending(x => x.stt).Take(6).ToList(); ;
            return View(sp);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
