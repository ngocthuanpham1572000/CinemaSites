using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cinema.Areas.Admin.Data;
using Cinema.Areas.Admin.Models;
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

        // GET: Admin/RapPhim
        public async Task<IActionResult> Index()
            {
            var Rap = from m in _context.tb_RapPhim
                      select m;
            Rap = Rap.Include(r => r.CumRap);
            Rap = Rap.Where(x => x.TrangThai == 1);

            return View(await Rap.ToListAsync());

              
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
            var CumRap = from m in _context.tb_CumRap
                      select m;
            CumRap = CumRap.Where(x => x.TrangThai == 1);

            ViewBag.ListCumRap = CumRap.ToList();
            return View();
        }

        // POST: Admin/RapPhim/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TenRap,DiaChi,HinhAnh,MaCumRap,TrangThai")] RapPhimModel rapPhimModel, IFormFile ImageUpload)
        {
            var CumRap = from m in _context.tb_CumRap
                         select m;
            CumRap = CumRap.Where(x => x.TrangThai == 1);

            ViewBag.ListCumRap = CumRap.ToList();
            rapPhimModel.HinhAnh = "noimage.jpg";
            if (ModelState.IsValid)
            {
                _context.Add(rapPhimModel);
                await _context.SaveChangesAsync();


                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/template_admin/images/rapphim",
                    rapPhimModel.Id + "." + ImageUpload.FileName.Split(".")[ImageUpload.FileName.Split(".").Length - 1]);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await ImageUpload.CopyToAsync(stream);
                }
                rapPhimModel.HinhAnh = rapPhimModel.Id + "." + ImageUpload.FileName.Split(".")[ImageUpload.FileName.Split(".").Length - 1];
                _context.Update(rapPhimModel);
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
            var CumRap = from m in _context.tb_CumRap
                         select m;
            CumRap = CumRap.Where(x => x.TrangThai == 1);

            ViewBag.ListCumRap = CumRap.ToList();
            return View(rapPhimModel);
        }

        // POST: Admin/RapPhim/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TenRap,DiaChi,HinhAnh,MaCumRap,TrangThai")] RapPhimModel rapPhimModel, IFormFile ImageUpload)
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
                        if (ImageUpload != null)
                        {
                            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/template_admin/images/rapphim", rapPhimModel.HinhAnh);
                            System.IO.File.Delete(path);
                            string ten = Path.GetFileNameWithoutExtension(ImageUpload.FileName);
                            string duoi = Path.GetExtension(ImageUpload.FileName);
                            path = Path.Combine(
                                Directory.GetCurrentDirectory(), "wwwroot/template_admin/images/rapphim",
                                  rapPhimModel.Id + "." + ImageUpload.FileName.Split(".")[ImageUpload.FileName.Split(".").Length - 1]);
                            using (var stream = new FileStream(path, FileMode.Create))
                            {
                                await ImageUpload.CopyToAsync(stream);
                            }
                            rapPhimModel.HinhAnh = rapPhimModel.Id + "." + ImageUpload.FileName.Split(".")[ImageUpload.FileName.Split(".").Length - 1];

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
            ViewData["MaCumRap"] = new SelectList(_context.tb_CumRap, "Id", "TenCum", rapPhimModel.MaCumRap);

            return View(rapPhimModel);
        }

        // POST: Admin/RapPhim/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rapPhimModel = await _context.tb_RapPhim.FindAsync(id);
            rapPhimModel.TrangThai = 0;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RapPhimModelExists(int id)
        {
            return _context.tb_RapPhim.Any(e => e.Id == id);
        }
    }
}
