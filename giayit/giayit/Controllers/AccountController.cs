using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using giayit.Models;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Net;

namespace giayit.Controllers
{
    public class AccountController : Controller
    {

        ServiceReferenceAccount.ServiceAccountClient obj = new ServiceReferenceAccount.ServiceAccountClient();

        public ActionResult LogIn()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult LogIn(string username, string password, string url)
        {
            var tk = obj.GetAllTaiKhoan();

            var acc = (from s in tk where s.makhachhang.Trim() == username && s.password.Trim() == password select s).ToList();
            if (acc.Count >= 1)
            {

                Session["Account"] = username;
                return Redirect(url);
            }
            else
            {

                return RedirectToAction("DnSai");
            }
        }

        public ActionResult Dangky(string chuoitb)
        {
            if (Session["Account"] == null)
            {
                ViewBag.chuoitb = chuoitb;
                return View();
            }
            else
            {
                return RedirectToAction("../home/index");
            }
        }

        [HttpPost]
        public ActionResult Dangky(string username, string password, string hoten, int gioitinh, string sdt, string diachi, string email)
        {
            try
            {
                var tk = obj.GetAllTaiKhoan();

                var acc = (from s in tk where s.makhachhang.Trim() == username select s).ToList();
                if (acc.Count >= 1)
                {
                    return RedirectToAction("DangKy", new { chuoitb = "Tên đăng nhập đã tồn tại !" });
                }
                else
                {
                    obj.AddAccount(username, password, hoten, gioitinh, sdt, diachi, email);
                    string chuoi = "Xin chào "+hoten+"\n"+"Bạn đã đăng kí thành công tài khoản của GiayiT với thông tin: \n";
                    chuoi += "Tên đăng nhâp: "+username+ " mật khẩu:"+password;
                    MailMessage msg = new MailMessage();
                    msg.From = new MailAddress("nddung1412@gmail.com");
                    msg.To.Add(email);
                    msg.Subject = "Đăng kí tài khoản thành công tại giayiT";
                    msg.Body = chuoi;

                    SmtpClient smtp = new SmtpClient();
                    smtp.Credentials = new NetworkCredential("nddung1412@gmail.com", "dungduan");
                    smtp.Port = 587;
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    smtp.Send(msg);         
                    return RedirectToAction("DkThanhCong", new { makh = username });
                }
            }
            catch
            {

                return RedirectToAction("DangKy", new { chuoitb = "Tên đăng nhập đã tồn tại !" });
            }

        }

        

        public ActionResult DnSai()
        {
            if (Session["Account"] == null)
            {

                return View();
            }
            else
            {
                return RedirectToAction("../home/index");
            }

        }
        [HttpPost]
        public ActionResult DnSai(string takmail)
        {
            var mk = obj.GetAllTaiKhoan().Where(x => x.email == takmail).FirstOrDefault();
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("nddung1412@gmail.com");
            msg.To.Add(takmail);
            msg.Subject = "Giầy IT: Lấy lại mật khẩu";
            msg.Body = mk.password;

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential("nddung1412@gmail.com", "dungduan");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.Send(msg);         
            return RedirectToAction("index", "home");

        }
        public ActionResult LogOff()
        {
            Session.Timeout = 10;
            Session["Account"] = null;
            return RedirectToAction("Index", "Home");
        }

        public ActionResult DkThanhCong(string makh)
        {
            ViewBag.makh = makh;
            return View();
        }

        public ActionResult DoiMk(string ma)
        {
            try
            {
                string user = Session["Account"].ToString();
                var us = (from s in obj.GetAllTaiKhoan() where s.makhachhang.Trim() == user select s).ToList();
                ViewBag.ma = ma;
                return View(us);
            }
            catch
            {
                return RedirectToAction("../home/index");
            }
        }

        [HttpPost]
        public ActionResult DoiMk(string mkcu, string mkmoi)
        {
            if (mkcu != "" && mkmoi != "")
            {
                
                try
                {
                    string makh = Session["Account"].ToString();

                    if (obj.ChangePassword(makh, mkcu, mkmoi))
                    {

                        return RedirectToAction("../account/doimk", new { ma = 3 });
                    }
                    else
                    {
                        return View();
                    }
                }
                catch
                {
                    return RedirectToAction("../account/doimk", new { ma = 1 });
                }
            }

            return RedirectToAction("../account/doimk", new { ma = 3 });
        }

        public ActionResult thaydoithongtin(string ma)
        {
            try
            {
                string user = Session["Account"].ToString();
                var us = (from s in obj.GetAllTaiKhoan() where s.makhachhang.Trim() == user select s).FirstOrDefault();
                ViewBag.ma = ma;
                return View(us);
            }
            catch
            {
                return RedirectToAction("../home/index");
            }
        }

        [HttpPost]
        public ActionResult thaydoithongtin(string hoten, string diachi, string sdt, int gioitinh, string email)
        {
            if (Session["Account"] != null)
            {
                string user = Session["Account"].ToString();
                if (hoten != "" && diachi != "" && sdt != "" && email != "")
                {
                    //      try
                    //          {
                    var us = (from s in obj.GetAllTaiKhoan() where s.makhachhang.Trim() == user select s).FirstOrDefault();
                    if (obj.ChangeInformationAccount(user, hoten, diachi, gioitinh, sdt, email))
                    {
                        return RedirectToAction("../account/thaydoithongtin", new { ma = 3 });
                    }
                    else
                    {
                        return RedirectToAction("../account/thaydoithongtin", new { ma = 1 });
                    }
                    //        }
                    //      catch
                    //       {
                    //            return RedirectToAction("../account/thaydoithongtin");
                    //        }
                }
            }
            return RedirectToAction("../account/thaydoithongtin");
        }
        

        

    }
}
