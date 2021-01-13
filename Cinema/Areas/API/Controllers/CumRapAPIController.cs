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
    [Route("api/[controller]")]
    [ApiController]
    public class CumRapAPIController : ControllerBase
    {
        private readonly DPContext _context;

        public CumRapAPIController(DPContext context)
        {
            _context = context;
        }

        // GET: api/CumRapAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CumRapModel>>> Gettb_CumRap()
        {
            return await _context.tb_CumRap.ToListAsync();
        }

        // GET: api/CumRapAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CumRapModel>> GetCumRapModel(int id)
        {
            var cumRapModel = await _context.tb_CumRap.FindAsync(id);

            if (cumRapModel == null)
            {
                return NotFound();
            }

            return cumRapModel;
        }

        // PUT: api/CumRapAPI/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCumRapModel(int id, CumRapModel cumRapModel)
        {
            if (id != cumRapModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(cumRapModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CumRapModelExists(id))
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

        // POST: api/CumRapAPI
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CumRapModel>> PostCumRapModel(CumRapModel cumRapModel)
        {
            _context.tb_CumRap.Add(cumRapModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCumRapModel", new { id = cumRapModel.Id }, cumRapModel);
        }

        // DELETE: api/CumRapAPI/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CumRapModel>> DeleteCumRapModel(int id)
        {
            var cumRapModel = await _context.tb_CumRap.FindAsync(id);
            cumRapModel.TrangThai = false;
            if (cumRapModel == null)
            {
                return NotFound();
            }

            //_context.tb_CumRap.Remove(cumRapModel);
            await _context.SaveChangesAsync();

            return cumRapModel;
        }

        private bool CumRapModelExists(int id)
        {
            return _context.tb_CumRap.Any(e => e.Id == id);
        }
    }
}
