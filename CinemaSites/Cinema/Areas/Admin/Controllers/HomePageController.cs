using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Areas.Admin.Data;
using Cinema.Areas.Admin.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Session;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json.Linq;

namespace Cinema.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomePageController : Controller
    {
        private readonly DPContext _context;



        public HomePageController(DPContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index([Bind("TaiKhoan", "MatKhau")] AdminModel member)
        {
            var r = _context.tb_Admin.Where(m => (m.TaiKhoan.Equals(member.TaiKhoan) && m.MatKhau.Equals(StringProcessing.CreateMD5Hash(member.MatKhau))) && m.TrangThai == true).ToList();
            if (r.Count > 0)
            {
                var str = JsonConvert.SerializeObject(member);
                HttpContext.Session.SetString("user", str);
                JObject us = JObject.Parse(HttpContext.Session.GetString("user"));
                AdminModel mem = new AdminModel();
                mem.TaiKhoan = us.SelectToken("TaiKhoan").ToString();
                mem.MatKhau = us.SelectToken("MatKhau").ToString();
                return View(mem);
            }
            return RedirectToAction("Login", "HomePage");
        }


        public IActionResult Logout()
        {
            return RedirectToAction("Login", "HomePage");
        }
    }
}
