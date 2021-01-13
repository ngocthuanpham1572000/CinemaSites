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
    public class RapPhimAPIController : ControllerBase
    {
        private readonly DPContext _context;

        public RapPhimAPIController(DPContext context)
        {
            _context = context;
        }

        // GET: api/RapPhimAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RapPhimModel>>> Gettb_RapPhim()
        {
            return await _context.tb_RapPhim.ToListAsync();
        }

        // GET: api/RapPhimAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RapPhimModel>> GetRapPhimModel(int id)
        {
            var rapPhimModel = await _context.tb_RapPhim.FindAsync(id);

            if (rapPhimModel == null)
            {
                return NotFound();
            }

            return rapPhimModel;
        }

        // PUT: api/RapPhimAPI/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRapPhimModel(int id, RapPhimModel rapPhimModel)
        {
            if (id != rapPhimModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(rapPhimModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RapPhimModelExists(id))
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

        // POST: api/RapPhimAPI
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<RapPhimModel>> PostRapPhimModel(RapPhimModel rapPhimModel)
        {
            _context.tb_RapPhim.Add(rapPhimModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRapPhimModel", new { id = rapPhimModel.Id }, rapPhimModel);
        }

        // DELETE: api/RapPhimAPI/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<RapPhimModel>> DeleteRapPhimModel(int id)
        {
            
            var rapPhimModel = await _context.tb_RapPhim.FindAsync(id);
            rapPhimModel.TrangThai = false;
            if (rapPhimModel == null)
            {
                return NotFound();
            }

            //_context.tb_RapPhim.Remove(rapPhimModel);
            await _context.SaveChangesAsync();

            return rapPhimModel;
        }

        private bool RapPhimModelExists(int id)
        {
            return _context.tb_RapPhim.Any(e => e.Id == id);
        }
    }
}
