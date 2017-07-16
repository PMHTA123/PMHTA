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
        // liên lết button nhân viên đến trang form nhân viên
        private void frmNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien f = new frmNhanVien();
            f.Show();

        }
        // liên lết button khách hàng đến trang form khách hàng
        private void frmKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            f.Show();
        }
        // liên lết button hàng hóa đến trang form hàng hóa
        private void frmHangHoa_Click(object sender, EventArgs e)
        {
            frmHangHoa f = new frmHangHoa();
            f.Show();
        }
        // liên lết button hóa đơn đến trang form hóa đơn
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
