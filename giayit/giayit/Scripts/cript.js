// JavaScript Document
function checkdpascu() {
    if (document.fdoimk.mkcu.value == "" || document.fdoimk.mkcu.value == 0) {
        $("pass").html(" Mật khẩu không đc để trống");
        $("rpass").html(""); $("pass1").html("");
        document.images['pass'].src = "";
        document.fdoimk.mkcu.focus();
        return false;
    }
    if (document.fdoimk.mkcu.value.length < 6) {
        $("pass").html(" Mật khẩu phải từ 6 ký tự");
        $("rpass").html(""); $("pass1").html("");
        document.images['pass'].src = "";
        document.fdoimk.mkcu.focus();
        return false;
    }
    else {
        $("pass").html("");
        document.images['pass'].src = "../Image/OK.png";
    }
}
function checkdpasmoi() {
    if (document.fdoimk.mkmoi.value == "" || document.fdoimk.mkmoi.value == 0) {
        $("pass1").html(" Mật khẩu không đc để trống");
        $("rpass").html(""); $("pass").html("");
        document.images['pass1'].src = "";
        document.fdoimk.mkmoi.focus();
        return false;
    }
    if (document.fdoimk.mkmoi.value.length < 6) {
        $("pass1").html(" Mật khẩu phải từ 6 ký tự");
        $("rpass").html(""); $("pass").html("");
        document.images['pass1'].src = "";
        document.fdoimk.mkmoi.focus();
        return false;
    }
    else {
        $("pass1").html("");
        document.images['pass1'].src = "../Image/OK.png";
    }
}
function checkdrpas() {
    if (document.fdoimk.repassword.value == "") {
        $("rpass").html(" Mật khẩu xác nhận không đc để trống");
        $("pass").html(""); $("pass1").html("");
        document.images['rpass'].src = "";
        document.fdoimk.repassword.focus();
        return false;
    }
    if (document.fdoimk.mkmoi.value != document.fdoimk.repassword.value) {
        $("rpass").html(" Mật khẩu xác nhận không trùng khớp ");
        $("pass").html(""); $("pass1").html("");
      //  document.images['rpass'].src = "";
        document.fdoimk.repassword.focus();
        return false;
    } else {
        $("rpass").html("");
        document.images['rpass'].src = "../Image/OK.png";
    }
}
function checktensp() {
    if (document.fthem.tensp.value == "" || document.fthem.tensp.value == 0) {
        $("tensp").html(" Tên sản phẩm không đc để trống");
        $("clieu").html(""); $("gia").html(""); $("sluong").html(""); $("image").html(""); $("loai").html(""); $("mota").html("");
      //  document.images['tensp'].src = "";
        document.fthem.tensp.focus();
        return false;
    } else {
        $("tensp").html("");
        document.images['tensp'].src = "../Image/OK.png";
    }
}
function checkchatlieu() {
    if (document.fthem.chatlieu.value == "" || document.fthem.chatlieu.value == 0) {
        $("clieu").html(" Chất liệu không đc để trống");
        $("tensp").html(""); $("gia").html(""); $("sluong").html(""); $("image").html(""); $("loai").html(""); $("mota").html("");
        document.fthem.chatlieu.focus();
      //  document.images['clieu'].src = "";
        return false;
    } else {
        $("clieu").html("");
        document.images['clieu'].src = "../Image/OK.png";
    }
}
function checkgia() {
    if (document.fthem.gia.value == "" || document.fthem.gia.value == 0) {
        $("gia").html(" Giá sản phẩm không đc để trống");
        $("clieu").html(""); $("tensp").html(""); $("sluong").html(""); $("image").html(""); $("loai").html(""); $("mota").html("");
        document.fthem.gia.focus();
       // document.images['gia'].src = "";
        return false;
    }
    if (isNaN(document.fthem.gia.value) == true) {
        $("gia").html(" Giá sản phẩm phải là số");
        $("clieu").html(""); $("tensp").html(""); $("sluong").html(""); $("image").html(""); $("loai").html(""); $("mota").html("");
        document.fthem.gia.focus();
      //  document.images['gia'].src = "";
        return false;
    } else {
        $("gia").html("");
        document.images['gia'].src = "../Image/OK.png";
    }
}
function checkmota() {
    if (document.fthem.mota.value == "" || document.fthem.mota.value == 0) {
        $("mota").html(" Mô tả sản phẩm không đc để trống");
        $("clieu").html(""); $("gia").html(""); $("sluong").html(""); $("image").html(""); $("loai").html(""); $("tensp").html("");
        document.fthem.mota.focus();
      //  document.images['mota'].src = "";
        return false;
    } else {
        $("mota").html("");
        document.images['mota'].src = "../Image/OK.png";
    }
}
function checksluong() {
    if (document.fthem.sl.value == "") {
        $("sluong").html(" Số lượng sản phẩm không đc để trống");
        $("clieu").html(""); $("gia").html(""); $("tensp").html(""); $("image").html(""); $("loai").html(""); $("mota").html("");
        document.fthem.sl.focus();
        //document.images['sluong'].src = "";
        return false;
    }
    if (isNaN(document.fthem.sl.value) == true) {
        $("sluong").html(" Số lượng sản phẩm phải là số");
        $("clieu").html(""); $("gia").html(""); $("tensp").html(""); $("image").html(""); $("loai").html(""); $("mota").html("");
        document.fthem.sl.focus();
       // document.images['sluong'].src = "";
        return false;
    } else {
        $("sluong").html("");
        document.images['sluong'].src = "../Image/OK.png";
    }
}
function checkID() {
    if (document.fthem.username.value == "" || document.fthem.username.value == 0) {
        $("userID").html(" Tên đăng nhập không đc bỏ trống");
        $("pass").html(""); $("rpass").html(""); $("name").html(""); $("phone").html(""); $("add").html(""); $("mail").html("");
     //   document.images['userID'].src = "";
        document.fthem.username.focus();
        return false;
    }
    if (document.fthem.username.value.length < 6) {
        $("userID").html(" Tên đăng nhập phải từ 6 ký tự");
        $("pass").html(""); $("rpass").html(""); $("name").html(""); $("phone").html(""); $("add").html(""); $("mail").html("");
     //   document.images['userID'].src = "";
        document.fthem.username.focus();
        return false;
    }
    else {
        $("userID").html("");
        document.images['userID'].src = "../Image/OK.png";
    }
}
function checkpasss() {
    if (document.fthem.password.value == "" || document.fthem.password.value == 0) {
        $("pass").html(" Mật khẩu không đc để trống");
        $("userID").html(""); $("rpass").html(""); $("name").html(""); $("phone").html(""); $("add").html(""); $("mail").html("");
     //   document.images['pass'].src = "";
        document.fthem.password.focus();
        return false;
    }
    if (document.fthem.password.value.length < 6) {
        $("pass").html(" Mật khẩu phải từ 6 ký tự");
        $("userID").html(""); $("rpass").html(""); $("name").html(""); $("phone").html(""); $("add").html(""); $("mail").html("");
     //   document.images['pass'].src = "";
        document.fthem.password.focus();
        return false;
    }
    else {
        $("pass").html("");
        document.images['pass'].src = "../Image/OK.png";
    }
}
function checkrpass() {
    if (document.fthem.repassword.value == "") {
        $("rpass").html(" Mật khẩu xác nhận không đc để trống");
        $("pass").html(""); $("userID").html(""); $("name").html(""); $("phone").html(""); $("add").html(""); $("mail").html("");
     //  document.images['rpass'].src = "";
        document.fthem.repassword.focus();
        return false;
    } else {
        $("rpass").html("");
        document.images['rpass'].src = "../Image/OK.png";
    }
    if (document.fthem.password.value != document.fthem.repassword.value) {
        $("rpass").html(" Mật khẩu xác nhận không trùng khớp ");
        $("pass").html(""); $("userID").html(""); $("name").html(""); $("phone").html(""); $("add").html(""); $("mail").html("");
      //  document.images['rpass'].src = "";
        document.fthem.repassword.focus();
        return false;
    } else {
        $("rpass").html("");
        document.images['rpass'].src = "../Image/OK.png";
    }
}
function checkname() {
    if (document.fthem.hoten.value == "" || document.fthem.hoten.value == 0) {
        $("name").html(" Tên người dùng không đc để trống");
        $("pass").html(""); $("userID").html(""); $("rpass").html(""); $("phone").html(""); $("add").html(""); $("mail").html("");
      //  document.images['name'].src = "";
        document.fthem.hoten.focus();
        return false;
    } else {
        $("name").html("");
        document.images['name'].src = "../Image/OK.png";
    }
}
function checkphone() {
    if (document.fthem.sdt.value == "" || document.fthem.sdt.value == 0) {
        $("phone").html(" Số điện thoại không đc để trống");
        $("pass").html(""); $("userID").html(""); $("name").html(""); $("rpass").html(""); $("add").html(""); $("mail").html("");
     //   document.images['phone'].src = "";
        document.fthem.sdt.focus();
        return false;
    }
    if (isNaN(document.fthem.sdt.value) == true) {
        $("phone").html(" Số điện thoại phải là kiểu số");
        $("pass").html(""); $("userID").html(""); $("name").html(""); $("rpass").html(""); $("add").html(""); $("mail").html("");
     //   document.images['phone'].src = "";
        document.fthem.sdt.focus();
        return false;
    } else {
        $("phone").html("");
        document.images['phone'].src = "../Image/OK.png";
    }
}
function checkadd() {
    if (document.fthem.diachi.value == "" || document.fthem.diachi.value == 0) {
        $("add").html(" Địa chỉ không đc để trống");
        $("pass").html(""); $("userID").html(""); $("name").html(""); $("phone").html(""); $("rpass").html(""); $("mail").html("");
        document.images['add'].src = "";
        document.fthem.diachi.focus();
        return false;
    } else {
        $("add").html("");
        document.images['add'].src = "../Image/OK.png";
    }
}
function checkmail() {
    if (document.fthem.email.value == "" || document.fthem.email.value == 0) {
        $("mail").html(" Email không bỏ trống");
        $("pass").html(""); $("userID").html(""); $("name").html(""); $("phone").html(""); $("add").html(""); $("rpass").html("");
     //   document.images['mail'].src = "";
        document.fthem.email.focus();
        return false;
    } else {
        $("mail").html("");
        document.images['mail'].src = "../Image/OK.png";
    }
    var filter = /^[A-z0-9_]+([.][A-z0-9_]+)*[@][A-z0-9_]+([.][A-z0-9_]+)*[.][A-z]{2,4}$/;
    if (!filter.test(document.fthem.email.value)) {
        $("mail").html(" Email không hợp lệ (ví dụ: abc@gmail.com)");
        $("pass").html(""); $("userID").html(""); $("name").html(""); $("phone").html(""); $("add").html(""); $("rpass").html("");
      //  document.images['mail'].src = "";
        document.fthem.email.focus();
        return false;
    } else {
        $("mail").html("");
        document.images['mail'].src = "../Image/OK.png";
    }
}
function checkID1() {
    if (document.fthem1.username.value == "" || document.fthem1.username.value == 0) {
        $("userID").html(" Tên đăng nhập không đc bỏ trống");
        $("pass").html(""); $("rpass").html(""); $("name").html(""); $("phone").html(""); $("add").html(""); $("mail").html("");
    //    document.images['userID'].src = "";
        document.fthem1.username.focus();
        return false;
    }
    if (document.fthem1.username.value.length < 6) {
        $("userID").html(" Tên đăng nhập phải từ 6 ký tự");
        $("pass").html(""); $("rpass").html(""); $("name").html(""); $("phone").html(""); $("add").html(""); $("mail").html("");
        document.images['userID'].src = "";
        document.fthem1.username.focus();
        return false;
    }
    else {
        $("userID").html("");
        document.images['userID'].src = "../Image/OK.png";
    }
}
function checkpasss1() {
    if (document.fthem1.password.value == "" || document.fthem1.password.value == 0) {
        $("pass").html(" Mật khẩu không đc để trống");
        $("userID").html(""); $("rpass").html(""); $("name").html(""); $("phone").html(""); $("add").html(""); $("mail").html("");
    //    document.images['pass'].src = "";
        document.fthem1.password.focus();
        return false;
    }
    if (document.fthem1.password.value.length < 6) {
        $("pass").html(" Mật khẩu phải từ 6 ký tự");
        $("userID").html(""); $("rpass").html(""); $("name").html(""); $("phone").html(""); $("add").html(""); $("mail").html("");
    //    document.images['pass'].src = "";
        document.fthem1.password.focus();
        return false;
    }
    else {
        $("pass").html("");
        document.images['pass'].src = "../Image/OK.png";
    }
}
function checkrpass1() {
    if (document.fthem1.repassword.value == "") {
        $("rpass").html(" Mật khẩu xác nhận không đc để trống");
        $("pass").html(""); $("userID").html(""); $("name").html(""); $("phone").html(""); $("add").html(""); $("mail").html("");
   //     document.images['rpass'].src = "";
        document.fthem1.repassword.focus();
        return false;
    } else {
        $("rpass").html("");
        document.images['rpass'].src = "../Image/OK.png";
    }
    if (document.fthem1.password.value != document.fthem1.repassword.value) {
        $("rpass").html(" Mật khẩu xác nhận không trùng khớp ");
        $("pass").html(""); $("userID").html(""); $("name").html(""); $("phone").html(""); $("add").html(""); $("mail").html("");
     //   document.images['rpass'].src = "";
        document.fthem1.repassword.focus();
        return false;
    } else {
        $("rpass").html("");
        document.images['rpass'].src = "../Image/OK.png";
    }
}
function checkname1() {
    if (document.fthem1.hoten.value == "" || document.fthem1.hoten.value == 0) {
        $("name").html(" Tên người dùng không đc để trống");
        $("pass").html(""); $("userID").html(""); $("rpass").html(""); $("phone").html(""); $("add").html(""); $("mail").html("");
    //    document.images['name'].src = "";
        document.fthem1.hoten.focus();
        return false;
    } else {
        $("name").html("");
        document.images['name'].src = "../Image/OK.png";
    }
}
function checkphone1() {
    if (document.fthem1.sdt.value == "" || document.fthem1.sdt.value == 0) {
        $("phone").html(" Số điện thoại không đc để trống");
        $("pass").html(""); $("userID").html(""); $("name").html(""); $("rpass").html(""); $("add").html(""); $("mail").html("");
    //    document.images['phone'].src = "";
        document.fthem1.sdt.focus();
        return false;
    }
    if (isNaN(document.fthem1.sdt.value) == true) {
        $("phone").html(" Số điện thoại phải là kiểu số");
        $("pass").html(""); $("userID").html(""); $("name").html(""); $("rpass").html(""); $("add").html(""); $("mail").html("");
    //    document.images['phone'].src = "";
        document.fthem1.sdt.focus();
        return false;
    } else {
        $("phone").html("");
        document.images['phone'].src = "../Image/OK.png";
    }
}
function checkadd1() {
    if (document.fthem1.diachi.value == "" || document.fthem1.diachi.value == 0) {
        $("add").html(" Địa chỉ không đc để trống");
        $("pass").html(""); $("userID").html(""); $("name").html(""); $("phone").html(""); $("rpass").html(""); $("mail").html("");
   //     document.images['add'].src = "";
        document.fthem1.diachi.focus();
        return false;
    } else {
        $("add").html("");
        document.images['add'].src = "../Image/OK.png";
    }
}
function checkmail1() {
    if (document.fthem1.email.value == "" || document.fthem1.email.value == 0) {
        $("mail").html(" Email không bỏ trống");
        $("pass").html(""); $("userID").html(""); $("name").html(""); $("phone").html(""); $("add").html(""); $("rpass").html("");
     //   document.images['mail'].src = "";
        document.fthem1.email.focus();
        return false;
    } else {
        $("mail").html("");
    }
    var filter = /^[A-z0-9_]+([.][A-z0-9_]+)*[@][A-z0-9_]+([.][A-z0-9_]+)*[.][A-z]{2,4}$/;
    if (!filter.test(document.fthem1.email.value)) {
        $("mail").html(" Email không hợp lệ (ví dụ: abc@gmail.com)");
        $("pass").html(""); $("userID").html(""); $("name").html(""); $("phone").html(""); $("add").html(""); $("rpass").html("");
     //   document.images['mail'].src = "";
        document.fthem1.email.focus();
        return false;
    } else {
        $("mail").html("");
    }
}
function checkgiohang() {
    // var a=trimspace(document.fgiohang.tenkh.value);
    if (document.fgiohang.tenkh.value == "" || document.fgiohang.tenkh.value == 0) {
        $("name").html(" Tên khách hàng không được bỏ trống");
        $("add").html(""); $("phone").html(""); $("mail").html("");
        document.fgiohang.tenkh.focus();
        return false;
    }
    if (document.fgiohang.diachi.value == "" || document.fgiohang.diachi.value == 0) {
        $("add").html(" Địa chỉ không bỏ trống");
        $("name").html(""); $("phone").html(""); $("mail").html("");
        document.fgiohang.diachi.focus();
        return false;
    }
    if (document.fgiohang.sdt.value == "" || document.fgiohang.sdt.value == 0) {
        $("phone").html(" Số điện thoại không bỏ trống");
        $("add").html(""); $("name").html(""); $("mail").html("");
        document.fgiohang.sdt.focus();
        return false;
    }
    if (isNaN(document.fgiohang.sdt.value) == true) {
        $("phone").html(" Số điện thoại phải là kiểu số");
        $("name").html(""); $("add").html(""); $("mail").html("");
        document.fgiohang.sdt.focus();
        return false;
    } else {
        $("phone").html("");
        document.fgiohang.email.focus();
    }
    if (document.fgiohang.email.value == "" || document.fgiohang.email.value == 0) {
        $("mail").html(" Email không bỏ trống");
        $("add").html(""); $("phone").html(""); $("name").html("");
        document.fgiohang.email.focus();
        return false;
    }
    var filter = /^[A-z0-9_]+([.][A-z0-9_]+)*[@][A-z0-9_]+([.][A-z0-9_]+)*[.][A-z]{2,4}$/;
    s = Trim(document.fgiohang.email.value);
    if (!filter.test(s)) {
        $("mail").html(" Email không hợp lệ (ví dụ: abc@gmail.com)");
        $("add").html(""); $("phone").html(""); $("name").html("");
        document.fgiohang.email.focus();
        return false;
    }
    var s = 'Thanh toán thành công ! Chúng tôi sẽ liên hệ với bạn để thục hiện chuyển hàng ';
    var answer = alert(s);
    return answer;
}
function laymk() {

    if (document.fthem.takmail.value == "" || document.fthem.takmail.value == 0) {
        $("mail").html(" Email không bỏ trống");
        document.fthem.takmail.focus();
        return false;
    }

    var filter = /^[A-z0-9_]+([.][A-z0-9_]+)*[@][A-z0-9_]+([.][A-z0-9_]+)*[.][A-z]{2,4}$/;
    if (!filter.test(document.fthem.takmail.value)) {
        $("mail").html(" Email không hợp lệ (ví dụ: abc@gmail.com)");
        document.fthem.takmail.focus();
        return false;
    }
    var s = ' Mật khẩu sẽ được gửi vào hộp mail của bạn,nhấn ok để xác nhận và về trang chủ ';
    var answer = confirm(s);
    return answer;
}
function kiemtradn() {
    if (document.dangnhap.username.value == "" || document.dangnhap.username.value == 0) {
        alert(" Tên đăng nhập không đc bỏ trống");
        document.dangnhap.username.focus();
        return false;
    }

    if (document.dangnhap.password.value == "" || document.dangnhap.password.value == 0) {
        alert(" Mật khẩu không đc để trống");
        document.dangnhap.password.focus();
        return false;
    }
}
function kiemtradk() {
    if (document.fthem.username.value == "" || document.fthem.username.value == 0) {
        $("userID").html(" Tên đăng nhập không đc bỏ trống");
        $("pass").html(""); $("rpass").html(""); $("name").html(""); $("phone").html(""); $("add").html(""); $("mail").html("");
        document.images['userID'].src = "";
        document.fthem.username.focus();
        return false;
    }
    if (document.fthem.username.value.length < 6) {
        $("userID").html(" Tên đăng nhập phải từ 6 ký tự");
        $("pass").html(""); $("rpass").html(""); $("name").html(""); $("phone").html(""); $("add").html(""); $("mail").html("");
        document.images['userID'].src = "";
        document.fthem.username.focus();
        return false;
    }
    else {
        $("userID").html("");
        document.images['userID'].src = "../Image/OK.png";
        document.fthem.password.focus();
    }
    if (document.fthem.password.value == "" || document.fthem.password.value == 0) {
        $("pass").html(" Mật khẩu không đc để trống");
        $("userID").html(""); $("rpass").html(""); $("name").html(""); $("phone").html(""); $("add").html(""); $("mail").html("");
        document.images['pass'].src = "";
        document.fthem.password.focus();
        return false;
    }
    if (document.fthem.password.value.length < 6) {
        $("pass").html(" Mật khẩu phải từ 6 ký tự");
        $("userID").html(""); $("rpass").html(""); $("name").html(""); $("phone").html(""); $("add").html(""); $("mail").html("");
        document.images['pass'].src = "";
        document.fthem.password.focus();
        return false;
    } else {
        $("pass").html("");
        document.images['pass'].src = "../Image/OK.png";
        document.fthem.repassword.focus();
    }
    if (document.fthem.repassword.value == "") {
        $("rpass").html(" Mật khẩu xác nhận không đc để trống");
        $("pass").html(""); $("userID").html(""); $("name").html(""); $("phone").html(""); $("add").html(""); $("mail").html("");
        document.images['rpass'].src = "";
        document.fthem.repassword.focus();
        return false;
    } else {
        $("rpass").html("");
        document.images['rpass'].src = "../Image/OK.png";
    }
    if (document.fthem.password.value != document.fthem.repassword.value) {
        $("rpass").html(" Mật khẩu xác nhận không trùng khớp ");
        $("pass").html(""); $("userID").html(""); $("name").html(""); $("phone").html(""); $("add").html(""); $("mail").html("");
        document.images['rpass'].src = "";
        document.fthem.repassword.focus();
        return false;
    }
    else {
        $("rpass").html("");
        document.images['rpass'].src = "../Image/OK.png";
        document.fthem.hoten.focus();
    }
    if (document.fthem.hoten.value == "" || document.fthem.hoten.value == 0) {
        $("name").html(" Tên người dùng không đc để trống");
        $("pass").html(""); $("userID").html(""); $("rpass").html(""); $("phone").html(""); $("add").html(""); $("mail").html("");
        document.images['name'].src = "";
        document.fthem.hoten.focus();
        return false;
    } else {
        $("name").html("");
        document.images['name'].src = "../Image/OK.png";
        document.fthem.sdt.focus();
    }
    if (document.fthem.sdt.value == "" || document.fthem.sdt.value == 0) {
        $("phone").html(" Số điện thoại không đc để trống");
        $("pass").html(""); $("userID").html(""); $("name").html(""); $("rpass").html(""); $("add").html(""); $("mail").html("");
        document.images['phone'].src = "";
        document.fthem.sdt.focus();
        return false;
    }
    if (isNaN(document.fthem.sdt.value) == true) {
        $("phone").html(" Số điện thoại phải là kiểu số");
        $("pass").html(""); $("userID").html(""); $("name").html(""); $("rpass").html(""); $("add").html(""); $("mail").html("");
        document.images['phone'].src = "";
        document.fthem.sdt.focus();
        return false;
    } else {
        $("phone").html("");
        document.images['phone'].src = "../Image/OK.png";
        document.fthem.diachi.focus();
    }
    if (document.fthem.diachi.value == "" || document.fthem.diachi.value == 0) {
        $("add").html(" Địa chỉ không đc để trống");
        $("pass").html(""); $("userID").html(""); $("name").html(""); $("phone").html(""); $("rpass").html(""); $("mail").html("");
        document.images['add'].src = "";
        document.fthem.diachi.focus();
        return false;
    } else {
        $("add").html("");
        document.images['add'].src = "../Image/OK.png";
        document.fthem.email.focus();
    }
    if (document.fthem.email.value == "" || document.fthem.email.value == 0) {
        $("mail").html(" Email không bỏ trống");
        $("pass").html(""); $("userID").html(""); $("name").html(""); $("phone").html(""); $("add").html(""); $("rpass").html("");
        document.images['mail'].src = "";
        document.fthem.email.focus();
        return false;
    } else {
        $("mail").html("");
        document.images['mail'].src = "../Image/OK.png";
    }
    var filter = /^[A-z0-9_]+([.][A-z0-9_]+)*[@][A-z0-9_]+([.][A-z0-9_]+)*[.][A-z]{2,4}$/;
    if (!filter.test(document.fthem.email.value)) {
        $("mail").html(" Email không hợp lệ (ví dụ: abc@gmail.com)");
        $("pass").html(""); $("userID").html(""); $("name").html(""); $("phone").html(""); $("add").html(""); $("rpass").html("");
        document.images['mail'].src = "";
        document.fthem.email.focus();
        return false;
    } else {
        $("mail").html("");
        document.images['mail'].src = "../Image/OK.png";
    }
}

