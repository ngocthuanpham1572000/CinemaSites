using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Areas.Admin.Models
{
    public class PhongModel
    {
        public int Id { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Required]
        public int TenPhong { get; set; }

        public int TrangThai { get; set; }
        public int Rap { get; set; }
        [ForeignKey("Rap")]
        public virtual RapPhimModel MaRapPhim { get; set; }
        public ICollection<HangGheModel> LstHangGhe { get; set; }
        public ICollection<SuatChieuModel> LstSuatChieu { get; set; }

    }
}
