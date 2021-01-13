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
    public class HangGheController : Controller
    {
        private readonly DPContext _context;

        public HangGheController(DPContext context)
        {
            _context = context;
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if(Request.QueryString.Value.IndexOf("s_name") < 0)
            {
                ViewBag.ListHangGhe = _context.tb_HangGhe.ToList();
            }
            
            base.OnActionExecuted(context);
        }

        // GET: Admin/HangGhe
        public async Task<IActionResult> Index(int? id, string? s_name)
        {
            ViewBag.ListPhong = _context.tb_Phong.Where(m => m.TrangThai == true).ToList();
            HangGheModel hangghe = null;
            if (id != null)
            {
                hangghe = await _context.tb_HangGhe.FirstOrDefaultAsync(n => n.Id == id);
            }
            if(s_name != null)
            {
                ViewBag.ListHangGhe = (from m in _context.tb_HangGhe where m.TenHang.IndexOf(s_name) >= 0 select m).ToList(); 
            }
            return View(hangghe);
        }

            // GET: Admin/HangGhe/Details/5
        //    public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var hangGheModel = await _context.tb_HangGhe
        //        .Include(h => h.Phong)
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (hangGheModel == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(hangGheModel);
        //}

        // GET: Admin/HangGhe/Create
        //public IActionResult Create()
        //{
        //    ViewData["MaPhong"] = new SelectList(_context.tb_Phong, "Id", "TenPhong");
        //    return View();
        //}

        // POST: Admin/HangGhe/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TenHang,MaPhong,TrangThai")] HangGheModel hangGheModel)
        {
            ViewBag.ListPhong = _context.tb_Phong.Where(m => m.TrangThai == true).ToList();

            if (ModelState.IsValid)
            {
                _context.Add(hangGheModel);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index", "HangGhe");
        }

        // GET: Admin/HangGhe/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var hangGheModel = await _context.tb_HangGhe.FindAsync(id);
        //    if (hangGheModel == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["MaPhong"] = new SelectList(_context.tb_Phong, "Id", "TenPhong", hangGheModel.MaPhong);
        //    return View(hangGheModel);
        //}

        // POST: Admin/HangGhe/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TenHang,MaPhong,TrangThai")] HangGheModel hangGheModel)
        {
            ViewBag.ListPhong = _context.tb_Phong.Where(m => m.TrangThai == true).ToList();

            if (id != hangGheModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hangGheModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HangGheModelExists(hangGheModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            return RedirectToAction("Index", "HangGhe");

        }

        // GET: Admin/HangGhe/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var hangGheModel = await _context.tb_HangGhe
        //        .Include(h => h.Phong)
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (hangGheModel == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(hangGheModel);
        //}

        //// POST: Admin/HangGhe/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var hangGheModel = await _context.tb_HangGhe.FindAsync(id);
        //    _context.tb_HangGhe.Remove(hangGheModel);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool HangGheModelExists(int id)
        {
            return _context.tb_HangGhe.Any(e => e.Id == id);
        }
    }
}