function ktttuser() {
    if (document.fuser.hoten.value == "" || document.fuser.hoten.value == 0) {
        $("name").html(" Tên người dùng không đc để trống");
        $("pass").html(""); $("userID").html(""); $("rpass").html(""); $("phone").html(""); $("add").html(""); $("mail").html("");
        document.fuser.hoten.focus();
        return false;
    } else {
        $("name").html("");
        document.fuser.sdt.focus();
    }
    if (document.fuser.sdt.value == "" || document.fuser.sdt.value == 0) {
        $("phone").html(" Số điện thoại không đc để trống");
        $("pass").html(""); $("userID").html(""); $("name").html(""); $("rpass").html(""); $("add").html(""); $("mail").html("");
        document.fuser.sdt.focus();
        return false;
    }
    if (isNaN(document.fuser.sdt.value) == true) {
        $("phone").html(" Số điện thoại phải là kiểu số");
        $("pass").html(""); $("userID").html(""); $("name").html(""); $("rpass").html(""); $("add").html(""); $("mail").html("");
        document.fuser.sdt.focus();
        return false;
    } else {
        $("phone").html("");
        document.fuser.diachi.focus();
    }
    if (document.fuser.diachi.value == "" || document.fuser.diachi.value == 0) {
        $("add").html(" Địa chỉ không đc để trống");
        $("pass").html(""); $("userID").html(""); $("name").html(""); $("phone").html(""); $("rpass").html(""); $("mail").html("");
        document.fuser.diachi.focus();
        return false;
    } else {
        $("add").html("");
        document.fuser.email.focus();
    }
    if (document.fuser.email.value == "" || document.fuser.email.value == 0) {
        $("mail").html(" Email không bỏ trống");
        $("pass").html(""); $("userID").html(""); $("name").html(""); $("phone").html(""); $("add").html(""); $("rpass").html("");
        document.fuser.email.focus();
        return false;
    } else {
        $("mail").html("");
    }
    var filter = /^[A-z0-9_]+([.][A-z0-9_]+)*[@][A-z0-9_]+([.][A-z0-9_]+)*[.][A-z]{2,4}$/;
    if (!filter.test(document.fuser.email.value)) {
        $("mail").html(" Email không hợp lệ (ví dụ: abc@gmail.com)");
        $("pass").html(""); $("userID").html(""); $("name").html(""); $("phone").html(""); $("add").html(""); $("rpass").html("");
        document.fuser.email.focus();
        return false;
    } else {
        $("mail").html("");
    }
}

