using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cinema.Areas.Admin.Data;
using Cinema.Areas.Admin.Models;

namespace Cinema.Areas.API.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HangGhe_APIController : ControllerBase
    {
        private readonly DPContext _context;

        public HangGhe_APIController(DPContext context)
        {
            _context = context;
        }

        // GET: api/HangGhe_API
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HangGheModel>>> Gettb_HangGhe()
        {
            return await _context.tb_HangGhe.ToListAsync();
        }

        // GET: api/HangGhe_API/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HangGheModel>> GetHangGheModel(int id)
        {
            var hangGheModel = await _context.tb_HangGhe.FindAsync(id);

            if (hangGheModel == null)
            {
                return NotFound();
            }

            return hangGheModel;
        }

        // PUT: api/HangGhe_API/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHangGheModel(int id, HangGheModel hangGheModel)
        {
            if (id != hangGheModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(hangGheModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HangGheModelExists(id))
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

        // POST: api/HangGhe_API
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<HangGheModel>> PostHangGheModel(HangGheModel hangGheModel)
        {
            _context.tb_HangGhe.Add(hangGheModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHangGheModel", new { id = hangGheModel.Id }, hangGheModel);
        }

        // DELETE: api/HangGhe_API/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<HangGheModel>> DeleteHangGheModel(int id)
        {
            var hangGheModel = await _context.tb_HangGhe.FindAsync(id);
            if (hangGheModel == null)
            {
                return NotFound();
            }
            if (hangGheModel.TrangThai)
            {
                hangGheModel.TrangThai = false;
            }
            else
            {
                hangGheModel.TrangThai = true;
            }
            await _context.SaveChangesAsync();

            return hangGheModel;
        }

        private bool HangGheModelExists(int id)
        {
            return _context.tb_HangGhe.Any(e => e.Id == id);
        }
    }
}
