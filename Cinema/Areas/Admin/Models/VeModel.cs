using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Areas.Admin.Models
{
    public class VeModel
    {
        public int Id { get; set; }

        [Range(1000, 100000000000)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 3)")]
        public decimal Gia { get; set; }

        public int MaHoaDon { get; set; }
        [ForeignKey("MaHoaDon")]
        public virtual HoaDonModel HoaDon { get; set; }

        public int MaGhe { get; set; }
        [ForeignKey("MaGhe")]
        public virtual GheModel Ghe { get; set; }


        public int MaSuat { get; set; }
        [ForeignKey("MaSuat")]
        public virtual SuatChieuModel SuatChieu { get; set; }

        public int TrangThai { get; set; }
    }
}

