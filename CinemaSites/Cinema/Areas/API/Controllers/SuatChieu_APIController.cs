using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cinema.Areas.Admin.Data;
using Cinema.Areas.Admin.Models;

namespace Cinema.Areas.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SuatChieu_APIController : ControllerBase
    {
        private readonly DPContext _context;

        public SuatChieu_APIController(DPContext context)
        {
            _context = context;
        }

        // GET: api/SuatChieu_API
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SuatChieuModel>>> Gettb_SuatChieu()
        {
            return await _context.tb_SuatChieu.ToListAsync();
        }

        
        // GET: api/SuatChieu_API/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SuatChieuModel>> GetSuatChieuModel(int id)
        {
            var suatChieuModel = await _context.tb_SuatChieu.FindAsync(id);

            if (suatChieuModel == null)
            {
                return NotFound();
            }

            return suatChieuModel;
        }

        // PUT: api/SuatChieu_API/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSuatChieuModel(int id, SuatChieuModel suatChieuModel)
        {
            if (id != suatChieuModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(suatChieuModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SuatChieuModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/SuatChieu_API
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SuatChieuModel>> PostSuatChieuModel(SuatChieuModel suatChieuModel)
        {
            _context.tb_SuatChieu.Add(suatChieuModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSuatChieuModel", new { id = suatChieuModel.Id }, suatChieuModel);
        }

        // DELETE: api/SuatChieu_API/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SuatChieuModel>> DeleteSuatChieuModel(int id)
        {
            var suatChieuModel = await _context.tb_SuatChieu.FindAsync(id);
            if (suatChieuModel == null)
            {
                return NotFound();
            }

            if (suatChieuModel.TrangThai)
            {
                suatChieuModel.TrangThai = false;
            }

            
            await _context.SaveChangesAsync();

            return suatChieuModel;
        }

        private bool SuatChieuModelExists(int id)
        {
            return _context.tb_SuatChieu.Any(e => e.Id == id);
        }
    }
}
