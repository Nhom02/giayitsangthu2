using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceGiayit
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceAccount" in both code and config file together.
    [ServiceContract]
    public interface IServiceAccount
    {
        [OperationContract]
        List<user> GetAllTaiKhoan();

        [OperationContract]
        List<user> Getalluser();

        [OperationContract]
        void AddAccount(string username, string password, string hoten, int gioitinh, string sdt, string diachi, string email);

        [OperationContract]
        bool edituser(string makh, string password, string hoten, string sdt, string diachi, string email, string ghichu);

        [OperationContract]
        bool deleteuser(string makh);

        [OperationContract]
        bool ChangePassword(string makh, string matkhaucu, string matkhaumoi);

        [OperationContract]
        bool ChangeInformationAccount(string makh, string hoten, string diachi, int gioitinh, string sdt, string email);

    }
}
