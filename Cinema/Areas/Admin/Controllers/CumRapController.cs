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
    public class CumRapController : Controller
    {
        private readonly DPContext _context;

        public CumRapController(DPContext context)
        {
            _context = context;
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (Request.QueryString.Value.IndexOf("s_name") < 0)
            {
                ViewBag.lstCumRap = (from l in _context.tb_CumRap
                                     where l.TrangThai == true
                                     select l).ToList();
            }
          
            base.OnActionExecuted(context);
        }

        // GET: Admin/CumRapModels
        public async Task<IActionResult> Index(int? id, string? s_name)
        {
            CumRapModel cumRap = null;
            if (id != null)
            {
                cumRap = await _context.tb_CumRap.FirstOrDefaultAsync(m => m.Id == id);
            }
            if (s_name != null)
            {
                ViewBag.lstCumRap = (from p in _context.tb_CumRap
                                     where p.TenCum.IndexOf(s_name) >= 0
                                      && p.TrangThai == true
                                     select p).ToList();
            }
            else
            {
                ViewBag.lstCumRap = (from l in _context.tb_CumRap
                                     where l.TrangThai == true
                                     select l).ToList();
            }
            return View(cumRap);
        }

        // GET: Admin/CumRapModels/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var cumRapModel = await _context.tb_CumRap
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (cumRapModel == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(cumRapModel);
        //}

        // GET: Admin/CumRapModels/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        // POST: Admin/CumRapModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<bool> Create([Bind("Id,TenCum,TrangThai")] CumRapModel cumRapModel)
        {
            cumRapModel.TrangThai = true;
            if (ModelState.IsValid)
            {
                _context.Add(cumRapModel);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        // GET: Admin/CumRapModels/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var cumRapModel = await _context.tb_CumRap.FindAsync(id);
        //    if (cumRapModel == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(cumRapModel);
        //}

        // POST: Admin/CumRapModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<bool> Edit(int id, [Bind("Id,TenCum,TrangThai")] CumRapModel cumRapModel)
        {
            if (id != cumRapModel.Id)
            {
                return false;
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cumRapModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CumRapModelExists(cumRapModel.Id))
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

        //GET: Admin/CumRapModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cumRapModel = await _context.tb_CumRap
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cumRapModel == null)
            {
                return NotFound();
            }

            return View(cumRapModel);
        }

        //POST: Admin/CumRapModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cumRapModel = await _context.tb_CumRap.FindAsync(id);
            //_context.tb_CumRap.Remove(cumRapModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CumRapModelExists(int id)
        {
            return _context.tb_CumRap.Any(e => e.Id == id);
        }
    }
}
