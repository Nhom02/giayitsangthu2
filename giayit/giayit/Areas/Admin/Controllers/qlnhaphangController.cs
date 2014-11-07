using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace giayit.Areas.Admin.Controllers
{
    public class qlnhaphangController : Controller
    {
        //
        // GET: /Admin/qlnhaphang/
        ServiceReferencePhieuNhap.ServicePhieuNhapClient db = new ServiceReferencePhieuNhap.ServicePhieuNhapClient();
        public ActionResult Index()
        {
            var list = (from p in db.Getallphieunhap() select p).ToList();
            return View(list);
        }
        [ChildActionOnly]
        public ActionResult menunhaphang()
        {
            return PartialView();
        }
    }
}
