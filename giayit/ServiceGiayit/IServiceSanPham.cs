using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceGiayit
{
    
    [ServiceContract]
    public interface IServiceSanPham
    {
        
        [OperationContract]
        List<loaisanpham> Getallloaisanpham();

        [OperationContract]
        List<sanpham> Getallsanpham();

        [OperationContract]
        List<sanpham> Getallsanpham_coan();

        [OperationContract]
        List<nhacungcap> Getallnhacungcap();

        [OperationContract]
        List<admin> Getalladmin();       


        [OperationContract]
        bool themsp(string maloai, string tensp, string chatlieu, int gia, string mota, int sl, string hinhanh);

        [OperationContract]
        bool deletesp(string masp);

        [OperationContract]
        bool kichhoat(string masp);

        [OperationContract]
        bool editsp(string id, string tensp, string chatlieu, string gia, string mota, string sl, string _hinhanh, string loaisp, string _url);

        [OperationContract]
        sanpham getsanpham(string masanpham);

        [OperationContract]
        bool editslsp(string masp,int soluong);


        [OperationContract]
        bool editslspgiam(string masp, int soluong);
        
    }
}
