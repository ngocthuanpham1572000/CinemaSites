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
    public class LoaiPhimController : Controller
    {
        private readonly DPContext _context;

        public LoaiPhimController(DPContext context)
        {
            _context = context;
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (Request.QueryString.Value.IndexOf("str") < 0)
            {
                ViewBag.ListLoaiPhim = (from m in _context.tb_LoaiPhim
                                        where m.TrangThai  ==true
                                        select m).ToList();
            }
            base.OnActionExecuted(context);
        }

        // GET: Admin/LoaiPhim
        public async Task<IActionResult> Index(int? id,string? str)
        {
            LoaiPhimModel loaiPhimModel = null;
            if(id!=null)
            {
                 
                loaiPhimModel = await _context.tb_LoaiPhim.FirstOrDefaultAsync(m => m.Id == id);

            }   
            if(str!= null)
            {

                ViewBag.ListLoaiPhim = (from m in _context.tb_LoaiPhim
                                 where m.TenLoai.IndexOf(str) >= 0
                                 select m).ToList();
            }    
            return View(loaiPhimModel);
        }

        
       
     

        // POST: Admin/LoaiPhim/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<bool> Create([Bind("Id,TenLoai,TrangThai")] LoaiPhimModel loaiPhimModel)
        {
            if (ModelState.IsValid)
            {
                loaiPhimModel.TrangThai = true;
                _context.Add(loaiPhimModel);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        // GET: Admin/LoaiPhim/Edit/5
      

        // POST: Admin/LoaiPhim/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<bool> Edit(int id, [Bind("Id,TenLoai,TrangThai")] LoaiPhimModel loaiPhimModel)
        {
            if (id != loaiPhimModel.Id)
            {
                return false;
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loaiPhimModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoaiPhimModelExists(loaiPhimModel.Id))
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

        // GET: Admin/LoaiPhim/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiPhimModel = await _context.tb_LoaiPhim
                .FirstOrDefaultAsync(m => m.Id == id);
            if (loaiPhimModel == null)
            {
                return NotFound();
            }

            return View(loaiPhimModel);
        }

        // POST: Admin/LoaiPhim/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var loaiPhimModel = await _context.tb_LoaiPhim.FindAsync(id);
            _context.tb_LoaiPhim.Remove(loaiPhimModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoaiPhimModelExists(int id)
        {
            return _context.tb_LoaiPhim.Any(e => e.Id == id);
        }
    }
}
