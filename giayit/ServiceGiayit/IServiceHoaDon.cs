using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceGiayit
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceHoaDon" in both code and config file together.
    [ServiceContract]
    public interface IServiceHoaDon
    {
        [OperationContract]
        bool editdonhang(string mahd, string tinhtrang);

        [OperationContract]
        List<hoadon> Getallhoadon();

        [OperationContract]
        void themhoadon(int mahoadon, string tenkh, string diachi, string sdt, string makh, string email, int tongtien);

        [OperationContract]
        List<hoadon> Select_hoadon_theonam(int nam);

        [OperationContract]
        float laytongtientheothang(int thang, List<hoadon> dshd);

        [OperationContract]
        List<hoadon> Select_hoadon_theothang(int thang, int nam);

        [OperationContract]
        float laytongtientheongay(int ngay, List<hoadon> dshd);
    }
}
