using giayit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace giayit.Controllers
{
    public class GioHangController : Controller
    {
        ServiceReferenceSanPham.ServiceSanPhamClient obj = new ServiceReferenceSanPham.ServiceSanPhamClient();
        ServiceReferenceAccount.ServiceAccountClient ac = new ServiceReferenceAccount.ServiceAccountClient();

        public ActionResult Index()
        {
            return View(new dsgiohang
            {
                Cart = layds()
            });
        }

        public ActionResult GioHang()
        {
            return PartialView(new dsgiohang { Cart = layds() });
        }

        public ActionResult ThanhToan()
        {
            if (Session["Account"] != null)
            {
                string makh = Session["Account"].ToString();
                var kh = (from s in ac.GetAllTaiKhoan() where s.makhachhang.Trim() == makh select s).FirstOrDefault();

                ViewBag.tenkh = kh.tenkhachhang;
                ViewBag.diachi = kh.diachi;
                ViewBag.sdt = kh.sdt.ToString();
                ViewBag.email = kh.email;

            }
            else
            {
                ViewBag.tenkh = "";
                ViewBag.diachi = "";
                ViewBag.email = "";
                ViewBag.sdt = "";
            }
            return View(new dsgiohang
            {
                Cart = layds()
            });
        }

        [HttpPost]
        public ActionResult thanhtoan(string tenkh, string diachi, string sdt, string email)
        {
            string makh;
            if (Session["Account"] != null)
            {
                makh = Session["Account"].ToString();
            }
            else
            {
                makh = null;
            }
            layds().themhoadon(tenkh, diachi, sdt, makh, email);
            return RedirectToAction("../home/index");

        }

        public RedirectToRouteResult giohangthem(string masanpham, int soluong = 1)
        {

            var sp = obj.Getallsanpham_coan();
            foreach (var item in sp)
            {
                if (item.masanpham == masanpham)
                    layds().AddItem(item.masanpham, item.tensanpham, soluong, item.giasanpham, item.hinhanh, item.motasanpham, item.soluongcon);
            }
            return RedirectToAction("Index");
        }

        public RedirectToRouteResult giohangxoa(string masanpham)
        {
            layds().RemoveLine(masanpham);
            return RedirectToAction("Index");
        }

        public RedirectToRouteResult xoahet()
        {
            layds().xoahet();
            return RedirectToAction("Index");
        }

        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }

        public RedirectToRouteResult capnhatsoluong(string masanpham, string soluong, int soluongcon)
        {
            if (IsNumber(soluong))
            {
                if (int.Parse(soluong) <= soluongcon & int.Parse(soluong) > 0)
                {
                    layds().capnhatsoluong(masanpham, int.Parse(soluong));
                }
                else
                {
                    layds().capnhatsoluong(masanpham, 1);
                    TempData["message"] = string.Format("Số lượng sản phẩm đặt hàng phải nhỏ hơn hoặc bằng {0} ", soluongcon);
                }
            }
            else
            {
                layds().capnhatsoluong(masanpham, 1);
                TempData["message"] = string.Format("Số lượng là kiểu số và là số lớn hơn 0");
            }

            return RedirectToAction("Index");
        }

        private giohang layds()
        {
            giohang cart = (giohang)Session["Cart"];
            if (cart == null)
            {
                cart = new giohang();
                Session["Cart"] = cart;
            }
            return cart;
        }
    }
}
