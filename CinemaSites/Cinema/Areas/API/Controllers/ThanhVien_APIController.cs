using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cinema.Areas.Admin.Data;
using Cinema.Areas.Admin.Models;
using Newtonsoft.Json;

namespace Cinema.Areas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThanhVien_APIController : ControllerBase
    {
        private readonly DPContext _context;

        public ThanhVien_APIController(DPContext context)
        {
            _context = context;
        }

        // GET: api/ThanhVien_API
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ThanhVienModel>>> Gettb_ThanhVien()
        {
            return await _context.tb_ThanhVien.ToListAsync();
        }

        public class SignIn
        {
            public string username { get; set; }
            public string pass { get; set; }
        }

        //Post:Đăng nhập
        [HttpPost("SignIns")]
        public async Task<ActionResult<bool>> SignIns(SignIn member)
        {
            var r = _context.tb_ThanhVien.Where(m => (m.TaiKhoan == member.username && m.MatKhau == StringProcessing.CreateMD5Hash(member.pass))).ToList();
            if (r.Count == 0)
            {
                return false;
            }
            if (r[0].TrangThai == true)
            {
                var str = JsonConvert.SerializeObject(r[0]);
                if (HttpContext.Session.GetString("user") == null)
                {
                    HttpContext.Session.SetString("user", str);
                    return true;
                }
            }
            else
            {
                return false;
            }
            return false;
        }



        // GET: api/ThanhVien_API/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ThanhVienModel>> GetThanhVienModel(int id)
        {
            var thanhVienModel = await _context.tb_ThanhVien.FindAsync(id);

            if (thanhVienModel == null)
            {
                return NotFound();
            }

            return thanhVienModel;
        }

        // PUT: api/ThanhVien_API/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutThanhVienModel(int id, ThanhVienModel thanhVienModel)
        {
            if (id != thanhVienModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(thanhVienModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ThanhVienModelExists(id))
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

        // POST: api/ThanhVien_API
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ThanhVienModel>> PostThanhVienModel(ThanhVienModel thanhVienModel)
        {
            _context.tb_ThanhVien.Add(thanhVienModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetThanhVienModel", new { id = thanhVienModel.Id }, thanhVienModel);
        }

        // DELETE: api/ThanhVien_API/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ThanhVienModel>> DeleteThanhVienModel(int id)
        {
            var thanhVienModel = await _context.tb_ThanhVien.FindAsync(id);
            if (thanhVienModel == null)
            {
                return NotFound();
            }

            //_context.tb_ThanhVien.Remove(thanhVienModel);
            if (thanhVienModel.TrangThai)
                thanhVienModel.TrangThai = false;
            else
                thanhVienModel.TrangThai = true;
            await _context.SaveChangesAsync();

            return thanhVienModel;
        }

        private bool ThanhVienModelExists(int id)
        {
            return _context.tb_ThanhVien.Any(e => e.Id == id);
        }
    }
}
