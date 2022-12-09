using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPhone.Models
{
    public class Giohang
    {
        public string masp { get; set; }
        public string tensp { get; set; }
        public string anh { get; set; }
        public double dongia { get; set; }
        public int soluong { get; set; }
        public double Thanhtien()
        {
            return dongia * soluong;
        }
        public Giohang(string ma)
        {
            QLDienThoaiContext db = new QLDienThoaiContext();
            masp = ma;
            Sanpham sp = db.Sanphams.FirstOrDefault(p => p.MaSanPham == ma);
            tensp = sp.TenSanPham;
            anh = sp.Anh;
            dongia = (double)sp.GiaTien;
            soluong = 1;
        }
    }
}
