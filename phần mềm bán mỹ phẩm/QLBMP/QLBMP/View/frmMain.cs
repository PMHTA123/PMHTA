using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_BanHang.View;

namespace QLBMP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien f = new frmNhanVien();
            f.Show();

        }

        private void frmKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            f.Show();
        }

        private void frmHangHoa_Click(object sender, EventArgs e)
        {
            frmHangHoa f = new frmHangHoa();
            f.Show();
        }

        private void frmHoaDon_Click(object sender, EventArgs e)
        {
            frmHoaDon f = new frmHoaDon();
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
