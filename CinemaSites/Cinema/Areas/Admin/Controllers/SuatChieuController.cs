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
    public class SuatChieuController : Controller
    {
        private readonly DPContext _context;

        public SuatChieuController(DPContext context)
        {
            _context = context;
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            ViewBag.ListSch = (from n in _context.tb_SuatChieu where n.TrangThai == true select n).ToList();
            ViewBag.ListPhim = (from n in _context.tb_Phim where n.TrangThai == 1 select n).ToList();
            ViewBag.ListPhong = (from n in _context.tb_Phong where n.TrangThai == true select n).ToList();

            base.OnActionExecuted(context);
        }

        // GET: Admin/SuatChieu
        public async Task<IActionResult> Index(int? id)
        {
            ViewBag.ListSch = (from n in _context.tb_SuatChieu where n.TrangThai == true select n).ToList();
            foreach (var item in ViewBag.ListSch)
            {
                if (item.ThoiGianBatDau < DateTime.Now && item.NgayChieu == DateTime.Now)
                {
                    item.TrangThai = false;
                    _context.Update(item);
                }
            }
            await _context.SaveChangesAsync();
            SuatChieuModel suatChieu = null;
            if(id != null)
            {
                suatChieu = await _context.tb_SuatChieu.FirstOrDefaultAsync(m => m.Id == id && m.TrangThai == true);
            }
            return View(suatChieu);
        }

  

        // GET: Admin/SuatChieu/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var suatChieuModel = await _context.tb_SuatChieu
        //        .Include(s => s.Phim)
        //        .Include(s => s.Phong)
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (suatChieuModel == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(suatChieuModel);
        //}

        // GET: Admin/SuatChieu/Create
        //public IActionResult Create()
        //{
        //    ViewData["MaPhim"] = new SelectList(_context.tb_Phim, "Id", "HinhAnh");
        //    ViewData["MaPhong"] = new SelectList(_context.tb_Phong, "Id", "TenPhong");
        //    return View();
        //}

        // POST: Admin/SuatChieu/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<bool> Create([Bind("Id,NgayChieu,ThoiGianBatDau,TrangThai,MaPhong,MaPhim")] SuatChieuModel suatChieuModel)
        {
            if (ModelState.IsValid)
            {
                suatChieuModel.TrangThai = true;
                _context.Add(suatChieuModel);
                await _context.SaveChangesAsync();
                return true;
                
            }
            return false;
        }

        // GET: Admin/SuatChieu/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var suatChieuModel = await _context.tb_SuatChieu.FindAsync(id);
        //    if (suatChieuModel == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["MaPhim"] = new SelectList(_context.tb_Phim, "Id", "HinhAnh", suatChieuModel.MaPhim);
        //    ViewData["MaPhong"] = new SelectList(_context.tb_Phong, "Id", "TenPhong", suatChieuModel.MaPhong);
        //    return View(suatChieuModel);
        //}

        // POST: Admin/SuatChieu/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<bool> Edit(int id, [Bind("Id,NgayChieu,ThoiGianBatDau,TrangThai,MaPhong,MaPhim")] SuatChieuModel suatChieuModel)
        {
            if (id != suatChieuModel.Id)
            {
                return false;
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(suatChieuModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SuatChieuModelExists(suatChieuModel.Id))
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
            //ViewData["MaPhim"] = new SelectList(_context.tb_Phim, "Id", "HinhAnh", suatChieuModel.MaPhim);
            //ViewData["MaPhong"] = new SelectList(_context.tb_Phong, "Id", "TenPhong", suatChieuModel.MaPhong);
            return false;
        }

        // GET: Admin/SuatChieu/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suatChieuModel = await _context.tb_SuatChieu
                .Include(s => s.Phim)
                .Include(s => s.Phong)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (suatChieuModel == null)
            {
                return NotFound();
            }

            return View(suatChieuModel);
        }

        // POST: Admin/SuatChieu/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var suatChieuModel = await _context.tb_SuatChieu.FindAsync(id);
        //    _context.tb_SuatChieu.Remove(suatChieuModel);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool SuatChieuModelExists(int id)
        {
            return _context.tb_SuatChieu.Any(e => e.Id == id);
        }
    }
}
