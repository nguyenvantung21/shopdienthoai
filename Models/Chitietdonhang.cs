using System;
using System.Collections.Generic;

#nullable disable

namespace ShopPhone.Models
{
    public partial class Chitietdonhang
    {
        public string MaSanPham { get; set; }
        public string MaDon { get; set; }
        public int? SoLuong { get; set; }
        public decimal? DonGia { get; set; }

        public virtual Donhang MaDonNavigation { get; set; }
        public virtual Sanpham MaSanPhamNavigation { get; set; }
    }
}
