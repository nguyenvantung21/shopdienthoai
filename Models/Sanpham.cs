using System;
using System.Collections.Generic;

#nullable disable

namespace ShopPhone.Models
{
    public partial class Sanpham
    {
        public Sanpham()
        {
            Chitietdonhangs = new HashSet<Chitietdonhang>();
        }

        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string Anh { get; set; }
        public string MoTa { get; set; }
        public decimal? GiaTien { get; set; }
        public int? SoLuong { get; set; }
        public string MaDanhMuc { get; set; }

        public virtual Danhmucsp MaDanhMucNavigation { get; set; }
        public virtual ICollection<Chitietdonhang> Chitietdonhangs { get; set; }
    }
}
