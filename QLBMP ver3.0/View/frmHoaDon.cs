using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QL_BanHang.Control;
using QL_BanHang.Obiect;

namespace QL_BanHang.View
{
    public partial class frmHoaDon : Form
    {
        HoaDonCtr hdCtr = new HoaDonCtr();
        ChiTietCtr ctCtr = new ChiTietCtr();
        HangHoaCtr hhctr = new HangHoaCtr();
        DataTable dtDSCT = new System.Data.DataTable();
        int vitriclick = 0;
        
        public frmHoaDon()
        {
            InitializeComponent();
        }
        // hàm load của form
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            Dis_Enl(false);
            DataTable dt = new System.Data.DataTable();
            dt = hdCtr.GetData();
            dtgvDSHD.DataSource = dt;
            binding();
            txtNgayLap.Enabled = false;
        }
        //hàm liên kết  phần giao diện và phần dữ liệu
        private void binding()
        {
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("Text", dtgvDSHD.DataSource,"MaHD");
            txtNgayLap.DataBindings.Clear();
            txtNgayLap.DataBindings.Add("Text", dtgvDSHD.DataSource, "NgayLap");
            txtNhanVien.DataBindings.Clear();
            txtNhanVien.DataBindings.Add("Text", dtgvDSHD.DataSource, "TenNV");
            cmbKhachHang.DataBindings.Clear();
            cmbKhachHang.DataBindings.Add("Text", dtgvDSHD.DataSource, "TenKH");
        }

        //private void bingding1()
        //{
        //    txtDonGia.DataBindings.Clear();
        //    txtDonGia.DataBindings.Add("Text", dtgvDSHH.DataSource, "DonGia");
        //    txtSL.DataBindings.Clear();
        //    txtSL.DataBindings.Add("Text", dtgvDSHH.DataSource, "SoLuong");
        //    cmbHH.DataBindings.Clear();
        //    cmbHH.DataBindings.Add("Text", dtgvDSHH.DataSource, "HangHoa");
        //    lbThanhTien.DataBindings.Clear();
        //    lbThanhTien.DataBindings.Add("Text", dtgvDSHH.DataSource, "ThanhTien");

        //}

        private void Dis_Enl(bool e)
        {
            txtMa.Enabled = e;
            txtNhanVien.Enabled = e;
            cmbKhachHang.Enabled = e;
            btnAdd.Enabled = !e;
            btnDel.Enabled = !e;
            btnPrint.Enabled = !e;
            btnSave.Enabled = e;
            btnCancel.Enabled = e;
            btncham.Enabled = e;
            btnThem.Enabled = e;
            btnBot.Enabled = e;
            cmbHH.Enabled = e;
            txtSL.Enabled = e;
        }
        // hàm load dữ liệu lên combobox 
        private void LoadcmbKhachHang()
        { 
            KhachHangCtr khctr = new KhachHangCtr();
            cmbKhachHang.DataSource = khctr.GetData();
            cmbKhachHang.DisplayMember = "TenKH";
            cmbKhachHang.ValueMember = "MaKH";
            cmbKhachHang.SelectedIndex = 0;
        }
        // hàm load dữ liệu lên combobox 

        private void LoadcmbHH()
        {
            HangHoaCtr hhctr = new HangHoaCtr();
            cmbHH.DataSource = hhctr.GetData();
            cmbHH.DisplayMember = "TenHang";
            cmbHH.ValueMember = "MaHang";
            
        }
        // hàm xóa dữ liệu

        private void clearData()
        {
            txtMa.Text = "";
            txtNhanVien.Text = "";
            txtNgayLap.Text = DateTime.Now.Date.ToShortDateString();
            LoadcmbKhachHang();
        }
        // hàm thêm dữ liệu 