function checkinput() {
    if (document.fthem.loaihang.value == "" || document.fthem.loaihang.value == 0) {
        $("loai").html(" Bạn chưa chọn loại sản phẩm");
        $("clieu").html(""); $("gia").html(""); $("sluong").html(""); $("image").html(""); $("tensp").html(""); $("mota").html("");
        document.fthem.loaihang.focus();
        return false;
    } else {
        $("loai").html("");
        document.fthem.tensp.focus();
    }
    if (document.fthem.tensp.value == "" || document.fthem.tensp.value == 0) {
        $("tensp").html(" Tên sản phẩm không đc để trống");
        $("clieu").html(""); $("gia").html(""); $("sluong").html(""); $("image").html(""); $("loai").html(""); $("mota").html("");
        document.fthem.tensp.focus();
        return false;
    } else {
        $("tensp").html("");
        document.fthem.chatlieu.focus();
    }
    if (document.fthem.chatlieu.value == "" || document.fthem.chatlieu.value == 0) {
        $("clieu").html(" Chất liệu không đc để trống");
        $("tensp").html(""); $("gia").html(""); $("sluong").html(""); $("image").html(""); $("loai").html(""); $("mota").html("");
        document.fthem.chatlieu.focus();
        return false;
    } else {
        $("clieu").html("");
        document.fthem.gia.focus();
    }
    if (document.fthem.gia.value == "" || document.fthem.gia.value == 0) {
        $("gia").html(" Giá sản phẩm không đc để trống");
        $("clieu").html(""); $("tensp").html(""); $("sluong").html(""); $("image").html(""); $("loai").html(""); $("mota").html("");
        document.fthem.gia.focus();
        return false;
    }
    if (isNaN(document.fthem.gia.value) == true) {
        $("gia").html(" Giá sản phẩm phải là số");
        $("clieu").html(""); $("tensp").html(""); $("sluong").html(""); $("image").html(""); $("loai").html(""); $("mota").html("");
        document.fthem.gia.focus();
        return false;
    } else {
        $("gia").html("");
        document.fthem.mota.focus();
    }
    if (document.fthem.mota.value == "" || document.fthem.mota.value == 0) {
        $("mota").html(" Mô tả sản phẩm không đc để trống");
        $("clieu").html(""); $("gia").html(""); $("sluong").html(""); $("image").html(""); $("loai").html(""); $("tensp").html("");
        document.fthem.mota.focus();
        return false;
    } else {
        $("mota").html("");
        document.fthem.sl.focus();
    }
    if (document.fthem.sl.value == "") {
        $("sluong").html(" Số lượng sản phẩm không đc để trống");
        $("clieu").html(""); $("gia").html(""); $("tensp").html(""); $("image").html(""); $("loai").html(""); $("mota").html("");
        document.fthem.sl.focus();
        return false;
    }
    if (isNaN(document.fthem.sl.value) == true) {
        $("sluong").html(" Số lượng sản phẩm phải là số");
        $("clieu").html(""); $("gia").html(""); $("tensp").html(""); $("image").html(""); $("loai").html(""); $("mota").html("");
        document.fthem.sl.focus();
        return false;
    } else {
        $("sluong").html("");
    }
}
function checkinput1() {
    document.fthem.tensp.focus();
    if (document.fthem.tensp.value == "" || document.fthem.tensp.value == 0) {
        $("tensp").html(" Tên sản phẩm không đc để trống");
        $("clieu").html(""); $("gia").html(""); $("sluong").html(""); $("image").html(""); $("loai").html(""); $("mota").html("");
        document.fthem.tensp.focus();
        return false;
    } else {
        $("tensp").html("");
        document.fthem.chatlieu.focus();
    }
    if (document.fthem.chatlieu.value == "" || document.fthem.chatlieu.value == 0) {
        $("clieu").html(" Chất liệu không đc để trống");
        $("tensp").html(""); $("gia").html(""); $("sluong").html(""); $("image").html(""); $("loai").html(""); $("mota").html("");
        document.fthem.chatlieu.focus();
        return false;
    } else {
        $("clieu").html("");
        document.fthem.gia.focus();
    }
    if (document.fthem.gia.value == "" || document.fthem.gia.value == 0) {
        $("gia").html(" Giá sản phẩm không đc để trống");
        $("clieu").html(""); $("tensp").html(""); $("sluong").html(""); $("image").html(""); $("loai").html(""); $("mota").html("");
        document.fthem.gia.focus();
        return false;
    }
    if (isNaN(document.fthem.gia.value) == true) {
        $("gia").html(" Giá sản phẩm phải là số");
        $("clieu").html(""); $("tensp").html(""); $("sluong").html(""); $("image").html(""); $("loai").html(""); $("mota").html("");
        document.fthem.gia.focus();
        return false;
    } else {
        $("gia").html("");
        document.fthem.mota.focus();
    }
    if (document.fthem.mota.value == "" || document.fthem.mota.value == 0) {
        $("mota").html(" Mô tả sản phẩm không đc để trống");
        $("clieu").html(""); $("gia").html(""); $("sluong").html(""); $("image").html(""); $("loai").html(""); $("tensp").html("");
        document.fthem.mota.focus();
        return false;
    } else {
        $("mota").html("");
        document.fthem.sl.focus();
    }
    if (document.fthem.sl.value == "") {
        $("sluong").html(" Số lượng sản phẩm không đc để trống");
        $("clieu").html(""); $("gia").html(""); $("tensp").html(""); $("image").html(""); $("loai").html(""); $("mota").html("");
        document.fthem.sl.focus();
        return false;
    }
    if (isNaN(document.fthem.sl.value) == true) {
        $("sluong").html(" Số lượng sản phẩm phải là số");
        $("clieu").html(""); $("gia").html(""); $("tensp").html(""); $("image").html(""); $("loai").html(""); $("mota").html("");
        document.fthem.sl.focus();
        return false;
    } else {
        $("sluong").html("");
    }
}
function checkdoimk() {
    if (document.fdoimk.mkcu.value == "" || document.fdoimk.mkcu.value == 0) {
        $("pass").html(" Mật khẩu không đc để trống");
        $("rpass").html(""); $("pass1").html("");
        document.images['pass'].src = "";
        document.fdoimk.mkcu.focus();
        return false;
    }
    if (document.fdoimk.mkcu.value.length < 6) {
        $("pass").html(" Mật khẩu phải từ 6 ký tự");
        $("rpass").html(""); $("pass1").html("");
        document.images['pass'].src = "";
        document.fdoimk.mkcu.focus();
        return false;
    }
    else {
        $("pass").html("");
        document.images['pass'].src = "../Image/OK.png";
        document.fdoimk.mkmoi.focus();
    }
    if (document.fdoimk.mkmoi.value == "" || document.fdoimk.mkmoi.value == 0) {
        $("pass1").html(" Mật khẩu không đc để trống");
        $("rpass").html(""); $("pass").html("");
        document.images['pass1'].src = "";
        document.fdoimk.mkmoi.focus();
        return false;
    }
    if (document.fdoimk.mkmoi.value.length < 6) {
        $("pass1").html(" Mật khẩu phải từ 6 ký tự");
        $("rpass").html(""); $("pass").html("");
        document.images['pass1'].src = "";
        document.fdoimk.mkmoi.focus();
        return false;
    }
    else {
        $("pass1").html("");
        document.fdoimk.repassword.focus();
        document.images['pass1'].src = "../Image/OK.png";
    }
    if (document.fdoimk.repassword.value == "") {
        $("rpass").html(" Mật khẩu xác nhận không đc để trống");
        $("pass").html(""); $("pass1").html("");
        document.images['rpass'].src = "";
        document.fdoimk.repassword.focus();
        return false;
    }
    if (document.fdoimk.mkmoi.value != document.fdoimk.repassword.value) {
        $("rpass").html(" Mật khẩu xác nhận không trùng khớp ");
        $("pass").html(""); $("pass1").html("");
        document.images['rpass'].src = "";
        document.fdoimk.repassword.focus();
        return false;
    } else {
        $("rpass").html("");
        document.fdoimk.save.focus();
        document.images['rpass'].src = "../Image/OK.png";
    }
}
function ktuser() {
    if (document.fthem1.password.value == "" || document.fthem1.password.value == 0) {
        $("pass").html(" Mật khẩu không đc để trống");
        $("userID").html(""); $("rpass").html(""); $("name").html(""); $("phone").html(""); $("add").html(""); $("mail").html("");
        document.fthem1.password.focus();
        return false;
    }
    if (document.fthem1.password.value.length < 6) {
        $("pass").html(" Mật khẩu phải từ 6 ký tự");
        $("userID").html(""); $("rpass").html(""); $("name").html(""); $("phone").html(""); $("add").html(""); $("mail").html("");
        document.fthem1.password.focus();
        return false;
    } else {
        $("pass").html("");
        document.fthem1.hoten.focus();
    }
    if (document.fthem1.hoten.value == "" || document.fthem1.hoten.value == 0) {
        $("name").html(" Tên người dùng không đc để trống");
        $("pass").html(""); $("userID").html(""); $("rpass").html(""); $("phone").html(""); $("add").html(""); $("mail").html("");
        document.fthem1.hoten.focus();
        return false;
    } else {
        $("name").html("");
        document.fthem1.sdt.focus();
    }
    if (document.fthem1.sdt.value == "" || document.fthem1.sdt.value == 0) {
        $("phone").html(" Số điện thoại không đc để trống");
        $("pass").html(""); $("userID").html(""); $("name").html(""); $("rpass").html(""); $("add").html(""); $("mail").html("");
        document.fthem1.sdt.focus();
        return false;
    }
    if (isNaN(document.fthem1.sdt.value) == true) {
        $("phone").html(" Số điện thoại phải là kiểu số");
        $("pass").html(""); $("userID").html(""); $("name").html(""); $("rpass").html(""); $("add").html(""); $("mail").html("");
        document.fthem1.sdt.focus();
        return false;
    } else {
        $("phone").html("");
        document.fthem1.diachi.focus();
    }
    if (document.fthem1.diachi.value == "" || document.fthem1.diachi.value == 0) {
        $("add").html(" Địa chỉ không đc để trống");
        $("pass").html(""); $("userID").html(""); $("name").html(""); $("phone").html(""); $("rpass").html(""); $("mail").html("");
        document.fthem1.diachi.focus();
        return false;
    } else {
        $("add").html("");
        document.fthem1.email.focus();
    }
    if (document.fthem1.email.value == "" || document.fthem1.email.value == 0) {
        $("mail").html(" Email không bỏ trống");
        $("pass").html(""); $("userID").html(""); $("name").html(""); $("phone").html(""); $("add").html(""); $("rpass").html("");
        document.fthem1.email.focus();
        return false;
    } else {
        $("mail").html("");
    }
    var filter = /^[A-z0-9_]+([.][A-z0-9_]+)*[@][A-z0-9_]+([.][A-z0-9_]+)*[.][A-z]{2,4}$/;
    if (!filter.test(document.fthem1.email.value)) {
        $("mail").html(" Email không hợp lệ (ví dụ: abc@gmail.com)");
        $("pass").html(""); $("userID").html(""); $("name").html(""); $("phone").html(""); $("add").html(""); $("rpass").html("");
        document.fthem1.email.focus();
        return false;
    } else {
        $("mail").html("");
    }
}
function goback() {
    document.location = 'index.php';
}
function xacnhanxoa(str) {
    var s = 'Bạn có chắc là muốn xoá sản phẩm có mã số ';
    s += str;
    s += ' ?';
    var answer = confirm(s);
    return answer;
}
function xacnhanxoa() {
    var s = 'Bạn có chắc là muốn xoá  ';

    var answer = confirm(s);
    return answer;
}
function xacnhanxoahet() {
    var s = 'Bạn có chắc là muốn xoá hết sản phẩm trong giỏ hàng';;
    s += ' ?';
    var answer = confirm(s);
    return answer;
}
function Cau() {

    if (document.mainForm.email.value.length == 0) {
        document.getElementById('thu').innerHTML = "Phải nhập email!";
        return false;
    }
    else {
        document.getElementById("thu").innerHTML = "";
    }
    return true;
}





