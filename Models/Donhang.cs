using System;
using System.Collections.Generic;

#nullable disable

namespace ShopPhone.Models
{
    public partial class Donhang
    {
        public Donhang()
        {
            Chitietdonhangs = new HashSet<Chitietdonhang>();
        }

        public string MaDon { get; set; }
        public DateTime? NgayDat { get; set; }
        public string TinhTrang { get; set; }
        public string MaKhachHang { get; set; }
        public string MaNv { get; set; }

        public virtual Khachhang MaKhachHangNavigation { get; set; }
        public virtual Nhanvien MaNvNavigation { get; set; }
        public virtual ICollection<Chitietdonhang> Chitietdonhangs { get; set; }
    }
}
