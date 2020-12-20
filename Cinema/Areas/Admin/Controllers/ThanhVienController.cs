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
using System.Security.Cryptography;
using System.Text;

namespace Cinema.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ThanhVienController : Controller
    {
        private readonly DPContext _context;

        //public static string EncMD5(string password)
        //{
        //    MD5 md5 = new MD5CryptoServiceProvider();
        //    UTF8Encoding encoder = new UTF8Encoding();
        //    Byte[] originalBytes = encoder.GetBytes(password);
        //    Byte[] encodedBytes = md5.ComputeHash(originalBytes);
        //    password = BitConverter.ToString(encodedBytes).Replace("-", "");
        //    var result = password.ToLower();
        //    return result;
        //}

        public ThanhVienController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/ThanhVienModels
        public async Task<IActionResult> Index(string ten)
        {
            var thanhvien = from n in _context.tb_ThanhVien select n;
            if (!String.IsNullOrEmpty(ten))
            {
                thanhvien = thanhvien.Where(y => y.Ten.Contains(ten));
            }
            thanhvien = thanhvien.Where(trangthai => trangthai.TrangThai == 1);
            return View(await thanhvien.ToListAsync());
        }

        // GET: Admin/ThanhVienModels/Details/5
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

        // GET: Admin/ThanhVienModels/Create
        public IActionResult Create()
        {
            return View();
        }


        // POST: Admin/ThanhVienModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Ten,HinhAnh,GioiTinh,SDT,Email,TaiKhoan,MatKhau,TrangThai")] ThanhVienModel thanhVienModel, IFormFile imageUpload, string matkhau)
        {
            if (ModelState.IsValid)
            {


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
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(thanhVienModel);
        }

        // GET: Admin/ThanhVienModels/Edit/5
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

        // POST: Admin/ThanhVienModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]

        public async Task<IActionResult> Edit(int id, [Bind("Id,Ten,HinhAnh,GioiTinh,SDT,Email,TaiKhoan,MatKhau,TrangThai")] ThanhVienModel thanhVienModel, IFormFile imageUpload, string matkhau)
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
                    if (imageUpload != null)
                    {
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/template_admin/images/thanhvien", thanhVienModel.HinhAnh);
                        System.IO.File.Delete(path);
                        string ten = Path.GetFileNameWithoutExtension(imageUpload.FileName);
                        string duoi = Path.GetExtension(imageUpload.FileName);
                        path = Path.Combine(
                            Directory.GetCurrentDirectory(), "wwwroot/template_admin/images/thanhvien",
                              thanhVienModel.Id + "." + imageUpload.FileName.Split(".")[imageUpload.FileName.Split(".").Length - 1]);
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await imageUpload.CopyToAsync(stream);
                        }
                        thanhVienModel.HinhAnh = thanhVienModel.Id + "." + imageUpload.FileName.Split(".")[imageUpload.FileName.Split(".").Length - 1];

                        _context.Update(thanhVienModel);
                    }
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

        // GET: Admin/ThanhVienModels/Delete/5
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

        // POST: Admin/ThanhVienModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var thanhvienModel = await _context.tb_ThanhVien.FindAsync(id);
            _context.tb_ThanhVien.Remove(thanhvienModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

        private bool ThanhVienModelExists(int id)
        {
            return _context.tb_ThanhVien.Any(e => e.Id == id);
        }
    }

}