function check1() {
    if (Cau() == false)
        return false;
    if (checkEmail() == false)
        return false;
    return true;
}
function checkEmail() {
    var mail = document.mainForm.email;
    var filter = /^[A-z0-9_]+([.][A-z0-9_]+)*[@][A-z0-9_]+([.][A-z0-9_]+)*[.][A-z]{2,4}$/;
    if (!filter.test(mail.value)) {
        document.getElementById('thu').innerHTML = "Email chưa hợp lệ!";
        mail.focus;
        return false;
    }
    else {
        document.getElementById('thu').innerHTML = "";
    }
    return true;
}
function Cau2() {
    if (document.mainForm.name.value.length == 0) {
        document.getElementById('sao').innerHTML = "Phải nhập tên truy nhập!";
        return false;
    }
    else {
        document.getElementById("sao").innerHTML = "";
    }

    if (document.mainForm.pass.value.length == 0) {
        document.getElementById('mk').innerHTML = "Phải nhập mật khẩu!";
        return false;
    }
    else {
        document.getElementById("mk").innerHTML = "";
    }

    if (document.mainForm.pass.value.length < 6) {
        document.getElementById("mk").innerHTML = "Phải có ít nhất 6 kí tự!";
        return false;
    }
    else {
        document.getElementById("mk").innerHTML = "";
    }

    if (document.mainForm.pass2.value.length == 0) {
        document.getElementById('mk2').innerHTML = "Nhập lại mật khẩu!";
        return false;
    }
    else {
        document.getElementById("mk2").innerHTML = "";
    }

    var x = document.getElementById("mainForm");
    if ((x.pass.value != x.pass2.value) || (x.pass.value + x.pass2.value == "")) {
        //alert("Password does not match!");
        document.getElementById("mk2").innerHTML = "Nhập lại mật khẩu!";
        x.pass = "";
        x.pass2.value = "";
        return false;
    } else {
        document.getElementById("mk2").innerHTML = "";
    }

    if (document.mainForm.name2.value.length == 0) {
        document.getElementById('sao2').innerHTML = "Phải nhập Họ và tên!";
        return false;
    }
    else {
        document.getElementById("sao2").innerHTML = "";
    }

    if (document.mainForm.ngay.value == -1) {
        document.getElementById('ngaysinh').innerHTML = "Phải chọn ngày sinh!";
        return false;
    }
    else {
        document.getElementById("ngaysinh").innerHTML = "";
    }

    if (document.mainForm.thang.value == -1) {
        document.getElementById('ngaysinh').innerHTML = "Phải chọn tháng sinh!";
        return false;
    }
    else {
        document.getElementById("ngaysinh").innerHTML = "";
    }

    if (document.mainForm.nam.value == -1) {
        document.getElementById('ngaysinh').innerHTML = "Phải chọn năm sinh!";
        return false;
    }
    else {
        document.getElementById("ngaysinh").innerHTML = "";
    }

    if (document.mainForm.phone.value.length == 0) {
        document.getElementById('dt').innerHTML = "Phải nhập số điện thoại!";
        return false;
    }
    else {
        document.getElementById("dt").innerHTML = "";
    }
    if (!isFinite(document.mainForm.phone.value)) {
        document.getElementById("dt").innerHTML = "Phải là số!";
        return false;
    }
    else {
        document.getElementById("dt").innerHTML = "";
    }

    if (document.mainForm.email.value.length == 0) {
        document.getElementById('thu').innerHTML = "Phải nhập email!";
        return false;
    }
    else {
        document.getElementById("thu").innerHTML = "";
    }

    if (document.mainForm.city.value == 0) {
        document.getElementById('tp').innerHTML = "Phải chọn Tỉnh/Thành phố";
        return false;
    }
    else {
        document.getElementById("tp").innerHTML = "";
    }

    if (!document.mainForm.agree.checked) {
        document.getElementById("dongy").innerHTML = "Bạn phải đồng ý điều khoản sử dụng của chúng tôi!";
        return false;
    } else {
        document.getElementById("dongy").innerHTML = "";

    }

    return true;
}

