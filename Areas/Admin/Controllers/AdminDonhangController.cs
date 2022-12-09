using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShopPhone.Models;

namespace ShopPhone.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminDonhangController : Controller
    {
        QLDienThoaiContext db = new QLDienThoaiContext();
        [Route("admin/GetDonhang")]
        public IActionResult GetDonhang()
        {
            return View(db.Donhangs);
        }
        public IActionResult Accept(string id)
        {
            Donhang dh = db.Donhangs.FirstOrDefault(p => p.MaDon.Equals(id));
            dh.TinhTrang = "Đã xử lý";
            db.SaveChanges();
            return RedirectToAction("GetDonhang", "Admin");
        }
        public IActionResult Delete(string id)
        {
            Donhang dh = db.Donhangs.FirstOrDefault(p => p.MaDon.Equals(id));
            db.Donhangs.Remove(dh);
            db.SaveChanges();
            return RedirectToAction("GetDonhang", "Admin");
        }
    }
}
