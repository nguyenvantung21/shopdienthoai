using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopPhone.Models;
using ShopPhone.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace ShopPhone.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminSanphamController : Controller
    {
        QLDienThoaiContext db = new QLDienThoaiContext();
        [Route("admin/create")]
        public IActionResult Index()
        {
            return View(db.Sanphams);
        }
        [Route("admin/GetSanPham")]
        public IActionResult GetSanPham()
        {
            return View(db.Sanphams);
        }
        [HttpGet]
        [Route("admin/create")]
        public IActionResult Create()
        {
            SpViewModel ds1 = new SpViewModel();
            return View(ds1);
        }
        [HttpPost]
        [Route("admin/create")]
        public IActionResult Create(Sanpham sp, IFormFile fileUpload)
        {
            
            if (fileUpload != null)
            {
                sp.MaSanPham = "SP" + db.Sanphams.Count() + 1;
                String filepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", fileUpload.FileName);
                using (var file = new FileStream(filepath, FileMode.Create))
                {
                    fileUpload.CopyTo(file);
                }
                sp.Anh = fileUpload.FileName;
                Sanpham s = sp;
                db.Sanphams.Add(s);
                db.SaveChanges();
                //TempData["msgcreate"] = "<script>alert('Thêm sản phẩm thành công');</script>";
            }
            return RedirectToAction("GetSanPham", "Admin");
        }
        [HttpGet]
        [Route("admin/edit")]
        public IActionResult Edit(string id)
        {
            SpViewModel ds1 = new SpViewModel();
            ViewBag.ID = id;
            return View(ds1);
        }
        [HttpPost]
        [Route("admin/edit")]
        public IActionResult Edit(String id, Sanpham sp, IFormFile fileUpload)
        {
            if (fileUpload != null)
            {
                Sanpham sp1 = db.Sanphams.FirstOrDefault(p => p.MaSanPham.Equals(sp.MaSanPham));
                db.Sanphams.Remove(sp1);
                String filepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", fileUpload.FileName);
                using (var file = new FileStream(filepath, FileMode.Create))
                {
                    fileUpload.CopyTo(file);
                }
                sp.Anh = fileUpload.FileName;
                Sanpham s = sp;
                db.Sanphams.Add(s);
                db.SaveChanges();
                TempData["msgcreate"] = "<script>alert('Sửa sản phẩm thành công');</script>";
            }
            return RedirectToAction("GetSanPham", "Admin");
        }
        public IActionResult Delete(string id)
        {
            var temp = db.Sanphams.FirstOrDefault(o => o.MaSanPham.Equals(id));
            if(temp != null)
            {
                db.Sanphams.Remove(temp);
                db.SaveChanges();
                TempData["msgdelete"] = "<script>alert('Xóa sản phẩm thành công');</script>";
                return RedirectToAction("GetSanPham", "Admin");
            }
            return Ok(404);
        }
    }
}
