using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QL_BanHang.Obiect
{
    /*
     ma : mã hàng hóa
     ten : tên hàng hóa
     dongia: giá của hàng hóa
     soluong: số lượng hàng
     
         */
    class HangHoaObj
    {
        string ma, ten;
        int dongia, soluong;

        public int SoLuong
        {
            get { return soluong; }
            set { soluong = value; }
        }

        public int DonGia
        {
            get { return dongia; }
            set { dongia = value; }
        }

        public string TenHangHoa
        {
            get { return ten; }
            set { ten = value; }
        }

        public string MaHangHoa
        {
            get { return ma; }
            set { ma = value; }
        }

        public HangHoaObj() { }
        public HangHoaObj(string ma, string ten, int dongia, int soluong)
        {
            this.ma = ma;
            this.ten = ten;
            this.dongia = dongia;
            this.soluong = soluong;
        }
    }
}