function pass6kitu() {
    if (document.mainForm.pass.value.length < 6) {
        document.getElementById("mk").innerHTML = "Phải có ít nhất 6 kí tự!";
        return false;
    }
    else {
        document.getElementById("mk").innerHTML = "";
    }
}

function checkpass() {
    var x = document.getElementById("mainForm");
    if ((x.pass.value != x.pass2.value) || (x.pass.value + x.pass2.value == "")) {
        //alert("Password does not match!");
        document.getElementById("mk2").innerHTML = "Nhập lại mật khẩu!";
        x.pass = "";
        x.pass2.value = "";
    } else {
        document.getElementById("mk2").innerHTML = "";
    }
}
function checkagree(x) {
    if (x.checked)
        document.getElementById("dongy").innerHTML = "";
    else document.getElementById("dongy").innerHTML = "Bạn phải đồng ý điều khoản sử dụng của chúng tôi!";
}

function checkEmail() {
    var mail = document.mainForm.email;
    var filter = /^[A-z0-9_]+([.][A-z0-9_]+)*[@][A-z0-9_]+([.][A-z0-9_]+)*[.][A-z]{2,4}$/;
    if (!filter.test(mail.value)) {
        document.getElementById('thu').innerHTML = "Email chưa hợp lệ!";
        mail.focus;
        return false;
    }
    else {
        document.getElementById('thu').innerHTML = "";
    }
    return true;
}
function Checkdt() {
    if (!isFinite(document.mainForm.phone.value)) {
        document.getElementById("dt").innerHTML = "Phải là số!";
        return false;
    }
    else {
        document.getElementById("dt").innerHTML = "";
    }

    if (document.mainForm.phone.value.length == 0) {
        document.getElementById('dt').innerHTML = "Phải nhập số điện thoại!";

    }
    else {
        document.getElementById("dt").innerHTML = "";
    }
}

