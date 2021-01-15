using Cinema.Areas.Admin.Data;
using Cinema.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Controllers
{
    public class HomeController : Controller
    {

        private readonly DPContext _context;
        public HomeController(DPContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var dsPhim = await (from a in _context.tb_Phim
                                where a.TrangThai == 1
                                select a).ToListAsync();
            ViewBag.lstPhimDangChieu = dsPhim;
            var dsPhimSC = await (from a in _context.tb_Phim
                                  where a.TrangThai == 2
                                  select a).ToListAsync();
            ViewBag.lstPhimSapChieu = dsPhimSC;
            var dpcontext = _context.tb_Phim.Include(p => p.lstSuatChieu);
            return View(await dpcontext.ToListAsync());
        }

        public IActionResult SignIn()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }




    }
}
