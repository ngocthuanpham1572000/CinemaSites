using Cinema.Areas.Admin.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Controllers
{
    public class CinemaController : Controller
    {
        private readonly DPContext _context;

        public CinemaController(DPContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Cinema_List()
        {
            var lstCumRap = (from l in _context.tb_RapPhim
                             where l.TrangThai == true
                             select l).ToList();


            return View(lstCumRap);
        }

        public async Task<IActionResult> Cinema_Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cumRap = await _context.tb_RapPhim.FirstOrDefaultAsync(m => m.Id == id);
            if (cumRap == null)
            {
                return NotFound();
            }

            return View(cumRap);
        }

        public IActionResult Cinema_Map()
        {
            return View();
        }
    }
}
