using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceGiayit
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceAccount" in both code and config file together.
    public class ServiceAccount : IServiceAccount
    {

        giayitEntities db = new giayitEntities();
        private List<user> lstUser;
        public List<user> GetAllTaiKhoan()
        {
            lstUser = new List<user>();

            var account = from n in db.users select n;
            foreach (user lac in account)
            {
                user lst = new user()
                {
                    makhachhang = lac.makhachhang,
                    tenkhachhang = lac.tenkhachhang,
                    password = lac.password,
                    ngaysinh = lac.ngaysinh,
                    gioitinh = lac.gioitinh,
                    sdt = lac.sdt,
                    diachi = lac.diachi,
                    email = lac.email,
                    maphanquyen = lac.maphanquyen,
                    ghichu = lac.ghichu
                };
                lstUser.Add(lst);
            }

            return lstUser;
        }

        public List<user> Getalluser()
        {
            var lstuser = new List<user>();

            var danhmuc = from n in db.users select n;
            foreach (user lsp in danhmuc)
            {
                user lst = new user()
                {
                    makhachhang = lsp.makhachhang,
                    diachi = lsp.diachi,
                    email = lsp.email,
                    ghichu = lsp.ghichu,
                    ngaysinh = lsp.ngaysinh,
                    sdt = lsp.sdt,
                    password = lsp.password,
                    tenkhachhang = lsp.tenkhachhang
                };
                lstuser.Add(lst);
            }

            return lstuser;
        }

        public void AddAccount(string username, string password, string hoten, int gioitinh, string sdt, string diachi, string email)
        {
            user hk = new user();
            hk.makhachhang = username;
            hk.password = password;
            hk.tenkhachhang = hoten;
            hk.gioitinh = gioitinh;
            hk.ngaysinh = DateTime.Now;
            hk.sdt = sdt;
            hk.diachi = diachi;
            hk.email = email;
            hk.maphanquyen = 1;
            hk.ghichu = "1";
            db.users.Add(hk);
            db.SaveChanges();
        }

        public bool deleteuser(string makh)
        {
            var acticle = db.users.Where(m => m.makhachhang.Trim() == makh.Trim()).SingleOrDefault();
            try
            {
                db.users.Remove(acticle);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool edituser(string makh, string password, string hoten, string sdt, string diachi, string email, string ghichu)
        {
            var n = db.users.First(m => m.makhachhang == makh);
            try
            {
                n.makhachhang = makh;
                n.tenkhachhang = hoten;
                n.password = password;
                n.sdt = sdt;
                n.diachi = diachi;
                n.ngaysinh = n.ngaysinh;
                n.email = email;
                n.gioitinh = 1;
                n.ghichu = ghichu;
                n.maphanquyen = 1;
                //   UpdateModel(n);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool ChangePassword(string makh, string matkhaucu, string matkhaumoi)
        {
            var n = (from s in db.users where s.password == matkhaucu && s.makhachhang == makh select s).FirstOrDefault();
            try
            {
                n.password = matkhaumoi;

                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ChangeInformationAccount(string makh, string hoten, string diachi, int gioitinh, string sdt, string email)
        {
            var n = (from s in db.users where s.makhachhang == makh select s).FirstOrDefault();
            try
            {
                n.tenkhachhang = hoten;
                n.diachi = diachi;
                n.sdt = sdt;
                n.email = email;
                n.gioitinh = gioitinh;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