function Checkname() {
    if (document.mainForm.name.value.length == 0) {
        document.getElementById('sao').innerHTML = "Phải nhập tên truy nhập!";
    }
    else {
        document.getElementById("sao").innerHTML = "";
    }
}

function Checkhoten() {
    if (document.mainForm.name2.value.length == 0) {
        document.getElementById('sao2').innerHTML = "Phải nhập Họ và tên!";
    }
    else {
        document.getElementById("sao2").innerHTML = "";
    }
}

function Checktp() {
    if (document.mainForm.city.value == 0) {
        document.getElementById('tp').innerHTML = "Phải chọn Tỉnh/Thành phố";
    }
    else {
        document.getElementById("tp").innerHTML = "";
    }
}
function check_nam_nhuan(nam) {
    if ((nam % 4 == 0) || (nam % 100 != 0)) return true;
    else return false;
}

function check_date_month() {
    var ngay = document.mainForm.ngay.value;
    var thang = document.mainForm.thang.value;
    var nam = document.mainForm.nam.value;

    if (thang == 2) {
        var dm = 0;
        if (check_nam_nhuan(nam)) dm = 29;
        else dm = 28;
        if (ngay > dm) {
            document.getElementById('ngaysinh').innerHTML = "Ngày sinh không hợp lệ!";
            return false;
        }
        else {
            document.getElementById('ngaysinh').innerHTML = "";
            return true;
        }
    }
    else
        if (thang == 4 || thang == 6 || thang == 9 || thang == 11) {
            if (ngay > 30) {
                document.getElementById('ngaysinh').innerHTML = "Ngày sinh không hợp lệ!";
                return false;
            }
            else {
                document.getElementById('ngaysinh').innerHTML = "";
                return true;
            }
        }
    if (thang == 1 || thang == 3 || thang == 5 || thang == 7 || thang == 8 || thang == 10 || thang == 12) {
        document.getElementById('ngaysinh').innerHTML = "";
        return true;
    }
    return true;
}

