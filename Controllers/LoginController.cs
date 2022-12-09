using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopPhone.Models;
using Newtonsoft.Json;
using System.Text.Json;

namespace ShopPhone.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("user") != null)
                return RedirectToAction("Index", "Home");
            else
                return View();
        }
        [HttpPost]
        public ActionResult Login(Khachhang temp)
        {
            QLDienThoaiContext db = new QLDienThoaiContext();
            Khachhang check = null;
            check = db.Khachhangs.SingleOrDefault(p => p.TaiKhoanKh == temp.TaiKhoanKh && p.MatKhau == temp.MatKhau);
            IEnumerable<Khachhang> te = db.Khachhangs;
            if(check != null)
            {

                var jsonresult = JsonConvert.SerializeObject(check, Formatting.Indented);
                HttpContext.Session.SetString("user", jsonresult);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["msg"] = "<script>alert('Sai tên tài khoản hoặc mật khẩu');</script>";
                return View("Login");
            }
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Khachhang newKH)
        {
            QLDienThoaiContext db = new QLDienThoaiContext();
            newKH.MaKhachHang = "KH" + db.Khachhangs.Count() + 1;
            bool check = true;
            foreach (var item in db.Khachhangs)
            {
                if (item.TaiKhoanKh == newKH.TaiKhoanKh)
                {
                    TempData["msg"] = "<script>alert('Tài khoản đã tồn tại');</script>";
                    check = false;
                    break;
                }
            }
            if (check)
            {
                db.Khachhangs.Add(newKH);
                db.SaveChanges();
                TempData["msg"] = "<script>alert('Đăng kí thành công');</script>";
            }
            return RedirectToAction("Login", "Login");
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("user");
            return RedirectToAction("Login", "Login");
        }
    }
}
