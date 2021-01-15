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
    public class LoaiPhim_APIController : ControllerBase
    {
        private readonly DPContext _context;

        public LoaiPhim_APIController(DPContext context)
        {
            _context = context;
        }

        // GET: api/LoaiPhim_API
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LoaiPhimModel>>> Gettb_LoaiPhim()
        {
            return await _context.tb_LoaiPhim.ToListAsync();
        }

        // GET: api/LoaiPhim_API/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LoaiPhimModel>> GetLoaiPhimModel(int id)
        {
            var loaiPhimModel = await _context.tb_LoaiPhim.FindAsync(id);

            if (loaiPhimModel == null)
            {
                return NotFound();
            }

            return loaiPhimModel;
        }

        // PUT: api/LoaiPhim_API/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLoaiPhimModel(int id, LoaiPhimModel loaiPhimModel)
        {
            if (id != loaiPhimModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(loaiPhimModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoaiPhimModelExists(id))
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

        // POST: api/LoaiPhim_API
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<LoaiPhimModel>> PostLoaiPhimModel(LoaiPhimModel loaiPhimModel)
        {
            _context.tb_LoaiPhim.Add(loaiPhimModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLoaiPhimModel", new { id = loaiPhimModel.Id }, loaiPhimModel);
        }

        // DELETE: api/LoaiPhim_API/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LoaiPhimModel>> DeleteLoaiPhimModel(int id)
        {
            var loaiPhimModel = await _context.tb_LoaiPhim.FindAsync(id);
            if (loaiPhimModel == null)
            {
                return NotFound();
            }
            if (loaiPhimModel.TrangThai)
            {
                loaiPhimModel.TrangThai = false;
            }
            await _context.SaveChangesAsync();

            return loaiPhimModel;
        }

        private bool LoaiPhimModelExists(int id)
        {
            return _context.tb_LoaiPhim.Any(e => e.Id == id);
        }
    }
}
