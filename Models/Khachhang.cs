using System;
using System.Collections.Generic;

#nullable disable

namespace ShopPhone.Models
{
    public partial class Khachhang
    {
        public Khachhang()
        {
            Donhangs = new HashSet<Donhang>();
        }

        public string MaKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public string TaiKhoanKh { get; set; }
        public string MatKhau { get; set; }
        public string Sdt { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Donhang> Donhangs { get; set; }
    }
}
