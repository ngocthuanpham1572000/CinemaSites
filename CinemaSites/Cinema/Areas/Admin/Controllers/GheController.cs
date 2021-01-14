using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cinema.Areas.Admin.Data;
using Cinema.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Cinema.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GheController : Controller
    {
        private readonly DPContext _context;

        public GheController(DPContext context)
        {
            _context = context;
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (Request.QueryString.Value.IndexOf("TenHang") < 0)
            {
                ViewBag.ListGhe = _context.tb_Ghe.Where(m => m.TrangThai == true).ToList();

            }
            base.OnActionExecuted(context);
        }

        // GET: Admin/Ghe
        public async Task<IActionResult> Index(int? id, int? TenHang)
        {
            ViewBag.ListHangGhe = (from a in _context.tb_CumRap
                                   join b in _context.tb_RapPhim on a.Id equals b.MaCumRap
                                   join c in _context.tb_Phong on b.Id equals c.MaRap
                                   join d in _context.tb_HangGhe on c.Id equals d.MaPhong
                                   where a.TrangThai == true
                                   where b.TrangThai == true
                                   where c.TrangThai == true
                                   where d.TrangThai == true
                                   select new
                                   {
                                       Id = d.Id,
                                       Value = "Hàng " + d.TenHang + " - " + c.TenPhong + " - " + b.TenRap + " - " + a.TenCum
                                   }).ToList();
            //ViewBag.ListHangGhe = _context.tb_HangGhe.Where(m =>  m.TrangThai == true).ToList();
            GheModel ghe = null;
            if (id != null)
            {
                ghe = await _context.tb_Ghe.FirstOrDefaultAsync(n => n.Id == id);
            }
            if (TenHang != 0)
            {
                ViewBag.ListGhe = (from m in _context.tb_Ghe where m.MaHangGhe == TenHang select m).ToList();
            }
            return View(ghe);
        }

        // GET: Admin/Ghe/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var gheModel = await _context.tb_Ghe
        //        .Include(g => g.Hang)
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (gheModel == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(gheModel);
        //}

        // GET: Admin/Ghe/Create
        //public IActionResult Create()
        //{
        //    ViewData["MaHangGhe"] = new SelectList(_context.tb_HangGhe, "Id", "TenHang");
        //    return View();
        //}

        // POST: Admin/Ghe/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<bool> Create([Bind("Id,TenGhe,TrangThai,MaHangGhe")] GheModel gheModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gheModel);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        // GET: Admin/Ghe/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var gheModel = await _context.tb_Ghe.FindAsync(id);
        //    if (gheModel == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["MaHangGhe"] = new SelectList(_context.tb_HangGhe, "Id", "TenHang", gheModel.MaHangGhe);
        //    return View(gheModel);
        //}

        // POST: Admin/Ghe/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<bool> Edit(int id, [Bind("Id,TenGhe,TrangThai,MaHangGhe")] GheModel gheModel)
        {
            if (id != gheModel.Id)
            {
                return false;
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gheModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GheModelExists(gheModel.Id))
                    {
                        return false;
                    }
                    else
                    {
                        throw;
                    }
                }
                return true;
            }
            return false;
        }

        //// GET: Admin/Ghe/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var gheModel = await _context.tb_Ghe
        //        .Include(g => g.Hang)
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (gheModel == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(gheModel);
        //}

        // POST: Admin/Ghe/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var gheModel = await _context.tb_Ghe.FindAsync(id);
        //    _context.tb_Ghe.Remove(gheModel);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool GheModelExists(int id)
        {
            return _context.tb_Ghe.Any(e => e.Id == id);
        }
    }
}
