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
    public class ThanhVienController : Controller
    {
        private readonly DPContext _context;

        public ThanhVienController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/ThanhVien
        public async Task<IActionResult> Index()
        {
            return View(await _context.tb_ThanhVien.ToListAsync());
        }

        // GET: Admin/ThanhVien/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thanhVienModel = await _context.tb_ThanhVien
                .FirstOrDefaultAsync(m => m.Id == id);
            if (thanhVienModel == null)
            {
                return NotFound();
            }

            return View(thanhVienModel);
        }

        // GET: Admin/ThanhVien/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/ThanhVien/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Ten,HinhAnh,GioiTinh,SDT,Email,TaiKhoan,MatKhau,TrangThai")] ThanhVienModel thanhVienModel)
        {
            if (ModelState.IsValid)
            {
<<<<<<< HEAD
                _context.Add(thanhVienModel);
=======


                thanhVienModel.HinhAnh = "hinh1";
                _context.Update(thanhVienModel);
                await _context.SaveChangesAsync();
                var path = Path.Combine(
                    Directory.GetCurrentDirectory(), "wwwroot/template_admin/images/thanhvien",
                    thanhVienModel.Id + "." + imageUpload.FileName.Split(".")[imageUpload.FileName.Split(".").Length - 1]);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await imageUpload.CopyToAsync(stream);
                }

                thanhVienModel.HinhAnh = thanhVienModel.Id + "." + imageUpload.FileName.Split(".")[imageUpload.FileName.Split(".").Length - 1];
                //thanhVienModel.MatKhau = EncMD5(matkhau);
                _context.Update(thanhVienModel);
>>>>>>> a93618663ad04386784ec38de2f51447886a3fba
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(thanhVienModel);
        }

        // GET: Admin/ThanhVien/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thanhVienModel = await _context.tb_ThanhVien.FindAsync(id);
            if (thanhVienModel == null)
            {
                return NotFound();
            }
            return View(thanhVienModel);
        }

        // POST: Admin/ThanhVien/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
<<<<<<< HEAD
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Ten,HinhAnh,GioiTinh,SDT,Email,TaiKhoan,MatKhau,TrangThai")] ThanhVienModel thanhVienModel)
=======

        public async Task<IActionResult> Edit(int id, [Bind("Id,Ten,HinhAnh,GioiTinh,SDT,Email,TaiKhoan,MatKhau,TrangThai")] ThanhVienModel thanhVienModel, IFormFile imageUpload, string matkhau)
>>>>>>> a93618663ad04386784ec38de2f51447886a3fba
        {
            if (id != thanhVienModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(thanhVienModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ThanhVienModelExists(thanhVienModel.Id))
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
            return View(thanhVienModel);
        }

        // GET: Admin/ThanhVien/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thanhVienModel = await _context.tb_ThanhVien
                .FirstOrDefaultAsync(m => m.Id == id);
            if (thanhVienModel == null)
            {
                return NotFound();
            }

            return View(thanhVienModel);
        }

        // POST: Admin/ThanhVien/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var thanhVienModel = await _context.tb_ThanhVien.FindAsync(id);
            _context.tb_ThanhVien.Remove(thanhVienModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ThanhVienModelExists(int id)
        {
            return _context.tb_ThanhVien.Any(e => e.Id == id);
        }
    }
<<<<<<< HEAD
=======

>>>>>>> a93618663ad04386784ec38de2f51447886a3fba
}
