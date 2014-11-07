using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_giayit
{
    public partial class FormQLNhapHang : Form
    {
       
        ServiceReferencePhieuNhap.ServicePhieuNhapClient PN = new ServiceReferencePhieuNhap.ServicePhieuNhapClient();
        ServiceReferenceChiTietPhieuNhap.ServiceChiTietPhieuNhapClient CTPN = new ServiceReferenceChiTietPhieuNhap.ServiceChiTietPhieuNhapClient();
        public FormQLNhapHang()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            var grv = PN.getallphieunhap();
            gvPhieuNhap.AutoGenerateColumns = false;
            gvPhieuNhap.DataSource = grv;
            gvPhieuNhap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
        }

        private void gvPhieuNhap_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            DataGridViewRow dr = gvPhieuNhap.SelectedRows[0];
            string s= dr.Cells[0].Value.ToString();
            var grvct = CTPN.getallchitietphieunhap().Where(x => x.maphieunhap.ToString() == s).ToList();
            gvChiTietPhieuNhap.AutoGenerateColumns = false;
            gvChiTietPhieuNhap.DataSource = grvct;
            gvChiTietPhieuNhap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            txtMaPN.Text = dr.Cells[0].Value.ToString();
            txtNguoiNhap.Text = dr.Cells[1].Value.ToString();
            txtTongTien.Text = dr.Cells[3].Value.ToString();
            txtNgayNhap.Text = dr.Cells[2].Value.ToString();
          //  txtGhiChu.Text = dr.Cells[4].Value.ToString();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            load();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemPhieu_Click(object sender, EventArgs e)
        {
            FormNhapHang NH = new FormNhapHang();
            NH.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gvPhieuNhap.DataSource = null;
            gvPhieuNhap.AutoGenerateColumns = false;
            gvPhieuNhap.DataSource=(from n in PN.getallphieunhap() where n.ngaynhap>=ngaytu.Value.Date && n.ngaynhap<= ngayden.Value.Date select n).ToList();
            gvChiTietPhieuNhap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void FormQLNhapHang_Load(object sender, EventArgs e)
        {

        }
    }
}
