using System;
using System.Collections.Generic;

#nullable disable

namespace ShopPhone.Models
{
    public partial class Nhanvien
    {
        public Nhanvien()
        {
            Donhangs = new HashSet<Donhang>();
        }

        public string MaNv { get; set; }
        public string TenNv { get; set; }
        public string TaiKhoanNv { get; set; }
        public string MatKhau { get; set; }
        public string Sdt { get; set; }
        public string NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Donhang> Donhangs { get; set; }
    }
}
