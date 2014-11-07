using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceGiayit
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicePhieuNhap" in both code and config file together.
    public class ServicePhieuNhap : IServicePhieuNhap
    {
        giayitEntities db = new giayitEntities();


        public List<phieunhap> getallphieunhap()
        {
            var lstpn = new List<phieunhap>();

            var dspn = from n in db.phieunhaps select n;
            foreach (phieunhap pn in dspn)
            {
                phieunhap lst = new phieunhap()
                {
                    maphieunhap=pn.maphieunhap,
                    nguoinhap=pn.nguoinhap,
                    ngaynhap=pn.ngaynhap,
                    tongtien=pn.tongtien
                };
                lstpn.Add(lst);
            }

            return lstpn;
        }


        public List<phieunhap> Select_phieunhap_theonam(int nam)
        {
            var dspn = getallphieunhap();
            dspn = (from phn in dspn
                    where DateTime.Parse(phn.ngaynhap.ToString()).Year == nam
                    select phn).ToList();
            return dspn;
        }


        public float laytongtientheothang(int thang, List<phieunhap> dspn)
        {            
            float tong = 0;
            dspn = (from d in dspn
                    where DateTime.Parse(d.ngaynhap.ToString()).Month == thang
                    select d).ToList();
            foreach (phieunhap pn in dspn)
            {
                tong += int.Parse(pn.tongtien.ToString());
            }
            return tong;
        }

        

        public List<phieunhap> Select_phieunhap_theothang(int thang, int nam)
        {
            var dspn = getallphieunhap();
            dspn = (from phn in dspn
                    where DateTime.Parse(phn.ngaynhap.ToString()).Month == thang
                    && DateTime.Parse(phn.ngaynhap.ToString()).Year == nam
                    select phn).ToList();
            return dspn;
        }


        public float laytongtientheongay(int ngay, List<phieunhap> dspn)
        {            
            float tong = 0;
            dspn = (from d in dspn
                    where DateTime.Parse(d.ngaynhap.ToString()).Day == ngay
                    select d).ToList();
            foreach (phieunhap pn in dspn)
            {
                tong += int.Parse(pn.tongtien.ToString());
            }
            return tong;
        }
        //ham them phieu nhap
        public bool Thempn(string nguoinhap, DateTime ngaynhap, int tongtien)
        {
            var _sp = (from s in db.phieunhaps orderby s.maphieunhap descending select s).FirstOrDefault();
            int _stt = _sp.maphieunhap;
            _stt++;
            phieunhap pn = new phieunhap();
            try
            {
                pn.maphieunhap = _stt;
                pn.nguoinhap = nguoinhap;
                pn.ngaynhap = ngaynhap;
                pn.tongtien = tongtien;
                db.phieunhaps.Add(pn);
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
