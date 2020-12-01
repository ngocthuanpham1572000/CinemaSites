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
    public class HoaDonController : Controller
    {
        private readonly DPContext _context;

        public HoaDonController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/HoaDonModels
        public async Task<IActionResult> Index()
        {
            var dPContext = _context.tb_HoaDon.Include(h => h.ThanhVien);
            return View(await dPContext.ToListAsync());
        }

        // GET: Admin/HoaDonModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoaDonModel = await _context.tb_HoaDon
                .Include(h => h.ThanhVien)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hoaDonModel == null)
            {
                return NotFound();
            }

            return View(hoaDonModel);
        }

        // GET: Admin/HoaDonModels/Create
        public IActionResult Create()
        {
            ViewData["MaThanhVien"] = new SelectList(_context.tb_ThanhVien, "Id", "Email");
            return View();
        }

        // POST: Admin/HoaDonModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NgayLap,TongTien,MaThanhVien,TrangThai")] HoaDonModel hoaDonModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hoaDonModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaThanhVien"] = new SelectList(_context.tb_ThanhVien, "Id", "Email", hoaDonModel.MaThanhVien);
            return View(hoaDonModel);
        }

        // GET: Admin/HoaDonModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoaDonModel = await _context.tb_HoaDon.FindAsync(id);
            if (hoaDonModel == null)
            {
                return NotFound();
            }
            ViewData["MaThanhVien"] = new SelectList(_context.tb_ThanhVien, "Id", "Email", hoaDonModel.MaThanhVien);
            return View(hoaDonModel);
        }

        // POST: Admin/HoaDonModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NgayLap,TongTien,MaThanhVien,TrangThai")] HoaDonModel hoaDonModel)
        {
            if (id != hoaDonModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hoaDonModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HoaDonModelExists(hoaDonModel.Id))
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
            ViewData["MaThanhVien"] = new SelectList(_context.tb_ThanhVien, "Id", "Email", hoaDonModel.MaThanhVien);
            return View(hoaDonModel);
        }

        // GET: Admin/HoaDonModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoaDonModel = await _context.tb_HoaDon
                .Include(h => h.ThanhVien)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hoaDonModel == null)
            {
                return NotFound();
            }

            return View(hoaDonModel);
        }

        // POST: Admin/HoaDonModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hoaDonModel = await _context.tb_HoaDon.FindAsync(id);
            _context.tb_HoaDon.Remove(hoaDonModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HoaDonModelExists(int id)
        {
            return _context.tb_HoaDon.Any(e => e.Id == id);
        }
    }
}
