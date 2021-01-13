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
    public class Phong_APIController : ControllerBase
    {
        private readonly DPContext _context;

        public Phong_APIController(DPContext context)
        {
            _context = context;
        }

        // GET: api/Phong_API
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PhongModel>>> Gettb_Phong()
        {
            return await _context.tb_Phong.ToListAsync();
        }

        // GET: api/Phong_API/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PhongModel>> GetPhongModel(int id)
        {
            var phongModel = await _context.tb_Phong.FindAsync(id);

            if (phongModel == null)
            {
                return NotFound();
            }

            return phongModel;
        }

        // PUT: api/Phong_API/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPhongModel(int id, PhongModel phongModel)
        {
            if (id != phongModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(phongModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PhongModelExists(id))
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

        // POST: api/Phong_API
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<PhongModel>> PostPhongModel(PhongModel phongModel)
        {
            _context.tb_Phong.Add(phongModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPhongModel", new { id = phongModel.Id }, phongModel);
        }

        // DELETE: api/Phong_API/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PhongModel>> DeletePhongModel(int id)
        {
            var phongModel = await _context.tb_Phong.FindAsync(id);
            if (phongModel == null)
            {
                return NotFound();
            }
            if (phongModel.TrangThai)
                phongModel.TrangThai = false;
            else
                phongModel.TrangThai = true;
            await _context.SaveChangesAsync();

            return phongModel;
        }

        private bool PhongModelExists(int id)
        {
            return _context.tb_Phong.Any(e => e.Id == id);
        }
    }
}
