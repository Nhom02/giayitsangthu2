using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceGiayit
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicePhieuNhap" in both code and config file together.
    [ServiceContract]
    public interface IServicePhieuNhap
    {
        [OperationContract]
        List<phieunhap> getallphieunhap();

        [OperationContract]
        List<phieunhap> Select_phieunhap_theonam(int nam);

        [OperationContract]
        float laytongtientheothang(int thang, List<phieunhap> dspn);

        [OperationContract]
        List<phieunhap> Select_phieunhap_theothang(int thang, int nam);

        [OperationContract]
        float laytongtientheongay(int ngay, List<phieunhap> dspn);

        [OperationContract]
        bool Thempn(string nguoinhap, DateTime ngaynhap, int tongtien);
    }
}