function Check() {
    if (Cau2() == false)
        return false;
    if (checkEmail() == false)
        return false;
    if (check_date_month() == false)
        return false;
    return true;

}
function show_hide() {
    if (document.getElementById("full").style.display != 'block') {
        document.getElementById("wrapper").style.display = "none";
        document.getElementById("full").style.display = "block";
    }
    else {
        document.getElementById("wrapper").style.display = "block";
        document.getElementById("full").style.display = 'none';
    }
    return false;
}
function initOverLabels() {
    if (!document.getElementById) return;
    var labels, id, field;
    labels = document.getElementsByTagName('label');
    for (var i = 0; i < labels.length; i++) {
        if (labels[i].className == 'overlabel') {
            id = labels[i].htmlFor || labels[i].getAttribute('for');
            if (!id || !(field = document.getElementById(id))) {
                continue;
            }
            if (field.value !== '') {
                hideLabel(field.getAttribute('id'), true);
            }
            field.onfocus = function () {
                hideLabel(this.getAttribute('id'), true);
            };
            field.onblur = function () {
                if (this.value === '') {
                    hideLabel(this.getAttribute('id'), false);
                }
            };
            labels[i].onclick = function () {
                var id, field;
                id = this.getAttribute('for');
                if (id || (field = document.getElementById(id))) {
                    field.focus();
                }
            };
        }
    }
};

