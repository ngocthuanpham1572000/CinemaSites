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
    public class CumRapController : Controller
    {
        private readonly DPContext _context;

        public CumRapController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/CumRap
        public async Task<IActionResult> Index()
        {
            return View(await _context.tb_CumRap.ToListAsync());
        }

        // GET: Admin/CumRap/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cumRapModel = await _context.tb_CumRap
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cumRapModel == null)
            {
                return NotFound();
            }

            return View(cumRapModel);
        }

        // GET: Admin/CumRap/Create
        public IActionResult Create()
        {
            

            return View();
        }

        // POST: Admin/CumRap/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TenCum,TrangThai")] CumRapModel cumRapModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cumRapModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cumRapModel);
        }

        // GET: Admin/CumRap/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cumRapModel = await _context.tb_CumRap.FindAsync(id);
            if (cumRapModel == null)
            {
                return NotFound();
            }
            return View(cumRapModel);
        }

        // POST: Admin/CumRap/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TenCum,TrangThai")] CumRapModel cumRapModel)
        {
            if (id != cumRapModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cumRapModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CumRapModelExists(cumRapModel.Id))
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
            return View(cumRapModel);
        }

        // GET: Admin/CumRap/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cumRapModel = await _context.tb_CumRap
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cumRapModel == null)
            {
                return NotFound();
            }

            return View(cumRapModel);
        }

        // POST: Admin/CumRap/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cumRapModel = await _context.tb_CumRap.FindAsync(id);
            _context.tb_CumRap.Remove(cumRapModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CumRapModelExists(int id)
        {
            return _context.tb_CumRap.Any(e => e.Id == id);
        }
    }
}