        private void addData(HoaDonObj hdObj)
        {
            hdObj.MaHoaDon = txtMa.Text.Trim();
            hdObj.NgayLap = txtNgayLap.Text.Trim();
            hdObj.NguoiLap = txtNhanVien.Text.Trim();
            hdObj.KhachHang = cmbKhachHang.SelectedValue.ToString();
        }
        // hàm check trùng dữ liệu
        private bool checktrung(string mahh)
        {
            for (int i = 0; i < dtDSCT.Rows.Count; i++)
                if (dtDSCT.Rows[i][1].ToString() == mahh)
                    return true;
            return false;
        }
        // hàm cập nhật số lượng
        private void capnhatSL(string mahh, int SL)
        {
            for (int i = 0; i < dtDSCT.Rows.Count; i++)
                if (dtDSCT.Rows[i][1].ToString() == mahh)
                {
                    int soluong = int.Parse(dtDSCT.Rows[i][3].ToString())+SL;
                    dtDSCT.Rows[i][3] = soluong;
                    double dongia = double.Parse(dtDSCT.Rows[i][2].ToString());
                    dtDSCT.Rows[i][4] = (dongia*soluong).ToString();
                    break;
                }
        }
        // hàm kiểm tra số lượng
        private bool kiemtraSL(string mahh, int sl)
        {
            DataTable dt = new DataTable();
            dt = hhctr.GetData("Where MaHang = '" + cmbHH.SelectedValue.ToString() + "' and SoLuong>= "+sl);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new System.Data.DataTable();
                dt = ctCtr.GetData(txtMa.Text.Trim());
                dtgvDSHH.DataSource = dt;
                
            }
            catch
            {
                dtgvDSHH.DataSource = null;
            }
            //bingding1();
        }

        private void dtgvDSHH_DataSourceChanged(object sender, EventArgs e)
        {
            //bingding1();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Dis_Enl(true);
            clearData();
            LoadcmbHH();
            LoadcmbKhachHang();

            dtDSCT.Rows.Clear();
            dtDSCT.Columns.Add("MaHD");
            dtDSCT.Columns.Add("HangHoa");
            dtDSCT.Columns.Add("DonGia");
            dtDSCT.Columns.Add("SoLuong");
            dtDSCT.Columns.Add("ThanhTien");

        }

        private void btncham_Click(object sender, EventArgs e)
        {
            txtNgayLap.Enabled = true;
        }
        // nút xóa hóa đơn
        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa hóa đơn này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (hdCtr.DelData(txtMa.Text.Trim()))
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmHoaDon_Load(sender, e);
        }
        // nút lưu hóa đơn
        private void btnSave_Click(object sender, EventArgs e)
        {
            HoaDonObj hdObj = new HoaDonObj();
            addData(hdObj);
            if (hdCtr.AddData(hdObj))
            {
                if (ctCtr.AddData(dtDSCT) && hhctr.UpdSL(dtDSCT))
                    MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm chi tiết không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Thêm hóa đơn không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            frmHoaDon_Load(sender,e);
        }
        // nút cancel để hủy bỏ thao tác
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                frmHoaDon_Load(sender, e);
            else
                return;
        }
        // nút in hóa đơn
        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang đc nâng cấp");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMa.Text))
            {
                if(kiemtraSL(cmbHH.SelectedValue.ToString(), int.Parse(txtSL.Text.Trim())))
                {
                    if (!checktrung(cmbHH.SelectedValue.ToString()))
                    {
                        DataRow dr = dtDSCT.NewRow();
                        dr[0] = txtMa.Text.Trim();
                        dr[1] = cmbHH.SelectedValue.ToString();
                        dr[2] = txtDonGia.Text;
                        dr[3] = txtSL.Text;
                        dr[4] = (double.Parse(txtDonGia.Text) * int.Parse(txtSL.Text)).ToString();
                        dtDSCT.Rows.Add(dr);
                    }
                    else
                    {
                        capnhatSL(cmbHH.SelectedValue.ToString(), int.Parse(txtSL.Text));
                    }
                dtgvDSHH.DataSource = dtDSCT;
                }
                else
                {
                    MessageBox.Show("Số lượng không dủ", "Lỗi");
                    txtSL.Focus();
                }
            }
            else
            {
                MessageBox.Show("Mã hóa đơn không được trống", "Lỗi");
                txtMa.Focus();
            }
        }
        // nút bớt số lượng hàng hóa
        private void btnBot_Click(object sender, EventArgs e)
        {
            if (vitriclick < dtDSCT.Rows.Count)
            {
                dtDSCT.Rows.RemoveAt(vitriclick);
                dtgvDSHH.DataSource = dtDSCT;
            }
        }
        // 
        private void cmbHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = hhctr.GetData("Where MaHang = '" + cmbHH.SelectedValue.ToString() + "'");
            if (dt.Rows.Count > 0)
            {
                double gia = double.Parse(dt.Rows[0][2].ToString());

                txtDonGia.Text = (gia * 1.1).ToString();

                lbThanhTien.Text = (double.Parse(txtDonGia.Text) * int.Parse(txtSL.Text)).ToString();
            }
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            lbThanhTien.Text = (double.Parse(txtDonGia.Text) * int.Parse(txtSL.Text)).ToString();
        }

        private void dtgvDSHH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitriclick = e.RowIndex;
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
