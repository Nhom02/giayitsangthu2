using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceGiayit
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceChiTietPhieuNhap" in both code and config file together.
    [ServiceContract]
    public interface IServiceChiTietPhieuNhap
    {

        [OperationContract]
        List<chitietphieunhap> getallchitietphieunhap();

        [OperationContract]
        List<chitietphieunhap> Select_chitietphieunhap_theonam(int nam);

        [OperationContract]
        int laysoluongtheothang(int thang, List<chitietphieunhap> dsctpn);

        [OperationContract]
        List<chitietphieunhap> Select_chitietphieunhap_theothang(int thang, int nam);

        [OperationContract]
        int laysoluongtheongay(int ngay, List<chitietphieunhap> dsctpn);

        [OperationContract]
        bool Themctpn(int maphieunhap, string masanpham, int gia, int soluong);


    }
}
