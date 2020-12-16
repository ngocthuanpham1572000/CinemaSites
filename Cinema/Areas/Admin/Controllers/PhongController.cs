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
    public class PhongController : Controller
    {
        private readonly DPContext _context;

        public PhongController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/Phong
        public async Task<IActionResult> Index()
        {
            var Phong = from m in _context.tb_Phong
                          select m;
            Phong = Phong.Include(r => r.Rap);
            Phong = Phong.Where(x => x.TrangThai == 1);
          
            return View(await Phong.ToListAsync());
        }

        // GET: Admin/Phong/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phongModel = await _context.tb_Phong
                .Include(p => p.Rap)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (phongModel == null)
            {
                return NotFound();
            }

            return View(phongModel);
        }

        // GET: Admin/Phong/Create
        public IActionResult Create()
        {
            var RapPhim = from m in _context.tb_RapPhim
                         select m;
            RapPhim = RapPhim.Where(x => x.TrangThai == 1);

            ViewBag.ListRap = RapPhim.ToList();
            return View();
        }

        // POST: Admin/Phong/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TenPhong,MaRap,TrangThai")] PhongModel phongModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(phongModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaRap"] = new SelectList(_context.tb_RapPhim, "Id", "DiaChi", phongModel.MaRap);
            return View(phongModel);
        }

        // GET: Admin/Phong/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var RapPhim = from m in _context.tb_RapPhim
                          select m;
            RapPhim = RapPhim.Where(x => x.TrangThai == 1);

            ViewBag.ListRap = RapPhim.ToList();
            var phongModel = await _context.tb_Phong.FindAsync(id);
            if (phongModel == null)
            {
                return NotFound();
            }
            ViewData["MaRap"] = new SelectList(_context.tb_RapPhim, "Id", "DiaChi", phongModel.MaRap);
            return View(phongModel);
        }

        // POST: Admin/Phong/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TenPhong,MaRap,TrangThai")] PhongModel phongModel)
        {
            if (id != phongModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(phongModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhongModelExists(phongModel.Id))
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
            ViewData["MaRap"] = new SelectList(_context.tb_RapPhim, "Id", "DiaChi", phongModel.MaRap);
            return View(phongModel);
        }

        // GET: Admin/Phong/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phongModel = await _context.tb_Phong
                .Include(p => p.Rap)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (phongModel == null)
            {
                return NotFound();
            }

            return View(phongModel);
        }

        // POST: Admin/Phong/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var phongModel = await _context.tb_Phong.FindAsync(id);
            phongModel.TrangThai = 0;
            await _context.SaveChangesAsync();
            
            return RedirectToAction(nameof(Index));
        }

        private bool PhongModelExists(int id)
        {
            return _context.tb_Phong.Any(e => e.Id == id);
        }
    }
}
