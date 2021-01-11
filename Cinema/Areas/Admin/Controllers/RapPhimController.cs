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
    public class RapPhimController : Controller
    {
        private readonly DPContext _context;

        public RapPhimController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/RapPhim
        public async Task<IActionResult> Index()
        {
            var dPContext = _context.tb_RapPhim.Include(r => r.CumRap);
            return View(await dPContext.ToListAsync());
        }

        // GET: Admin/RapPhim/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rapPhimModel = await _context.tb_RapPhim
                .Include(r => r.CumRap)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rapPhimModel == null)
            {
                return NotFound();
            }

            return View(rapPhimModel);
        }

        // GET: Admin/RapPhim/Create
        public IActionResult Create()
        {
            ViewData["MaCumRap"] = new SelectList(_context.tb_CumRap, "Id", "TenCum");
            return View();
        }

        // POST: Admin/RapPhim/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TenRap,DiaChi,HinhAnh,MaCumRap,TrangThai")] RapPhimModel rapPhimModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rapPhimModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaCumRap"] = new SelectList(_context.tb_CumRap, "Id", "TenCum", rapPhimModel.MaCumRap);
            return View(rapPhimModel);
        }

        // GET: Admin/RapPhim/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rapPhimModel = await _context.tb_RapPhim.FindAsync(id);
            if (rapPhimModel == null)
            {
                return NotFound();
            }
            ViewData["MaCumRap"] = new SelectList(_context.tb_CumRap, "Id", "TenCum", rapPhimModel.MaCumRap);
            return View(rapPhimModel);
        }

        // POST: Admin/RapPhim/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TenRap,DiaChi,HinhAnh,MaCumRap,TrangThai")] RapPhimModel rapPhimModel)
        {
            if (id != rapPhimModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rapPhimModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RapPhimModelExists(rapPhimModel.Id))
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
            ViewData["MaCumRap"] = new SelectList(_context.tb_CumRap, "Id", "TenCum", rapPhimModel.MaCumRap);
            return View(rapPhimModel);
        }

        // GET: Admin/RapPhim/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rapPhimModel = await _context.tb_RapPhim
                .Include(r => r.CumRap)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rapPhimModel == null)
            {
                return NotFound();
            }

            return View(rapPhimModel);
        }

        // POST: Admin/RapPhim/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rapPhimModel = await _context.tb_RapPhim.FindAsync(id);
            _context.tb_RapPhim.Remove(rapPhimModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RapPhimModelExists(int id)
        {
            return _context.tb_RapPhim.Any(e => e.Id == id);
        }
    }
}
