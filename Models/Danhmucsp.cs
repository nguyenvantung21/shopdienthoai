using System;
using System.Collections.Generic;

#nullable disable

namespace ShopPhone.Models
{
    public partial class Danhmucsp
    {
        public Danhmucsp()
        {
            Sanphams = new HashSet<Sanpham>();
        }

        public string MaDanhMuc { get; set; }
        public string TenDanhMuc { get; set; }

        public virtual ICollection<Sanpham> Sanphams { get; set; }
    }
}
