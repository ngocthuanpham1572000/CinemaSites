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
    public class ThanhVienController : Controller
    {
        private readonly DPContext _context;

        public ThanhVienController(DPContext context)
        {
            _context = context;
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if(Request.QueryString.Value.IndexOf("s_name") < 0)
            {
                ViewBag.ListTV = (from n in _context.tb_ThanhVien where n.TrangThai == true select n).ToList();
            }
            base.OnActionExecuted(context);
        }

        // GET: Admin/ThanhVien
        public async Task<IActionResult> Index(int? id,string? s_name,string? s_stt)
        {
           ThanhVienModel thanhVien = null;
            if(id != null)
            {
                thanhVien = await _context.tb_ThanhVien.FirstOrDefaultAsync(m => m.Id == id && m.TrangThai == true);
            }
            if(s_name != null)
            {
                if(s_stt == null)
                {
                    ViewBag.ListTV = (from m in _context.tb_ThanhVien
                                     where m.Ten.IndexOf(s_name) >= 0
                                     select m).ToList(); 
                }
                else
                {
                    ViewBag.ListTV = (from m in _context.tb_ThanhVien
                                      where m.Ten.IndexOf(s_name) >= 0
                                      && m.TrangThai == Convert.ToBoolean(s_stt)
                                      select m).ToList();
                }
            }
            else
            {
                ViewBag.ListTV = (from n in _context.tb_ThanhVien where n.TrangThai == true select n).ToList();
            }
            return View(thanhVien);
        }

        // GET: Admin/ThanhVien/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var thanhVienModel = await _context.tb_ThanhVien
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (thanhVienModel == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(thanhVienModel);
        //}

        // GET: Admin/ThanhVien/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        // POST: Admin/ThanhVien/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Ten,HinhAnh,GioiTinh,SDT,Email,TaiKhoan,MatKhau,TrangThai")] ThanhVienModel thanhVienModel,IFormFile ful,string matkhau)
        {
            if (ModelState.IsValid)
            {
                thanhVienModel.MatKhau = StringProcessing.CreateMD5Hash(matkhau);
                _context.Add(thanhVienModel);
                await _context.SaveChangesAsync();
                var path = Path.Combine(
                 Directory.GetCurrentDirectory(), "wwwroot/template_admin/images/thanhvien",
                 thanhVienModel.Id + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1]);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await ful.CopyToAsync(stream);
                }
                thanhVienModel.HinhAnh = thanhVienModel.Id + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                _context.Update(thanhVienModel);
                await _context.SaveChangesAsync();
                

            }
            return View("Index");
        }

        // GET: Admin/ThanhVien/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var thanhVienModel = await _context.tb_ThanhVien.FindAsync(id);
        //    if (thanhVienModel == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(thanhVienModel);
        //}

        // POST: Admin/ThanhVien/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Ten,HinhAnh,GioiTinh,SDT,Email,TaiKhoan,MatKhau,TrangThai")] ThanhVienModel thanhVienModel,IFormFile ful,string matkhau)
        {
            if (id != thanhVienModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var matkhauMD5 = from mk in _context.tb_ThanhVien
                                               where mk.Id == id
                                                select mk.MatKhau;
                    if (matkhau.Equals(matkhauMD5.ToString()))
                    {
                        thanhVienModel.MatKhau = matkhauMD5.ToString();
                    }
                    else
                    {
                        thanhVienModel.MatKhau = StringProcessing.CreateMD5Hash(matkhau);
                    }
                    _context.Update(thanhVienModel);
                    if (ful != null)
                    {
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/template_admin/images/thanhvien", thanhVienModel.HinhAnh);
                        System.IO.File.Delete(path);
                        path = Path.Combine(
                            Directory.GetCurrentDirectory(), "wwwroot/template_admin/images/thanhvien",
                           thanhVienModel.Id + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1]);
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await ful.CopyToAsync(stream);
                        }
                        thanhVienModel.HinhAnh = thanhVienModel.Id + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
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
            }
            return View("Index");
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
}
