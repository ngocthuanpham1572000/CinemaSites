using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cinema.Areas.Admin.Data;
using Cinema.Areas.Admin.Models;

namespace Cinema.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class VeController : Controller
    {
        private readonly DPContext _context;

        public VeController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/VeModels
        public async Task<IActionResult> Index()
        {
            var dPContext = _context.tb_Ve.Include(v => v.Ghe).Include(v => v.HoaDon).Include(v => v.SuatChieu);
            return View(await dPContext.ToListAsync());
        }

        // GET: Admin/VeModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var veModel = await _context.tb_Ve
                .Include(v => v.Ghe)
                .Include(v => v.HoaDon)
                .Include(v => v.SuatChieu)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (veModel == null)
            {
                return NotFound();
            }

            return View(veModel);
        }

        // GET: Admin/VeModels/Create
        public IActionResult Create()
        {
            ViewData["MaGhe"] = new SelectList(_context.tb_Ghe, "Id", "Id");
            ViewData["MaHoaDon"] = new SelectList(_context.tb_HoaDon, "Id", "Id");
            ViewData["MaSuat"] = new SelectList(_context.tb_SuatChieu, "Id", "Id");
            return View();
        }

        // POST: Admin/VeModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Gia,MaHoaDon,MaGhe,MaSuat,TrangThai")] VeModel veModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(veModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaGhe"] = new SelectList(_context.tb_Ghe, "Id", "Id", veModel.MaGhe);
            ViewData["MaHoaDon"] = new SelectList(_context.tb_HoaDon, "Id", "Id", veModel.MaHoaDon);
            ViewData["MaSuat"] = new SelectList(_context.tb_SuatChieu, "Id", "Id", veModel.MaSuat);
            return View(veModel);
        }

        // GET: Admin/VeModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var veModel = await _context.tb_Ve.FindAsync(id);
            if (veModel == null)
            {
                return NotFound();
            }
            ViewData["MaGhe"] = new SelectList(_context.tb_Ghe, "Id", "Id", veModel.MaGhe);
            ViewData["MaHoaDon"] = new SelectList(_context.tb_HoaDon, "Id", "Id", veModel.MaHoaDon);
            ViewData["MaSuat"] = new SelectList(_context.tb_SuatChieu, "Id", "Id", veModel.MaSuat);
            return View(veModel);
        }

        // POST: Admin/VeModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Gia,MaHoaDon,MaGhe,MaSuat,TrangThai")] VeModel veModel)
        {
            if (id != veModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(veModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VeModelExists(veModel.Id))
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
            ViewData["MaGhe"] = new SelectList(_context.tb_Ghe, "Id", "Id", veModel.MaGhe);
            ViewData["MaHoaDon"] = new SelectList(_context.tb_HoaDon, "Id", "Id", veModel.MaHoaDon);
            ViewData["MaSuat"] = new SelectList(_context.tb_SuatChieu, "Id", "Id", veModel.MaSuat);
            return View(veModel);
        }

        // GET: Admin/VeModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var veModel = await _context.tb_Ve
                .Include(v => v.Ghe)
                .Include(v => v.HoaDon)
                .Include(v => v.SuatChieu)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (veModel == null)
            {
                return NotFound();
            }

            return View(veModel);
        }

        // POST: Admin/VeModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var veModel = await _context.tb_Ve.FindAsync(id);
            _context.tb_Ve.Remove(veModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VeModelExists(int id)
        {
            return _context.tb_Ve.Any(e => e.Id == id);
        }
    }
}
