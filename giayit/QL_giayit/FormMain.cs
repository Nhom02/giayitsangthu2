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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FormQuanLyTonKho f = new FormQuanLyTonKho();
            f.ShowDialog();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNhapHang nh = new FormNhapHang();
            nh.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormThongKe tk = new FormThongKe();
            tk.Show();
        }

        private void pcQuanLyNhapHang_Click(object sender, EventArgs e)
        {
            FormQLNhapHang Nh = new FormQLNhapHang();
            Nh.ShowDialog();
        }

        private void khoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyTonKho f = new FormQuanLyTonKho();
            f.ShowDialog();
        }

        private void thốngKêBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongKe tk = new FormThongKe();
            tk.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
