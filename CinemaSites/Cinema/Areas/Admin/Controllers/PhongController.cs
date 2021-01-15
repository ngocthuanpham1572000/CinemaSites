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
    public class PhongController : Controller
    {
        private readonly DPContext _context;

        public PhongController(DPContext context)
        {
            _context = context;
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if(Request.QueryString.Value.IndexOf("s_name_ph") < 0)
            {

                ViewBag.ListPh = (from n in _context.tb_Phong where n.TrangThai == true select n).ToList();
            }
            ViewBag.ListRap = (from n in _context.tb_RapPhim where n.TrangThai == true select n).ToList();

            base.OnActionExecuted(context);
        }

        // GET: Admin/Phongontroller
        public async Task<IActionResult> Index(int? id,string? s_name_ph,string? s_stt)
        {
            PhongModel phong = null;
            if(id != null)
            {
                phong = await _context.tb_Phong.FirstOrDefaultAsync(m => m.Id == id);
            }
            if(s_name_ph != null)
            {
                if(s_stt == null)
                {
                    ViewBag.ListPh = (from n in _context.tb_Phong where n.TenPhong.IndexOf(s_name_ph) >= 0 select n).ToList();
                }
                else
                {
                    ViewBag.ListPh = (from n in _context.tb_Phong where n.TenPhong.IndexOf(s_name_ph) >= 0 
                                      && n.TrangThai == Convert.ToBoolean(s_stt)
                                      select n).ToList();
                }    
            }
            else
            {
                ViewBag.ListPh = (from n in _context.tb_Phong where n.TrangThai == true select n).ToList();
            }
            return View(phong);
        }

        // GET: Admin/Phongontroller/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var phongModel = await _context.tb_Phong
        //        .Include(p => p.Rap)
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (phongModel == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(phongModel);
        //}

        // GET: Admin/Phongontroller/Create
        //public IActionResult Create()
        //{
        //    ViewData["MaRap"] = new SelectList(_context.tb_RapPhim, "Id", "DiaChi");
        //    return View();
        //}

        // POST: Admin/Phongontroller/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<bool> Create([Bind("Id,TenPhong,MaRap,TrangThai")] PhongModel phongModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(phongModel);
                await _context.SaveChangesAsync();
                return true;
            }
            
            return false;
        }

        // GET: Admin/Phongontroller/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var phongModel = await _context.tb_Phong.FindAsync(id);
        //    if (phongModel == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["MaRap"] = new SelectList(_context.tb_RapPhim, "Id", "DiaChi", phongModel.MaRap);
        //    return View(phongModel);
        //}

        // POST: Admin/Phongontroller/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<bool> Edit(int id, [Bind("Id,TenPhong,MaRap,TrangThai")] PhongModel phongModel)
        {
            if (id != phongModel.Id)
            {
                return false;
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

        // GET: Admin/Phongontroller/Delete/5
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

        // POST: Admin/Phongontroller/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var phongModel = await _context.tb_Phong.FindAsync(id);
            _context.tb_Phong.Remove(phongModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool PhongModelExists(int id)
        {
            return _context.tb_Phong.Any(e => e.Id == id);
        }
    }
}
