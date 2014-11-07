using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceGiayit
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceTonKho" in both code and config file together.
    [ServiceContract]
    public interface IServiceTonKho
    {
        [OperationContract]
        List<tonkho> getalltonkho();

        [OperationContract]
        List<tonkho> getalltonkholoc(DateTime time);

        [OperationContract]
        List<tonkho> Select_tonkho(DateTime ngay, string maloai);

        [OperationContract]
        List<tonkho> Select_tonkho_theosanpham(DateTime ngay, string masp);

        [OperationContract]
        bool Themtk(string masp, int soluong);

        [OperationContract]
        bool giamtk(string masp, int soluong);

        [OperationContract]
        bool Trusoluongkhidathang(string mahd);

        [OperationContract]
        bool Them(string masp);
    }

    
}
