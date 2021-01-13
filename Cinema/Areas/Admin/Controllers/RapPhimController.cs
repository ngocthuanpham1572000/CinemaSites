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
using Microsoft.AspNetCore.Http;
using System.IO;

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

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (Request.QueryString.Value.IndexOf("s_name") < 0)
            {
                ViewBag.lstRapPhim = (from l in _context.tb_RapPhim
                                     where l.TrangThai == true
                                     select l).ToList();
            }
            base.OnActionExecuted(context);
        }

        // GET: Admin/RapPhim
        public async Task<IActionResult> Index(int? id, string? s_name)
        {
            RapPhimModel rapPhim = null;
            ViewBag.lstCumRap = (from l in _context.tb_CumRap
                                 select l).ToList();

            ViewBag.lstCumRap_Active = (from l in _context.tb_CumRap
                                        where l.TrangThai == true
                                        select l).ToList();

            if (id != null)
            {
                rapPhim = await _context.tb_RapPhim.FirstOrDefaultAsync(m => m.Id == id);
            }
            if (s_name != null)
            {
                ViewBag.lstRapPhim = (from p in _context.tb_RapPhim
                                     where p.TenRap.IndexOf(s_name) >= 0
                                     && p.TrangThai ==true
                                    

                                     select p).ToList();
            }
            else
            {
                ViewBag.lstRapPhim = (from p in _context.tb_RapPhim
                                     where p.TrangThai == true 
                                     
                                      select p).ToList();
            }
            return View(rapPhim);
        }

        // GET: Admin/RapPhim/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var rapPhimModel = await _context.tb_RapPhim
        //        .Include(r => r.CumRap)
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (rapPhimModel == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(rapPhimModel);
        //}

        // GET: Admin/RapPhim/Create
        //public IActionResult Create()
        //{
        //    ViewData["MaCumRap"] = new SelectList(_context.tb_CumRap, "Id", "TenCum");
        //    return View();
        //}

        // POST: Admin/RapPhim/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TenRap,DiaChi,HinhAnh,MaCumRap,TrangThai")] RapPhimModel rapPhimModel, IFormFile ful)
        {
            ViewBag.lstCumRap_Active = (from l in _context.tb_CumRap
                                        where l.TrangThai==true
                                 select l).ToList();
            rapPhimModel.TrangThai = true;
            rapPhimModel.HinhAnh = "noimg.jpg";
            if (ModelState.IsValid)
            {
               
                if (ful != null)
                {
                    _context.Add(rapPhimModel);
                    await _context.SaveChangesAsync();
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/pic_cinema",
                   rapPhimModel.Id + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1]);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await ful.CopyToAsync(stream);
                    }
                    rapPhimModel.HinhAnh = rapPhimModel.Id + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                    _context.Update(rapPhimModel);
                    await _context.SaveChangesAsync();
                    TempData["Success"] = "Thêm rạp " + rapPhimModel.TenRap + " thành công! ";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    TempData["Success"] = "Thất bại!";
                    return RedirectToAction(nameof(Index));

                }

               
               
            }
            ViewData["MaCumRap"] = new SelectList(_context.tb_CumRap, "Id", "TenCum", rapPhimModel.MaCumRap);
            return View("Index");
        }

        // GET: Admin/RapPhim/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var rapPhimModel = await _context.tb_RapPhim.FindAsync(id);
        //    if (rapPhimModel == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["MaCumRap"] = new SelectList(_context.tb_CumRap, "Id", "TenCum", rapPhimModel.MaCumRap);
        //    return View(rapPhimModel);
        //}

        // POST: Admin/RapPhim/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TenRap,DiaChi,HinhAnh,MaCumRap,TrangThai")] RapPhimModel rapPhimModel, IFormFile ful)
        {
            
            rapPhimModel.TrangThai = true;
            if (id != rapPhimModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                   
                    _context.Update(rapPhimModel);
                    if (ful != null)//Neu chon hinh cu
                    {
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/pic_cinema", rapPhimModel.HinhAnh);
                        System.IO.File.Delete(path);//Xoa hinh cu
                                                    //Them hinh moi
                        path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/pic_cinema",
                 rapPhimModel.Id + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1]);
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await ful.CopyToAsync(stream);
                        }
                        rapPhimModel.HinhAnh = rapPhimModel.Id + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                        _context.Update(rapPhimModel);
                        

                    }
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
                TempData["Success"] = "Chỉnh sửa rạp " + rapPhimModel.TenRap + " thành công! ";
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
