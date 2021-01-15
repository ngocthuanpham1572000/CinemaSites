using Cinema.Areas.Admin.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Controllers
{
    public class MovieController : Controller
    {
        private readonly DPContext _context;
        public MovieController(DPContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Movie_Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var phimModel = await _context.tb_Phim
                .Include(p => p.Loai)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (phimModel == null)
            {
                return NotFound();
            }

            return View(phimModel);
        }

        public async Task<IActionResult> MovieList_NowPlaying()
        {
            var dsPhim = await (from a in _context.tb_Phim
                                where a.TrangThai == 1
                                select a).ToListAsync();

            return View(dsPhim);
        }



        public async Task<IActionResult> MovieList_CommingSoon()
        {
            var dsPhim = await (from a in _context.tb_Phim
                                where a.TrangThai == 2
                                select a).ToListAsync();

            return View(dsPhim);
        }

    }
}
