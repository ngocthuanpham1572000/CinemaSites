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
        public string TenPhong { get; set; }

       
        [Required]
        public int MaRap { get; set; }
        public bool TrangThai { get; set; }
        [ForeignKey("MaRap")]
        public virtual RapPhimModel Rap { get; set; }
        public ICollection<HangGheModel> lstHangGhe { get; set; }
        public ICollection<SuatChieuModel> lstSuatChieu { get; set; }

    }
}
