using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ShopPhone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ShopPhone.Controllers
{
    public class DonhangController : Controller
    {
        QLDienThoaiContext db = new QLDienThoaiContext();
        public static List<Giohang> list = new List<Giohang>();
        public void SetSession()
        {
            var str = JsonConvert.SerializeObject(list);
            HttpContext.Session.SetString("DonHang", str);
        }
        public ActionResult GetGiohang()
        {
            SetSession();
            var temp = HttpContext.Session.GetString("DonHang");
            return View(list);
        }
        public ActionResult ThemGioHang(string id)
        {
            Sanpham sp = db.Sanphams.SingleOrDefault(n => n.MaSanPham == id);
            if (sp == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            Giohang giohang = list.Find(n => n.masp == id);
            if (giohang == null)
            {
                //Add sản phẩm mới thêm vào list
                giohang = new Giohang(id);
                list.Add(giohang);
                return RedirectToAction("Index", "Sanphams");
            }
            else
            {
                giohang.soluong++;
                return RedirectToAction("Index", "Sanphams");
            }
        }
        public ActionResult DatHang()
        {
            Donhang dh = new Donhang();
            Khachhang kh = null;
            if (HttpContext.Session.GetString("user") != null)
            {
                kh = JsonConvert.DeserializeObject<Khachhang>(HttpContext.Session.GetString("user"));
                dh.MaDon = "MD" + db.Donhangs.Count() + 1;
                dh.MaKhachHang = kh.MaKhachHang;
                dh.NgayDat = DateTime.Now;
                dh.MaNv = "NV01";
                dh.TinhTrang = "Chờ xử lý";
                db.Donhangs.Add(dh);
                Chitietdonhang ct = new Chitietdonhang();
                ct.MaDon = dh.MaDon;
                foreach(var item in list)
                {

                }    
                db.SaveChanges();
                list.Clear();
                HttpContext.Session.Remove("DonHang");
                TempData["msgdh"] = "<script>alert('Đặt hàng thành công ! Đơn hàng của bạn đang được xử lý');</script>";
                return RedirectToAction("Index", "Home");
            }
            else
                return RedirectToAction("Login", "Login");
        }
    }
}
