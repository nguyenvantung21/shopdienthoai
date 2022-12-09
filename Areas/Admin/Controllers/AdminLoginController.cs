using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShopPhone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPhone.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminLoginController : Controller
    {
        [Route("admin/Login")]
        [HttpGet]
        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("admin") != null)
                return RedirectToAction("Home", "Admin");
            else
                return View();
        }
        [Route("admin/Login")]
        [HttpPost]
        public IActionResult Login(Nhanvien nv)
        {
            QLDienThoaiContext db = new QLDienThoaiContext();
            Nhanvien check = null;
            check = db.Nhanviens.SingleOrDefault(p => p.TaiKhoanNv == nv.TaiKhoanNv && p.MatKhau == nv.MatKhau);
            IEnumerable<Nhanvien> te = db.Nhanviens;
            if (check != null)
            {

                var jsonresult = JsonConvert.SerializeObject(check, Formatting.Indented);
                HttpContext.Session.SetString("admin", jsonresult);
                return RedirectToAction("Home", "Admin");
            }
            else
            {
                TempData["msg"] = "<script>alert('Sai tên tài khoản hoặc mật khẩu');</script>";
                return View("Login");
            }
        }
        [Route("admin/Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("admin");
            return RedirectToAction("Login", "Admin");
        }
    }
}
