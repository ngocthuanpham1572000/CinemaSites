using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cinema.Areas.Admin.Models;
namespace Cinema.Areas.Admin.Data
{
    public class DPContext :DbContext
    {
        public DPContext(DbContextOptions<DPContext> options) : base(options)
        { 
        }
        public DbSet<AdminModel> tb_Admin { get; set; }
         public DbSet<LoaiPhimModel> tb_LoaiPhim { get; set; }
        public DbSet<PhimModel> tb_Phim { get; set; }
        public DbSet<CumRapModel> tb_CumRap { get; set; }
        public DbSet<RapPhimModel> tb_RapPhim { get; set; }
        public DbSet<PhongModel> tb_Phong { get; set; }
        public DbSet<HangGheModel> tb_HangGhe { get; set; }
        public DbSet<GheModel> tb_Ghe { get; set; }
        public DbSet<ThanhVienModel> tb_ThanhVien { get; set; }
        public DbSet<SuatChieuModel> tb_SuatChieu { get; set; }
        public DbSet<HoaDonModel> tb_HoaDon { get; set; }
        public DbSet<VeModel> tb_Ve { get; set; }
    }
}
