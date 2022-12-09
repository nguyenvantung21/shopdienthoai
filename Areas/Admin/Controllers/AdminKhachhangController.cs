using Microsoft.AspNetCore.Mvc;
using ShopPhone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPhone.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminKhachhangController : Controller
    {
        QLDienThoaiContext db = new QLDienThoaiContext();
        [Route("admin/GetKhachhang")]
        public IActionResult GetKhachhang()
        {
            return View(db.Khachhangs);
        }
        [HttpGet]
        [Route("admin/CreateKH")]
        public IActionResult CreateKh()
        {
            return View();
        }
        [HttpPost]
        [Route("admin/createKH")]
        public IActionResult CreateKH(Khachhang kh)
        {
                       
                Khachhang s = kh;
                db.Khachhangs.Add(s);
                db.SaveChanges();
                TempData["msgcreate"] = "<script>alert('Thêm khách hàng thành công');</script>";
            return RedirectToAction("GetKhachhang", "Admin");
        }
        [HttpGet]
        [Route("admin/EditKH")]
        public IActionResult EditKH(string id)
        {
            ViewBag.IDKH = id;
            return View();
        }
        [HttpPost]
        [Route("admin/editKH")]
        public IActionResult EditKH(Khachhang kh)
        {
                Khachhang sp1 = db.Khachhangs.FirstOrDefault(p => p.MaKhachHang.Equals(kh.MaKhachHang));
                db.Khachhangs.Remove(sp1);
                db.Khachhangs.Add(kh);
                db.SaveChanges();
                TempData["msgcreate"] = "<script>alert('Sửa thông tin khách hàng thành công');</script>";
            return RedirectToAction("GetKhachhang", "Admin");
        }
        public IActionResult Delete(string id)
        {
            var temp = db.Khachhangs.FirstOrDefault(o => o.MaKhachHang.Equals(id));
            if (temp != null)
            {
                db.Khachhangs.Remove(temp);
                db.SaveChanges();
                TempData["msgdelete"] = "<script>alert('Xóa khách hàng thành công');</script>";
                return RedirectToAction("GetKhachhang", "Admin");
            }
            return Ok(404);
        }
    }
}
