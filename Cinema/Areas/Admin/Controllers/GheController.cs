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
            ViewBag.ListGhe = _context.tb_Ghe.ToList();
            base.OnActionExecuted(context);
        }

        // GET: Admin/Ghe
        public async Task<IActionResult> Index(int? id)
        {
            ViewBag.ListHang = _context.tb_HangGhe.ToList();
            GheModel ghe = null;
            if (id != null)
            {
                ghe = await _context.tb_Ghe.FirstOrDefaultAsync(m => m.Id == id);
            }
            return View(ghe);
        }

        // GET: Admin/Ghe/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gheModel = await _context.tb_Ghe
                .Include(g => g.Hang)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gheModel == null)
            {
                return NotFound();
            }

            return View(gheModel);
        }

        // GET: Admin/Ghe/Create
        public IActionResult Create()
        {
            ViewData["MaHangGhe"] = new SelectList(_context.tb_HangGhe, "Id", "TenHang");
            return View();
        }

        // POST: Admin/Ghe/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TenGhe,TrangThai,MaHangGhe")] GheModel gheModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gheModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaHangGhe"] = new SelectList(_context.tb_HangGhe, "Id", "TenHang", gheModel.MaHangGhe);
            return View(gheModel);
        }

        // GET: Admin/Ghe/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gheModel = await _context.tb_Ghe.FindAsync(id);
            if (gheModel == null)
            {
                return NotFound();
            }
            ViewData["MaHangGhe"] = new SelectList(_context.tb_HangGhe, "Id", "TenHang", gheModel.MaHangGhe);
            return View(gheModel);
        }

        // POST: Admin/Ghe/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TenGhe,TrangThai,MaHangGhe")] GheModel gheModel)
        {
            if (id != gheModel.Id)
            {
                return NotFound();
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
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaHangGhe"] = new SelectList(_context.tb_HangGhe, "Id", "TenHang", gheModel.MaHangGhe);
            return View(gheModel);
        }

        // GET: Admin/Ghe/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gheModel = await _context.tb_Ghe
                .Include(g => g.Hang)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gheModel == null)
            {
                return NotFound();
            }

            return View(gheModel);
        }

        // POST: Admin/Ghe/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gheModel = await _context.tb_Ghe.FindAsync(id);
            _context.tb_Ghe.Remove(gheModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GheModelExists(int id)
        {
            return _context.tb_Ghe.Any(e => e.Id == id);
        }
    }
}