function hideLabel(field_id, hide) {
    var field_for;
    var labels = document.getElementsByTagName('label');
    for (var i = 0; i < labels.length; i++) {
        field_for = labels[i].htmlFor || labels[i].getAttribute('for');
        if (field_for == field_id) {
            labels[i].style.textIndent = (hide) ? '-1000px' : '0px';
            return true;
        }
    }
}
function addLoadEvent(func) {
    var oldonload = window.onload;
    if (typeof window.onload != 'function') {
        window.onload = func;
    }
    else {
        window.onload = function () {
            if (oldonload) {
                oldonload();
            }
            func();
        }
    }
}

addLoadEvent(function () {
    setTimeout(initOverLabels, 50);
});

function Trim(sString) {
    while (sString.substring(0, 1) == " ") {
        sString = sString.substring(1, sString.length);
    }
    while (sString.substring(sString.length - 1, sString.length) == " ") {
        sString = sString.substring(0, sString.length - 1);
    }
    return sString;
}


function time() {
    var Thu = new Array("Chủ Nhật", "Thứ Hai", "Thứ Ba", "Thứ Tư", "Thứ Năm", "Thứ Sáu", "Thứ Bảy");
    var Thang = new Array("01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12");
    var today = new Date();
    var Year = today.getYear();
    if ((navigator.appName == "Microsoft Internet Explorer") || (Year < 2000))
        Year = "19" + Year;
    if (navigator.appName == "Netscape")
        Year = 1900 + Year;
    document.write(Thu[today.getDay()] + " , Ngày " + today.getDate() + " Tháng " + Thang[today.getMonth()] + " Năm " + Year + " " + '')
}
//menu xo ngang
var menuids = ["sidebarmenu1"] //Enter id(s) of each Side Bar Menu's main UL, separated by commas
function initsidebarmenu() {
    for (var i = 0; i < menuids.length; i++) {
        var ultags = document.getElementById(menuids[i]).getElementsByTagName("ul")
        for (var t = 0; t < ultags.length; t++) {
            ultags[t].parentNode.getElementsByTagName("a")[0].className += " subfolderstyle"
            if (ultags[t].parentNode.parentNode.id == menuids[i]) //if this is a first level submenu
                ultags[t].style.left = ultags[t].parentNode.offsetWidth + "px" //dynamically position first level submenus to be width of main menu item
            else //else if this is a sub level submenu (ul)
                ultags[t].style.left = ultags[t - 1].getElementsByTagName("a")[0].offsetWidth + "px" //position menu to the right of menu item that activated it
            ultags[t].parentNode.onmouseover = function () {
                this.getElementsByTagName("ul")[0].style.display = "block"
            }
            ultags[t].parentNode.onmouseout = function () {
                this.getElementsByTagName("ul")[0].style.display = "none"
            }
        }
        for (var t = ultags.length - 1; t > -1; t--) {
            ultags[t].style.visibility = "visible"
            ultags[t].style.display = "none"
        }
    }
}
if (window.addEventListener)
    window.addEventListener("load", initsidebarmenu, false)
else if (window.attachEvent)
    window.attachEvent("onload", initsidebarmenu)