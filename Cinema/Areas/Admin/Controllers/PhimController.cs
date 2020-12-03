﻿using System;
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
    public class PhimController : Controller
    {
        private readonly DPContext _context;

        public PhimController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/Phim
        public async Task<IActionResult> Index()
        {
            var dPContext = _context.tb_Phim.Include(p => p.Loai);
            return View(await dPContext.ToListAsync());
        }

        // GET: Admin/Phim/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phimModel = await _context.tb_Phim
                .Include(p => p.Loai)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (phimModel == null)
            {
                return NotFound();
            }

            return View(phimModel);
        }

        // GET: Admin/Phim/Create
        public IActionResult Create()
        {
            ViewData["MaLoai"] = new SelectList(_context.tb_LoaiPhim, "Id", "TenLoai");
            return View();
        }

        // POST: Admin/Phim/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TenPhim,ThoiLuong,DaoDien,DienVien,QuocGia,Mota,HinhAnh,Trailer,NgayPhatHanh,MaLoai,TrangThai")] PhimModel phimModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(phimModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaLoai"] = new SelectList(_context.tb_LoaiPhim, "Id", "TenLoai", phimModel.MaLoai);
            return View(phimModel);
        }

        // GET: Admin/Phim/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phimModel = await _context.tb_Phim.FindAsync(id);
            if (phimModel == null)
            {
                return NotFound();
            }
            ViewData["MaLoai"] = new SelectList(_context.tb_LoaiPhim, "Id", "TenLoai", phimModel.MaLoai);
            return View(phimModel);
        }

        // POST: Admin/Phim/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TenPhim,ThoiLuong,DaoDien,DienVien,QuocGia,Mota,HinhAnh,Trailer,NgayPhatHanh,MaLoai,TrangThai")] PhimModel phimModel)
        {
            if (id != phimModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(phimModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhimModelExists(phimModel.Id))
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
            ViewData["MaLoai"] = new SelectList(_context.tb_LoaiPhim, "Id", "TenLoai", phimModel.MaLoai);
            return View(phimModel);
        }

        // GET: Admin/Phim/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phimModel = await _context.tb_Phim
                .Include(p => p.Loai)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (phimModel == null)
            {
                return NotFound();
            }

            return View(phimModel);
        }

        // POST: Admin/Phim/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var phimModel = await _context.tb_Phim.FindAsync(id);
            _context.tb_Phim.Remove(phimModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhimModelExists(int id)
        {
            return _context.tb_Phim.Any(e => e.Id == id);
        }
    }
}