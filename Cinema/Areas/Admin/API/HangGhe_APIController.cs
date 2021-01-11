using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cinema.Areas.Admin.Data;
using Cinema.Areas.Admin.Models;

namespace Cinema.Areas.Admin.API
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

        // GET: api/HangGhe_API_
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HangGheModel>>> Gettb_HangGhe()
        {
            return await _context.tb_HangGhe.ToListAsync();
        }

        // GET: api/HangGhe_API_/5
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

        // PUT: api/HangGhe_API_/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<int> PutHangGheModel(int id, HangGheModel hangGheModel)
        {
            if (id != hangGheModel.Id)
            {
                return 0;
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
                    return 0;
                }
                else
                {
                    return 1;
                }
            }

            return 1;
        }

        // POST: api/HangGhe_API_
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<HangGheModel>> PostHangGheModel(HangGheModel hangGheModel)
        {
            _context.tb_HangGhe.Add(hangGheModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHangGheModel", new { id = hangGheModel.Id }, hangGheModel);
        }

        // DELETE: api/HangGhe_API_/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<HangGheModel>> DeleteHangGheModel(int id)
        {
            var hangGheModel = await _context.tb_HangGhe.FindAsync(id);
            if (hangGheModel == null)
            {
                return NotFound();
            }

            _context.tb_HangGhe.Remove(hangGheModel);
            await _context.SaveChangesAsync();

            return hangGheModel;
        }

        private bool HangGheModelExists(int id)
        {
            return _context.tb_HangGhe.Any(e => e.Id == id);
        }
    }
}
