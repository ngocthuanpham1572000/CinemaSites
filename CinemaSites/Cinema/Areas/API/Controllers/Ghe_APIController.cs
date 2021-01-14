using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cinema.Areas.Admin.Data;
using Cinema.Areas.Admin.Models;

namespace Cinema.Areas.API
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Ghe_APIController : ControllerBase
    {
        private readonly DPContext _context;

        public Ghe_APIController(DPContext context)
        {
            _context = context;
        }

        // GET: api/Ghe_API
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GheModel>>> Gettb_Ghe()
        {
            return await _context.tb_Ghe.ToListAsync();
        }

        // GET: api/Ghe_API/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GheModel>> GetGheModel(int id)
        {
            var gheModel = await _context.tb_Ghe.FindAsync(id);

            if (gheModel == null)
            {
                return NotFound();
            }

            return gheModel;
        }

        // PUT: api/Ghe_API/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGheModel(int id, GheModel gheModel)
        {
            if (id != gheModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(gheModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GheModelExists(id))
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

        // POST: api/Ghe_API
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<GheModel>> PostGheModel(GheModel gheModel)
        {
            _context.tb_Ghe.Add(gheModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGheModel", new { id = gheModel.Id }, gheModel);
        }

        // DELETE: api/Ghe_API/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<GheModel>> DeleteGheModel(int id)
        {
            var gheModel = await _context.tb_Ghe.FindAsync(id);
            if (gheModel == null)
            {
                return NotFound();
            }

            if(gheModel.TrangThai)
            {
                gheModel.TrangThai = false;
            }
            else
            {
                gheModel.TrangThai = true;
            }
            await _context.SaveChangesAsync();

            return gheModel;
        }

        private bool GheModelExists(int id)
        {
            return _context.tb_Ghe.Any(e => e.Id == id);
        }
    }
}
