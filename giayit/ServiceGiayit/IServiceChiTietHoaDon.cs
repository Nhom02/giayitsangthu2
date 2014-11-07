using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceGiayit
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceChiTietHoaDon" in both code and config file together.
    [ServiceContract]
    public interface IServiceChiTietHoaDon
    {

        [OperationContract]
        List<chitiethoadon> Getallchitiethoadon();

        [OperationContract]
        void themchitiethoadon(int mahoadon, string masp, int soluong, string tensp, int giasp);

        [OperationContract]
        List<chitiethoadon> Select_chitiethoadon_theonam(int nam);

        [OperationContract]
        int laysoluongtheothang(int thang, List<chitiethoadon> dscthd);

        [OperationContract]
        List<chitiethoadon> Select_chitiethoadon_theothang(int thang, int nam);

        [OperationContract]
        int laysoluongtheongay(int ngay, List<chitiethoadon> dscthd);

        [OperationContract]
        List<chitiethoadon> Select_chitiethoadon_theomahd(int mahd);

        [OperationContract]
        bool trusoluongdathang(int mahd);
    }
}
